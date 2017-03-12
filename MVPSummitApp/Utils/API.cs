using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;


namespace MVPSummitApp
{
	public static class API
	{
		public static string ScheduleList = "http://course.gdou.com/mvp/api/getschudlelist";

		public static string NewsList = "http://course.gdou.com/mvp/api/getnewslist";

		public static string VideoList = "http://course.gdou.com/mvp/api/getvideolist";

		public static async Task<string> LoadData(string url)
		{
			// move layout under the status bar
			string result = "";
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                 result = await client.GetStringAsync(url);
                return result;
            }
		}
	}

	public class Grouping<K, T> : ObservableCollection<T>
	{
		public K Key { get; private set; }

		public Grouping(K key, IEnumerable<T> items)
		{
			Key = key;
			foreach (var item in items)
				this.Items.Add(item);
		}
	}
}
