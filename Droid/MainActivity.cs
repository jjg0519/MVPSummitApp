using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Droid;
using Octane.Xam.VideoPlayer.Android;
using Android.Content.Res;
using FFImageLoading;

namespace MVPSummitApp.Droid
{
	//[Activity(Label = "MVPSummitApp.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	[Activity(Label = "MVPSummitApp.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme",  ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{


			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			global::Xamarin.Forms.Forms.Init(this, bundle); 
			FormsVideoPlayer.Init();

			CachedImageRenderer.Init();

			Application.RegisterComponentCallbacks(new LifecycleCallbacks());

			LoadApplication(new App());
		}


	}
	public class LifecycleCallbacks : Java.Lang.Object, IComponentCallbacks2
	{


		public void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			//if (level == TrimMemory.UiHidden)
			//{
			//	Console.WriteLine("Backgrounded...");
			//}    
			ImageService.Instance.InvalidateMemoryCache();
			GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
			//base.OnTrimMemory(level);

		}

		public void OnConfigurationChanged(Configuration newConfig)
		{
		}

		public void OnLowMemory()
		{
		}
	}
}
