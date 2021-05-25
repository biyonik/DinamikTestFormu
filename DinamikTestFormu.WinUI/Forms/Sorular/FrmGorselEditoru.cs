using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    public partial class FrmGorselEditoru : DevExpress.XtraEditors.XtraForm
    {
        public Image AktarilanResim { get; set; }
        public FrmGorselEditoru()
        {
            InitializeComponent();
            lblCropArea.Draggable(true);
            lblCropArea.Parent = pctMain;
            lblCropArea.Visible = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (pctMain.Image == null) return;
            AktarilanResim = KesilenGorsel();
            Close();
        }

        private Image KesilenGorsel()
        {
            Image kesilenGorsel = new Bitmap(YakinlastirilanGorseliAl(pctMain),new Size(pctMain.Width, pctMain.Height));
            Rectangle cerceve = new Rectangle(lblCropArea.Location.X, lblCropArea.Location.Y, lblCropArea.Width, lblCropArea.Height);
            Bitmap bitmap = new Bitmap(cerceve.Width, cerceve.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics grafik = Graphics.FromImage(bitmap);
            grafik.DrawImage(kesilenGorsel, new Rectangle(0, 0, lblCropArea.Width, lblCropArea.Height),lblCropArea.Left, lblCropArea.Top, lblCropArea.Width, lblCropArea.Height, GraphicsUnit.Pixel);
            return bitmap;
        }

        private Image YakinlastirilanGorseliAl(PictureEdit pictureEdit)
        {
            lblCropArea.Visible = false;

            Bitmap bitmap = new Bitmap(pictureEdit.Width, pictureEdit.Height);
            pictureEdit.DrawToBitmap(bitmap, pictureEdit.Bounds);
            return bitmap;
        }

        private void ztbZoomPercent_ValueChanged(object sender, EventArgs e)
        {
            pctMain.Properties.ZoomPercent = ztbZoomPercent.Value;
            spinZoomPercent.Value = ztbZoomPercent.Value;
        }

        private void spinZoomPercent_EditValueChanged(object sender, EventArgs e)
        {
            ztbZoomPercent.Value = Convert.ToInt32(spinZoomPercent.Value);
            pctMain.Properties.ZoomPercent = Convert.ToInt32(spinZoomPercent.Value);
        }

        private void pctMain_ZoomPercentChanged(object sender, EventArgs e)
        {
            ztbZoomPercent.Value = Convert.ToInt32(pctMain.Properties.ZoomPercent);
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            pctMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}