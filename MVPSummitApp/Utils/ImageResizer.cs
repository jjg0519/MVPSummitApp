using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

//#if __IOS__
//using System.Drawing;
//using UIKit;
//using CoreGraphics;
//#endif

#if __ANDROID__
using Android.Graphics;
#endif


namespace MVPSummitApp
{
	public static class ImageResizer
	{
		static ImageResizer()
		{
		}

//		public static async Task<byte[]> ResizeImage(byte[] imageData, float width, float height)
//		{
//#if __IOS__
//			return ResizeImageIOS(imageData, width, height);
//#endif
//#if __ANDROID__
//			return ResizeImageAndroid(imageData, width, height);
//#endif
//		}

#if __ANDROID__

		public static byte[] ResizeImageAndroid(byte[] imageData, float width, float height)
		{
			// Load the bitmap
			Bitmap originalImage = BitmapFactory.DecodeByteArray(imageData, 0, imageData.Length);
			Bitmap resizedImage = Bitmap.CreateScaledBitmap(originalImage, (int)width, (int)height, false);

			using (MemoryStream ms = new MemoryStream())
			{
				resizedImage.Compress(Bitmap.CompressFormat.Png, 100, ms);
				return ms.ToArray();
			}
		}

		public static async Task<Bitmap> GetImageBitmapFromUrlAsync(string url)
		{
			Bitmap imageBitmap = null;

			using (var httpClient = new HttpClient())
			{
				var imageBytes = await httpClient.GetByteArrayAsync(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);


					Bitmap resizedImage = Bitmap.CreateScaledBitmap(imageBitmap, 320, 180, false);

					using (MemoryStream ms = new MemoryStream())
					{
						resizedImage.Compress(Bitmap.CompressFormat.Png, 100, ms);
						return resizedImage;
					}
				}
			}

			return imageBitmap;
		}

#endif
	}
}
