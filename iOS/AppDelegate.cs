using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading.Forms.Touch;
using Foundation;
using Octane.Xam.VideoPlayer.iOS;
using UIKit;

namespace MVPSummitApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			
			global::Xamarin.Forms.Forms.Init();


			CachedImageRenderer.Init();
			FormsVideoPlayer.Init();

			var statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;

			if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
			{
				statusBar.BackgroundColor = UIColor.FromRGB(10, 79, 157); //UIColor.FromRGB(0, 120, 215);
			}

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
