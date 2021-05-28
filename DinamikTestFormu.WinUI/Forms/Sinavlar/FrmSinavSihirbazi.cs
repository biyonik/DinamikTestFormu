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
        /// <summary>
        /// IList jenerik tipinde SinavFormSoruDto listesi
        /// statik, o anki soru bilgisini tutan _soruHandler değişkeni
        /// </summary>
        private readonly IList<SinavFormSoruDto> _sinavFormSoruDtos;
        private static SinavFormSoruDto _soruHandler;

        /// <summary>
        /// Yapıcı metot
        /// Parametre olarak List<SinavFormSoruDto> alır ve dependency injection ile _sinavFormSoruDtos a bağlanır
        /// SinavFormuHazirla metodu tetiklenir ve listenin ilk öğesini (First) alır
        /// soruHandler değişkenide listenin ilk öğesini alır
        /// toplam soru sayısı label edit öğesinde listenin öğe sayısı formatlı olarak gösterilir
        /// </summary>
        /// <param name="sinavFormSoruDtos"></param>
        public FrmSinavSihirbazi(List<SinavFormSoruDto> sinavFormSoruDtos)
        {
            InitializeComponent();
            _sinavFormSoruDtos = sinavFormSoruDtos;
            SinavFormuHazirla(_sinavFormSoruDtos.First());
            _soruHandler = _sinavFormSoruDtos.First();
            lblToplamSoruSayisi.Text = $"Toplam Soru Sayısı: {_sinavFormSoruDtos.Count}";
        }

        /// <summary>
        /// Bu metot sinavFormSoruDto listesinin her bir öğesini dinamik olarak ekrana yazdırır
        /// parametre olarak SinavFormSoruDto alır
        /// PictureEdit öğesinini Image özelliği null atanır
        /// Label Edit (Soru Metni) temizlenir
        /// Seçenekleri tutan Group Edit nesnesinin taşıdığı kontroller temizlenir
        /// PictureEdit'in Image özelliği parametre olarak gelen nesnenin Gorsel propertysini byte -> image cast haliyle alır, null ise null değer alır
        /// Soru metni labeli ise parametre olarak gelen nesnenin Metin propertysini alır
        /// locY ile radio group un Y axis değerini belirler, ilk değer 26
        /// parametre olarak gelen nesnenin Seçenekler propertysinin öğe sayısı 0 dan büyük ise 
        /// bir Listeye dönültürülür ve iterasyona girer
        /// İterasyon boyunca bir radiobutton oluşturur
        /// Name property si nesnenin Id değerini alır
        /// Text property si nesnenin Opsiyon değerini alır
        /// Width property si groupbox'ın width değerinin 30 eksiğini alır
        /// Height propertysi 20 değerini alır
        /// Location propertysi X: 5 locY ise iteasyon adımındaki locY yi alır. İlk adımda locY 26 iken, her iterasyon adımında locY ye 26 eklenir
        /// group box'ın kontrollerine secenek butonu eklenir
        /// 
        /// </summary>
        /// <param name="sinavFormSoruDto"></param>
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

        /// <summary>
        /// İlk soru butonununun aksiyonu
        /// SinavFormuHazirla metonuna soru listenin ilk öğesini geçer
        /// soruHandler değişkenine soru listenin ilk öğesini geçer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIlkSoru_Click(object sender, System.EventArgs e)
        {
            SinavFormuHazirla(_sinavFormSoruDtos.First());
            _soruHandler = _sinavFormSoruDtos.First();

        }

        /// <summary>
        /// İlk soru butonununun aksiyonu
        /// SinavFormuHazirla metonuna soru listenin son öğesini geçer
        /// soruHandler değişkenine soru listenin son öğesini geçer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSonSoru_Click(object sender, System.EventArgs e)
        {
            SinavFormuHazirla(_sinavFormSoruDtos.Last());
            _soruHandler = _sinavFormSoruDtos.Last();
        }

        /// <summary>
        /// Eğer şuanki soru, listenin ilk öğesine eşit değilse
        /// sorunun şuanki pozisyonu alınır
        /// oncekiSoru değişkenine listenin mevcut pozisyondaki bir önceki öğesi atanır
        /// oncekiSoru değişkeni SinavFormuHazirla metoduna parametre, soruHandler değişkenine değer olarak atanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Eğer şuanki soru, listenin ilk öğesine eşit değilse
        /// sorunun şuanki pozisyonu alınır
        /// sonrakiSoru değişkenine listenin mevcut pozisyondaki bir sonraki öğesi atanır
        /// sonrakiSoru değişkeni SinavFormuHazirla metoduna parametre, soruHandler değişkenine değer olarak atanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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