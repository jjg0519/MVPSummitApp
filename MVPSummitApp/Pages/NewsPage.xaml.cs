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


		public NewsPage()
		{
			InitializeComponent();

			LoadImage();
		}

		async void LoadImage()
		{

			await ImageService.Instance.InvalidateDiskCacheAsync();
		}

	}
}
