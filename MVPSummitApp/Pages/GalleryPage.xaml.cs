using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FFImageLoading;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public partial class GalleryPage : IBasePage<GalleryPageModel>
	{
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync();
		}

		public GalleryPage()
		{
			InitializeComponent();

			if (Device.OS == TargetPlatform.iOS)
			{
				this.GalleryStack.Margin = new Thickness(0, 20, 0, 0);
			}

			this.BackgroundColor = Color.FromRgb(0, 34, 78);
		}

		public void LoadImage(string url)
		{

			imageViewer.Source = ImageSource.FromUri(new Uri(url));
		}

		public string URL
		{
			get;set;
		}

		async void LoadImage()
		{

			await ImageService.Instance.InvalidateDiskCacheAsync();
		}
	}
}
