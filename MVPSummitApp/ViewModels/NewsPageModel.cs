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
			if (IsLoading) return;
			IsLoading = true;
			try
			{
				var resultList = await API.LoadData(API.NewsList);
				NewsItems = JsonConvert.DeserializeObject<ObservableCollection<NewsInfoItem>>(resultList);

			}
			catch (Exception ex)
			{
				var page = new ContentPage();
				var result = page.DisplayAlert("加载出错", "数据加载出错，请检查网络", "确认");
			}
			IsLoading = false;
		}

		public ObservableCollection<NewsInfoItem> NewsItems
		{
			get { return GetField<ObservableCollection<NewsInfoItem>>(); }
			set { SetField(value); }
		}
		bool isLoading;
		public bool IsLoading
		{
			get { return isLoading; }
			set { SetField(ref isLoading, value); }
		}



		public ICommand ItemSelectedCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}


	}
}
