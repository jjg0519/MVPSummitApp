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
			if (list.SelectedItem == null)
				return;

#if __ANDROID__

			list.SelectedItem = null;
#endif
#if __IOS__

			var galleryList = (ObservableCollection<NewsItem>)list.ItemsSource;

			var selectedItem = e.SelectedItem as NewsItem;

			list.SelectedItem = null;

			await this.Navigation.PushModalAsync(new GalleryPage(galleryList, selectedItem), true);
#endif
		}

		public NewsPage()
		{
			InitializeComponent();
		}
	}
}
