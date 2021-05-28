using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    public partial class FrmGorselEditoru : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Image tipinde AktarilanResim adında bir property
        /// </summary>
        public Image AktarilanResim { get; set; }
        public FrmGorselEditoru()
        {
            InitializeComponent();
            lblCropArea.Draggable(true);
            lblCropArea.Parent = pctMain;
            lblCropArea.Visible = false;
        }

        /// <summary>
        /// Formu kapatan Kapat butonu aksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Aç butonunun click aksiyonu
        /// Bir dosya görüntüleme yöneticisi açar
        /// bu dosya yöneticisi jpg, png, bmp tipinde dosyaları görüntüler (Filter)
        /// ekrandaki varsayılan dosya tipi jpg olacaktır (FilterIndex)
        /// Eğer açılan pencerede tıklana buton OK ise
        /// Formdaki picturebox'un Image propertysine Image sınıfı FromFile metodu ile seçilen dosyanın isim bilgisi gönderilir
        /// Kırpma alanını tutan label(lblCropArea) ekranda görünür olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAc_Click(object sender, EventArgs e)
        {
            XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog();
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
            openFileDialog.FilterIndex = 0;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pctMain.Image = Image.FromFile(openFileDialog.FileName);
                lblCropArea.Visible = true;
            }
        }

        /// <summary>
        /// Aktar butonunun Click metodu tetiklendiğinde
        /// Eğer PictureEdit nesnesinin Image özelliği null ise metot işlem yapmaz
        /// Değilse, AktarilanResim propertysinin değeri KesilenGorsel metodundan dönen değeri alır
        /// Form kapatılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (pctMain.Image == null) return;
            AktarilanResim = KesilenGorsel();
            Close();
        }

        /// <summary>
        /// Bu metot geriye bir Image tipi döner
        /// kesilenGorsel bir bitmap nesnesidir, parametre olarak YakinlastirilanGorseliAl metodundan dönen bitmap i, boyut olarak ise PictureEdit nesnesinin yükseklik ve genişliğini alır
        /// cerceve ise bir Dikdörtgendir ve Label nesnesinin X-Y eksenlerini, yükseklik ve genişliğini alır
        /// bitmap, yeni bir bitmap dir. cerceve'nin yükseklik ve genişliği boyutlarında ve 32 bit pixel formatındadır
        /// grafik ise FromImage metoduna bitmap'in parametre olarak verilmesiyle yeni bir grafik oluşturur
        /// DrawImage ise kesilenGorsel i alarak, 0-0 konumlarından label nesnesinin yükseklik ve genişlikleri ile bir dikdörtgeni güzergah belirler
        /// Diğer parametreler ile label nesnesinin sol ve üst tarafından konum alır ve Pixel olarak bir grafik çizer
        /// https://docs.microsoft.com/tr-tr/dotnet/api/system.drawing.graphics.drawimage?view=net-5.0#System_Drawing_Graphics_DrawImage_System_Drawing_Image_System_Drawing_Rectangle_System_Int32_System_Int32_System_Int32_System_Int32_System_Drawing_GraphicsUnit_
        /// bitmap i geri döner
        /// </summary>
        /// <returns></returns>
        private Image KesilenGorsel()
        {
            Image kesilenGorsel = new Bitmap(YakinlastirilanGorseliAl(pctMain),new Size(pctMain.Width, pctMain.Height));
            Rectangle cerceve = new Rectangle(lblCropArea.Location.X, lblCropArea.Location.Y, lblCropArea.Width, lblCropArea.Height);
            Bitmap bitmap = new Bitmap(cerceve.Width, cerceve.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics grafik = Graphics.FromImage(bitmap);
            grafik.DrawImage(kesilenGorsel, new Rectangle(0, 0, lblCropArea.Width, lblCropArea.Height),lblCropArea.Left, lblCropArea.Top, lblCropArea.Width, lblCropArea.Height, GraphicsUnit.Pixel);
            return bitmap;
        }

        /// <summary>
        /// Bu metot bir Image tipi döner
        /// Parametre olarak PictureEdit nesnesi alır
        /// Metot yeni bir bitmap oluşturur ki bu bitmap parametre olarak verilen nesnenin yükseklik ve genişliği kadar olacaktır
        /// DrawToBitmap ile spesifik bir bitmap picture edit üzerine render edilir
        /// Parametre olarak yeni oluşturulan bitmapi ve PictureEdit'in sınırlarını alır (Bounds bir dikdörtgendir)
        /// </summary>
        /// <param name="pictureEdit"></param>
        /// <returns></returns>
        private Image YakinlastirilanGorseliAl(PictureEdit pictureEdit)
        {
            lblCropArea.Visible = false;

            Bitmap bitmap = new Bitmap(pictureEdit.Width, pictureEdit.Height);
            pictureEdit.DrawToBitmap(bitmap, pictureEdit.Bounds);
            return bitmap;
        }

        /// <summary>
        /// ZoomTrackBar nesnesinin her değeri değiştiğinde
        /// ZoomTrackBar nesnesinin ZoomPercent değeri aynı nesnenin Value değerine atanır
        /// SpinEdit nesnesinin Value değeri ZoomTrackBar nesnesnin Value değerine atanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ztbZoomPercent_ValueChanged(object sender, EventArgs e)
        {
            pctMain.Properties.ZoomPercent = ztbZoomPercent.Value;
            spinZoomPercent.Value = ztbZoomPercent.Value;
        }

        /// <summary>
        /// SpinEdit nesnesinin her değeri değiştiğinde
        /// ZoomTrackBar nesnesnin value değerine SpinEdit nesnesinin değeri
        /// PictureEdit nesnesinin ZoomPercent değerine SpinEdit nesnesinin Value değeri atanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spinZoomPercent_EditValueChanged(object sender, EventArgs e)
        {
            ztbZoomPercent.Value = Convert.ToInt32(spinZoomPercent.Value);
            pctMain.Properties.ZoomPercent = Convert.ToInt32(spinZoomPercent.Value);
        }

        /// <summary>
        /// PictureEdit nesnesinin ZoomPercent değeri değiştiğinde
        /// ZoomTrackBar nesnesinin Value değerine PictureEdit nesnesinin ZoomPercent değeri atanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctMain_ZoomPercentChanged(object sender, EventArgs e)
        {
            ztbZoomPercent.Value = Convert.ToInt32(pctMain.Properties.ZoomPercent);
        }

        /// <summary>
        /// Çevir butonuna tıklandığında
        /// PictureEdit nesnesinin Image propertysinini Rotate metodu tetiklenir ve görsel 90 derece saat yönünde dönderilir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCevir_Click(object sender, EventArgs e)
        {
            pctMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}