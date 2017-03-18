using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FFImageLoading;
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

//#if __ANDROID__

//			list.SelectedItem = null;
//#endif
//#if __IOS__

			var galleryList = (ObservableCollection<NewsItem>)list.ItemsSource;

			var selectedItem = e.SelectedItem as NewsItem;

			list.SelectedItem = null;

			await this.Navigation.PushModalAsync(new GalleryPage(galleryList, selectedItem), true);
//#endif
		}

		public NewsPage()
		{
			InitializeComponent();

			LoadImage();
			//var temp = NewsInfoList.ItemTemplate.Bindings;

			//_myListView.ScrollStateChanged += (object sender, ScrollStateChangedEventArgs scrollArgs) =>
			//{
			//	switch (scrollArgs.ScrollState)
			//	{
			//		case ScrollState.Fling:
			//			ImageService.Instance.SetPauseWork(true); // all image loading requests will be silently canceled
			//			break;
			//		case ScrollState.Idle:
			//			ImageService.Instance.SetPauseWork(false); // loading requests are allowed again

			//			// Here you should have your custom method that forces redrawing visible list items
			//			_myListView.ForcePdfThumbnailsRedraw();
			//			break;
			//	}
			//};
		}

		async void LoadImage()
		{

			await ImageService.Instance.InvalidateDiskCacheAsync();
		}

	}
}
