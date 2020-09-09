using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeats.Legacy.ImageExtensions.UnitTest.Resources;

namespace Zeats.Legacy.ImageExtensions.UnitTest
{
    [TestClass]
    public class ToBitmapImageExtensionTest
    {
        [TestMethod]
        public void ToBitmapImage()
        {
            using (var bitmap = Images.img_01)
            using (var memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Jpeg);

                var image = Image.FromStream(memoryStream);
                var bitmapImage = image.ToBitmapImage();

                Assert.IsNotNull(bitmapImage);
            }
        }
    }
}