using System;
using Xamvvm;
using Newtonsoft.Json;

namespace MVPSummitApp
{
	public class VideoItem : BasePageModel
	{
		int videoID;
		[JsonProperty("VideoID")]
		public int VideoID
		{
			get { return videoID; }
			set { SetField(ref videoID, value); }
		}

		string videoName;
		[JsonProperty("VideoName")]
		public string VideoName
		{
			get { return videoName; }
			set { SetField(ref videoName, value); }

		}

		string videoVendor;
		[JsonProperty("VideoVendor")]
		public string VideoVendor
		{
			get { return videoVendor; }
			set { SetField(ref videoVendor, value); }

		}

		string videoDate;
		[JsonProperty("VideoDate")]
		public string VideoDate
		{
			get { return videoDate; }
			set { SetField(ref videoDate, value); }

		}

		string videoURL;
		[JsonProperty("VideoURL")]
		public string VideoURL
		{
			get { return videoURL; }
			set { SetField(ref videoURL, value); }

		}

		string videoImg;
		[JsonProperty("VideoImg")]
		public string VideoImg
		{
			get { return videoImg; }
			set { SetField(ref videoImg, value); }

		}
	}
}
