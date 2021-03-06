using System.Drawing;
using System.IO;

namespace DinamikTestFormu.Core.Extension
{
    /// <summary>
    /// Bir görseli byte dizisine, byte dizisini görsele çeviren "extension method" taşıyıcı sınıf
    /// </summary>
    public static class ImageTypeConvert
    {
        /// <summary>
        /// Byte dizisini görsele çevirir
        /// Eğer metoda gelen dizi parametresi null ise bir transparan görsel oluşturur ve "Görsel Yok" metni yazar
        /// Array değeri boş değilse memorystream nesnesi ile akışı görsele çevirir
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Kendisine verilen görseli byte dizisine çeviren metod
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(this Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}
