using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using System.Net;

namespace RaysHotDogs.Utility
{
    public class ImageHelper
    {
        //use Bitmap to get the data from a url
        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            //since we're getting the data from a webclient, we need to download the url
            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }
            //decode the image to a bitmap that we're returning
            return imageBitmap;
        }
    }
}