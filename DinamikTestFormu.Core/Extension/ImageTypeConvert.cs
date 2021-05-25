using System.Drawing;
using System.IO;

namespace DinamikTestFormu.Core.Extension
{
    public static class ImageTypeConvert
    {
        public static Image ByteArrayToImage(this byte[] array)
        {
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
