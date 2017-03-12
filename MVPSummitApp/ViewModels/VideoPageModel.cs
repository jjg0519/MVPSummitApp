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
	public class VideoPageModel : BasePageModel
	{
		public VideoPageModel()
		{
			LoadData();


			//ItemSelectedCommand = new BaseCommand<SelectedItemChangedEventArgs>((arg) =>
			//{
			//	var item = arg?.SelectedItem as VideoItem;



			//	var pageToPush = this.GetPageAsNewInstance<VideoPlayerPageModel>();

			//	this.PushModalPageAsync(pageToPush);

			//});
		}
		public async Task LoadData()
		{
			var resultList = await API.LoadData(API.VideoList);
			VideoItems = JsonConvert.DeserializeObject<ObservableCollection<VideoItem>>(resultList);
		}

		public ObservableCollection<VideoItem> VideoItems
		{
			get { return GetField<ObservableCollection<VideoItem>>(); }
			set { SetField(value); }
		}

		public ICommand ItemSelectedCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}
	}
}
