using System;
using Android.Graphics;
using Square.Picasso;

namespace MVPSummitApp.Droid
{
	public class CropSquareTransformation : Java.Lang.Object, ITransformation
	{
	    public Bitmap Transform(Bitmap source)
	    {
	        int size = Math.Min(source.Width, source.Height);
			int x = (source.Width- size) / 2;
			int y = (source.Height - size) / 2;
	        Bitmap result = Bitmap.CreateBitmap(source, x, y, size, size);
	        if (result != source) {
	            source.Recycle();
	        }
	        return result;
	    }

	    public string Key
	    {
	        get { return "square()"; } 
	    }
	}
}
