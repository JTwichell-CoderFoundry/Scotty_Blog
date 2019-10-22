using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace Scotty_Blog.Helpers
{
    public static class ImageUploadValidator
    {
        public static bool IsWebFriendlyImage(HttpPostedFileBase file)
        {
            if (file == null) return false;

            if (file.ContentLength > 2 * 1024 * 1024 || file.ContentLength < 1024)
                return false;

            try
            {
                using (var img = Image.FromStream(file.InputStream))
                {
                    return ImageFormat.Jpeg.Equals(img.RawFormat) || 
                              ImageFormat.Png.Equals(img.RawFormat) ||
                              ImageFormat.Bmp.Equals(img.RawFormat) ||
                              ImageFormat.Tiff.Equals(img.RawFormat) ||
                              ImageFormat.Gif.Equals(img.RawFormat) ;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }
    }
}