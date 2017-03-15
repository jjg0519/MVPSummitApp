using System;
using Xamvvm;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MVPSummitApp
{
	public class NewsInfoItem : BasePageModel
	{
		int id;
		[JsonProperty("ID")]
		public int ID
		{
			get { return id; }
			set { SetField(ref id, value); }
		}
		string newsTitle;
		[JsonProperty("NewsTitle")]
		public string NewsTitle
		{
			get { return newsTitle; }
			set { SetField(ref newsTitle, value); }
		}
		string newsDate;
		[JsonProperty("NewsDate")]
		public string NewsDate
		{
			get { return newsDate; }
			set { SetField(ref newsDate, value); }
		}
		string newsLocation;
		[JsonProperty("NewsLocation")]
		public string NewsLocation
		{
			get { return newsLocation; }
			set { SetField(ref newsLocation, value); }
		}
		ObservableCollection<NewsItem> newsList;
		[JsonProperty("NewsList")]
		public ObservableCollection<NewsItem> NewsList
		{
			get { return newsList; }
			set { SetField(ref newsList, value); }
		}



	}
}

