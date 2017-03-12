using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public partial class VideoPage : ContentPage, IBasePage<VideoPageModel>
	{
		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (((ListView)sender).SelectedItem == null)
				return;
			var item = e?.SelectedItem as VideoItem;
			await this.Navigation.PushModalAsync(new VideoPlayerPage(item.VideoURL));

			((ListView)sender).SelectedItem = null;
		}

		public VideoPage()
		{
			InitializeComponent();
		}
	}
}
