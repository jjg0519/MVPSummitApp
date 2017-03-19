using System;
using System.Collections.Generic;
using System.Text;
using Xamvvm;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace MVPSummitApp
{
	public class NewsPageModel : BasePageModel
	{
		public NewsPageModel()
		{



			LoadData();


			ItemTappedCommand = new BaseCommand((param) =>
			{
				var item = param as NewsResultItem;
				var page =this.GetPageAsNewInstance<GalleryPageModel>() as GalleryPage;
				page.LoadImage(item.PhotoURL);
				this.PushModalPageAsync(page);

			});

		}
		public async Task LoadData()
		{
			if (IsLoading) return;
			IsLoading = true;
			try
			{
				var resultList = await API.LoadData(API.NewsList);
				//NewsItems
				NewsItems= JsonConvert.DeserializeObject<ObservableCollection<NewsInfoItem>>(resultList);


				ObservableCollection<NewsResultItem> resultItemList = new ObservableCollection<NewsResultItem>();
				foreach (var item in NewsItems)
				{
					foreach (var i in item.NewsList)
					{
						NewsResultItem resultItem = new NewsResultItem();
						//NewsInfoResultItem info = new NewsInfoResultItem();
						resultItem.NewsTitle = item.NewsTitle+"("+item.NewsDate.Trim()+")";
						//resultItem.NewsInfo = info;
						resultItem.PhotoURL = i.PhotoURL;
						Console.WriteLine(resultItem.PhotoURL);
						resultItemList.Add(resultItem);
					}
				};


				var trans = from p in resultItemList
								 group p by p.NewsTitle into ListGroup
								 select new Grouping<string, NewsResultItem>(ListGroup.Key, ListGroup);

				Items = new ObservableCollection<Grouping<string, NewsResultItem>>(trans);

			}
			catch (Exception ex)
			{
				var page = new ContentPage();
				var result = page.DisplayAlert("加载出错", "数据加载出错，请检查网络", "确认");
			}
			IsLoading = false;
		}	
		public ObservableCollection<Grouping<string, NewsResultItem>> Items
		{
			get { return GetField<ObservableCollection<Grouping<string, NewsResultItem>>>(); }
	           set { SetField(value);}
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




		public ICommand ItemTappedCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}


	}

}
