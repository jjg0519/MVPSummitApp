using System;
using Xamvvm;
namespace MVPSummitApp
{
	public class LocationItem : BasePageModel
	{
		string imgURL;
		public string ImgURL
		{
			get { return imgURL; }
			set { SetField(ref imgURL, value); }
		}

	}
}

