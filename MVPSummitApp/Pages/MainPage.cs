using System;

using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public class MainPage : TabbedPage, IBasePage<MainPageModel>
	{
		public MainPage()
		{
			Title = "2017年微软最有价值专家(中国)峰会";


			this.BarBackgroundColor = Color.FromRgb(0, 34, 78);
		}
	}
}

