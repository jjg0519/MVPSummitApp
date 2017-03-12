using System;
using Xamvvm;
using Newtonsoft.Json;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVPSummitApp
{
	public class NewsItem : BasePageModel
	{

		public NewsItem()
		{


		}

		int id;
		[JsonProperty("ID")]
		public int ID
		{
			get { return id; }
			set { SetField(ref id, value); }
		}
		string photoURL;
		[JsonProperty("PhotoURL")]
		public string PhotoURL
		{
			get { return photoURL; }
			set { SetField(ref photoURL, value); }
		}
		string newsID;
		[JsonProperty("NewsID")]
		public string NewsID
		{
			get { return newsID; }
			set { SetField(ref newsID, value); }
		}



		
	}
}

