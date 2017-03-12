using System;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();


			var factory = new XamvvmFormsFactory(this);
			factory.RegisterTabbedPage<MainPageModel>(new Type[]
	        {
				typeof(SchedulePageModel),
				typeof(LocationPageModel),
				typeof(NewsPageModel),
				typeof(VideoPageModel)
			},true);
			//factory.RegisterTabbedPage<MainPageModel>(
			XamvvmCore.SetCurrentFactory(factory);




			var mainPage = this.GetPageFromCache<MainPageModel>() as MainPage;

			var schedulePage = this.GetPageFromCache<SchedulePageModel>() as SchedulePage;
			var locationPage = this.GetPageFromCache<LocationPageModel>() as LocationPage;
			var newsPage = this.GetPageFromCache<NewsPageModel>() as NewsPage;
			var videoPage = this.GetPageFromCache<VideoPageModel>() as VideoPage;

			mainPage.Children.Add(schedulePage);

			mainPage.Children.Add(locationPage);

			mainPage.Children.Add(newsPage);

			mainPage.Children.Add(videoPage);

			//mainPage.BarBackgroundColor = Color.FromRgb(0, 34, 78);

			//mainPage.BarTextColor = Color.White;

			MainPage = new NavigationPage(mainPage)
			{
				BarBackgroundColor = Color.FromRgb(10, 79, 157),
				BarTextColor = Color.White
			};

			//MainPage = new NavigationPage(new MainPage())
			//{
			//	BarBackgroundColor = Color.FromRgb(0, 34, 78),
			//	BarTextColor = Color.White,
			//}; 
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
