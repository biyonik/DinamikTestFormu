using System.Drawing;
using System.IO;

namespace DinamikTestFormu.Core.Extension
{
    public static class ImageTypeConvert
    {
        public static Image ByteArrayToImage(this byte[] array)
        {
            if (array == null)
            {
                var img = new Bitmap(135, 135, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                using (var g = Graphics.FromImage(img))
                {
                    g.Clear(Color.Transparent);
                    g.DrawString("Görsel Yok", new Font("Tahoma", 12.0f), new SolidBrush(Color.Black), 0, 50);
                }
                return img;
            }
            using (var stream = new MemoryStream(array))
            {
                return Image.FromStream(stream);
            }
        }

        public static byte[] ImageToByteArray(this Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}
