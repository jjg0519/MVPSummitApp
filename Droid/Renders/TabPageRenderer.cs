using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using MVPSummitApp.Droid;
using Xamarin.Forms.Platform.Android.AppCompat;
using System.Reflection;


[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabPageRenderer))]
namespace MVPSummitApp.Droid
{
	public class TabPageRenderer : TabbedPageRenderer
	{

	    protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
	    {

	        var info = typeof(TabbedPageRenderer).GetTypeInfo();
	        var fieldInfo = info.GetField("_useAnimations", BindingFlags.Instance | BindingFlags.NonPublic);
	        fieldInfo.SetValue(this, false);
	        base.OnElementChanged(e);
	    }
	}
}
