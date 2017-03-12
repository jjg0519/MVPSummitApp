using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public partial class NewsPage : IBasePage<NewsPageModel>
	{
		

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var list = (ListView)sender;



			var galleryList = (ObservableCollection<NewsItem>)list.ItemsSource;

			var selectedItem = e.SelectedItem as NewsItem;



			await this.Navigation.PushModalAsync(new GalleryPage(galleryList,selectedItem),true);
		}

		public NewsPage()
		{
			InitializeComponent();
		}
	}
}
