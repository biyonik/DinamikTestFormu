using DevExpress.XtraEditors;
using DinamikTestFormu.Core.Extension;
using DinamikTestFormu.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sinavlar
{
    public partial class FrmSinavSihirbazi : XtraForm
    {
        private readonly IList<SinavFormSoruDto> _sinavFormSoruDtos;
        private static SinavFormSoruDto _soruHandler;
        public FrmSinavSihirbazi(List<SinavFormSoruDto> sinavFormSoruDtos)
        {
            InitializeComponent();
            _sinavFormSoruDtos = sinavFormSoruDtos;
            SinavFormuHazirla(_sinavFormSoruDtos.First());
            _soruHandler = _sinavFormSoruDtos.First();
            lblToplamSoruSayisi.Text = $"Toplam Soru Sayısı: {_sinavFormSoruDtos.Count}";
        }

        void SinavFormuHazirla(SinavFormSoruDto sinavFormSoruDto)
        {
            pctSoruGorseli.Image = null;
            lblSoruMetni.ResetText();
            groupSoruSecenekleri.Controls.Clear();


            pctSoruGorseli.Image = sinavFormSoruDto.Gorsel.ByteArrayToImage() ?? null;
            lblSoruMetni.Text = sinavFormSoruDto.Metin;
            int locY = 26;
            
            if (sinavFormSoruDto.Secenekler.Count() > 0)
            {
                sinavFormSoruDto.Secenekler.ToList().ForEach(secenek =>
                {
                    RadioButton secenekButton = new RadioButton();
                    secenekButton.Location = new System.Drawing.Point(5, locY);
                    secenekButton.Name = secenek.Id.ToString();
                    secenekButton.Text = secenek.Opsiyon;
                    secenekButton.Width = groupSoruSecenekleri.Width - 30;
                    secenekButton.Height = 20;
                    secenekButton.Location = new System.Drawing.Point(5, locY);
                    locY += 26;
                    groupSoruSecenekleri.Controls.Add(secenekButton);
                });
                
            }
        }

        private void btnIlkSoru_Click(object sender, System.EventArgs e)
        {
            SinavFormuHazirla(_sinavFormSoruDtos.First());
            _soruHandler = _sinavFormSoruDtos.First();

        }

        private void btnSonSoru_Click(object sender, System.EventArgs e)
        {
            SinavFormuHazirla(_sinavFormSoruDtos.Last());
            _soruHandler = _sinavFormSoruDtos.Last();
        }

        private void btnOncekiSoru_Click(object sender, System.EventArgs e)
        {
            if(_soruHandler != _sinavFormSoruDtos.First())
            {
                var curPos = _sinavFormSoruDtos.IndexOf(_soruHandler);
                var oncekiSoru = _sinavFormSoruDtos[--curPos];
                SinavFormuHazirla(oncekiSoru);
                _soruHandler = oncekiSoru;
            }
        }

        private void btnSonrakiSoru_Click(object sender, System.EventArgs e)
        {
            if (_soruHandler != _sinavFormSoruDtos.Last())
            {
                var curPos = _sinavFormSoruDtos.IndexOf(_soruHandler);
                var sonrakiSoru = _sinavFormSoruDtos[++curPos];
                SinavFormuHazirla(sonrakiSoru);
                _soruHandler = sonrakiSoru;
            }
        }
    }
}