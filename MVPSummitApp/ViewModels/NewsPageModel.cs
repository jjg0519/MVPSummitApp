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
	public class NewsPageModel : BasePageModel
	{
		public NewsPageModel()
		{


			//ItemSelectedCommand = new Command<SelectedItemChangedEventArgs>((arg) =>
			//{
			//	Console.WriteLine("123");
			//});

			LoadData();


		}
		public async Task LoadData()
		{
			var resultList = await API.LoadData(API.NewsList);
			NewsItems = JsonConvert.DeserializeObject<ObservableCollection<NewsInfoItem>>(resultList);
		}

		public ObservableCollection<NewsInfoItem> NewsItems
		{
			get { return GetField<ObservableCollection<NewsInfoItem>>(); }
			set { SetField(value); }
		}



		public ICommand ItemSelectedCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}


	}
}
