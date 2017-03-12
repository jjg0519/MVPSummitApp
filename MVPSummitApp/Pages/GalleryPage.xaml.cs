using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MVPSummitApp
{
	public partial class GalleryPage : ContentPage
	{
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync();
		}

		public GalleryPage(ObservableCollection<NewsItem> galleryList, NewsItem selectedItem)
		{
			InitializeComponent();

			if (Device.OS == TargetPlatform.iOS)
			{
				this.btnClose.Margin = new Thickness(20, 20, 20, 20);
				//this.GalleryCV.Margin = new Thickness(0, -100, 0, 0);
			}

			this.BackgroundColor = Color.FromRgb(0, 34, 78);

			GalleryList = galleryList;


			//var index = galleryList.IndexOf(selectedItem);

			//this.GalleryCV.fo

			this.GalleryCV.ItemsSource = GalleryList;

			//this.GalleryCV.Position = 200;
		}

		public ObservableCollection<NewsItem> GalleryList { get; set; }
	}
}
