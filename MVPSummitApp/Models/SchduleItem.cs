using System;
using Xamvvm;
using Newtonsoft.Json;

namespace MVPSummitApp
{
	public class SchduleItem : BasePageModel
	{
		int id;
		[JsonProperty("ID")]
		public int ID
		{
			get { return id; }
			set { SetField(ref id, value); }
		}

		string sessionName;
		[JsonProperty("SessionName")]
		public string SessionName
		{
			get { return sessionName; }
			set { SetField(ref sessionName, value); }

		}

		string sessionTime;
		[JsonProperty("SessionTime")]
		public string SessionTime
		{
			get { return sessionTime; }
			set { SetField(ref sessionTime, value); }

		}

		string sessionLocation;
		[JsonProperty("SessionLocation")]
		public string SessionLocation
		{
			get { return sessionLocation; }
			set { SetField(ref sessionLocation, value); }

		}

		string sessionGroup;
		[JsonProperty("SessionGroup")]
		public string SessionGroup
		{
			get { return sessionGroup; }
			set { SetField(ref sessionGroup, value); }

		}
	}
}
