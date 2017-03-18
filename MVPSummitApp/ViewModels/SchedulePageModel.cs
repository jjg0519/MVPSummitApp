using System;
using System.Collections.Generic;
using System.Text;
using Xamvvm;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVPSummitApp
{
	public class SchedulePageModel : BasePageModel
	{
		public SchedulePageModel()
		{
			//IsLoading = false;
			//}
#if __ANDROID__
			Load();
#endif
#if __IOS__
			LoadData();
#endif
		}

		public async Task Load()
		{

			await Task.Run(() => { LoadData(); });
		}

		public async Task LoadData()
		{
				if (IsLoading) return;
				IsLoading = true;
				try
				{
					var resultList = await API.LoadData(API.ScheduleList);
					var schduleItems = JsonConvert.DeserializeObject<ObservableCollection<SchduleItem>>(resultList);



					SchduleItems = from p in schduleItems
								   orderby p.SessionGroup
								   group p by p.SessionGroup into ListGroup
								   select new Grouping<string, SchduleItem>(ListGroup.Key, ListGroup);
				}
				catch (Exception ex)
				{
					var page = new ContentPage();
					var result = page.DisplayAlert("加载出错", "数据加载出错，请检查网络", "确认");
				}
				IsLoading = false;
			//}

		}



		bool isLoading;
		public bool IsLoading
		{
			get { return isLoading; }
			set { SetField(ref isLoading, value); }
		}


		public IEnumerable<Grouping<string,SchduleItem>> SchduleItems
		{
			get { return GetField<IEnumerable<Grouping<string, SchduleItem>>>(); }
			set { SetField(value); }
		}
	}
}
