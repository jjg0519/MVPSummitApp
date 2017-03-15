using System;
using System.Collections.Generic;
using System.Text;
using Xamvvm;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVPSummitApp
{
	public class VideoPageModel : BasePageModel
	{
		public VideoPageModel()
		{
			LoadData();


		}
		public async Task LoadData()
		{
			if (IsLoading) return;
			IsLoading = true;
			try
			{
				var resultList = await API.LoadData(API.VideoList);
				VideoItems = JsonConvert.DeserializeObject<ObservableCollection<VideoItem>>(resultList);
			}
			catch (Exception ex)
			{
				var page = new ContentPage();
				var result = page.DisplayAlert("加载出错", "数据加载出错，请检查网络", "确认");
			}
			IsLoading = false;
		}

		bool isLoading;
		public bool IsLoading
		{
			get { return isLoading; }
			set { SetField(ref isLoading, value); }
		}

		public ObservableCollection<VideoItem> VideoItems
		{
			get { return GetField<ObservableCollection<VideoItem>>(); }
			set { SetField(value); }
		}

		public ICommand ItemSelectedCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}
	}
}
