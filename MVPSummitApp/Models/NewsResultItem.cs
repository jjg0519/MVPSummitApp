using System;
using Xamvvm;

namespace MVPSummitApp
{


	public class NewsResultItem : BasePageModel
	{
		string newsTitle;
		public string NewsTitle
		{
			get { return newsTitle; }
			set { SetField(ref newsTitle, value); }
		}
		string photoURL;
		public string PhotoURL
		{
			get { return photoURL; }
			set { SetField(ref photoURL, value); }
		}
	}
}
