using System;
using System.Threading.Tasks;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();


			FlowListView.Init();

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



			MainPage = new NavigationPage(mainPage)
			{
				BarBackgroundColor = Color.FromRgb(10, 79, 157),
				BarTextColor = Color.White
			};
			//mainPage.DisplayAlert("1", "1", "1");

			//var schedulePage = this.GetPageFromCache<SchedulePageModel>() as SchedulePage;
			//var locationPage = this.GetPageFromCache<LocationPageModel>() as LocationPage;
			//var newsPage = this.GetPageFromCache<NewsPageModel>() as NewsPage;
			//var videoPage = this.GetPageFromCache<VideoPageModel>() as VideoPage;

			//mainPage.Children.Add(schedulePage);

			//mainPage.Children.Add(locationPage);

			//mainPage.Children.Add(newsPage);

			//mainPage.Children.Add(videoPage);

			//mainPage.BarBackgroundColor = Color.FromRgb(0, 34, 78);

			//mainPage.BarTextColor = Color.White;

			//MainPage = new NavigationPage(new MainPage())
			//{
			//	BarBackgroundColor = Color.FromRgb(0, 34, 78),
			//	BarTextColor = Color.White,
			//}; 
		}

		protected override void OnStart()
		{
			// Handle when your app starts



			//var networkConnection = DependencyService.Get<INetworkConnection>();
			//networkConnection.CheckNetworkConnection();
			//var networkStatus = networkConnection.IsConnected;

			//if (networkStatus == false)
			//{
			//	var page = new ContentPage();
			//	page.DisplayAlert("加载出错", "数据加载出错，请检查网络", "确认");
			//}
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
