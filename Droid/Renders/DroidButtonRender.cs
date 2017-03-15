using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Support.V7.Widget;
using System.Reflection;
using MVPSummitApp.Droid;

[assembly: ExportRenderer(typeof(Button), typeof(DriodButtonRender))]
namespace MVPSummitApp.Droid
{
	public class DriodButtonRender : ButtonRenderer
	{
		protected override void OnDraw(Android.Graphics.Canvas canvas)
		{
			base.OnDraw(canvas);


		}
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			//AppCompatButton button
			var button = e.NewElement;
			button.BorderColor = Color.Transparent;
			button.BorderWidth = 0;
			//var info = typeof(ButtonRenderer).GetTypeInfo();
			//var fieldInfo = info.GetField("_border", BindingFlags.Instance | BindingFlags.NonPublic);
			//fieldInfo.SetValue(this, 0);

		}
	}
}
