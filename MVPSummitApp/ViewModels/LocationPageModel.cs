using System;
using System.Collections.Generic;
using System.Text;
using Xamvvm;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MVPSummitApp
{
	public class LocationPageModel : BasePageModel
	{
		public LocationPageModel()
		{

			Locations = new ObservableCollection<LocationItem>
			{
				new LocationItem
				{
					ImgURL = "location1.png"
				},
				new LocationItem
				{
					ImgURL = "location2.png"
					},
				new LocationItem
				{
					ImgURL = "location3.png"
				}
			};

		}

		public ObservableCollection<LocationItem> Locations
		{
			get { return GetField<ObservableCollection<LocationItem>>(); }
			set { SetField(value); }
		}
	}
}
