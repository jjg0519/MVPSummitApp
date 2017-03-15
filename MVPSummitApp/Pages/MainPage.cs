using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamvvm;

namespace MVPSummitApp
{
	public class MainPage : TabbedPage, IBasePage<MainPageModel>
	{
		public MainPage()
		{
			Title = "2017年微软最有价值专家中国峰会";


			this.BarBackgroundColor = Color.FromRgb(0, 34, 78); 

			var networkConnection = DependencyService.Get<INetworkConnection>();
			networkConnection.CheckNetworkConnection();
			if (networkConnection.IsConnected == false)
			{
				Load();
			}
			//DisplayAlert("Alert", "You have been alerted", "OK");
			//Show();

		}

		async Task Load()
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				await DisplayAlert("网络加载出错", "网络加载出错，请打开你的蜂窝网络或链接有效的无线网络", "关闭");

			});
			//await DisplayAlert("1", "1", "1");
		}
	}
}

