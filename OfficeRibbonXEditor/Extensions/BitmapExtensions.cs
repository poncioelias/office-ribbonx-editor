﻿using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace OfficeRibbonXEditor.Extensions
{
    public static class BitmapExtensions
    {
        public static BitmapImage AsBitmapImage(this Bitmap bitmap)
        {         
            var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            var image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }
}
