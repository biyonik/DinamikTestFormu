using DevExpress.XtraEditors;
using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using DinamikTestFormu.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sinavlar
{
    public partial class FrmSinavOlustur : XtraForm
    {
        /// <summary>
        /// DtfWorker nesnesinden _worker adında bir örnek
        /// statik, int tipinde soruSayaci değişkeni
        /// List jenerik tipinde SinavSoruListesi değişkeni
        /// </summary>
        private DtfWorker _worker = new DtfWorker();
        private static int soruSayaci = 0;
        private List<SinavFormSoruDto> SinavSoruListesi;

        /// <summary>
        /// Yapıcı metot
        /// SoruService servisinden sorular Load ile yüklenir. Sorular yüklenirken Secenekler ve Ders bilgisi de alınıyor
        /// SoruListesi gridinin veri kaynağı SoruService servisinin BindingList metodundan gelen veriler ile dolduruluyor
        /// SinavSoruListesi listesinin bir örneği alınıyor
        /// soruSayaci değişkeninin değeri 0 değilse 0 a atanıyor değilse soruSayaci değeri atanıyor
        /// </summary>
        public FrmSinavOlustur()
        {
            InitializeComponent();
            _worker.SoruService.Load(null, x => x.Secenekler, x => x.Ders);
            gridControlSoruListesi.DataSource = _worker.SoruService.BindingList();
            SinavSoruListesi = new List<SinavFormSoruDto>();
            soruSayaci = soruSayaci != 0 ? 0 : soruSayaci;
        }

        /// <summary>
        /// Listeye Aktar butonu (>)
        /// Eğer seçili/odaklanılan satır hiç soru yok ise ekrana uyarı mesajı verir
        /// Seçili seçili/odaklanılan satır var ise bu satır Soru tipine cast edilir ve seciliSoruEntity e atanır
        /// soruListedeVarMi değişkeni ListBox üzerindeki tüm öğeler üzerinde itere edilir ve Any metodunda geçen LINQ expression ile Id değerine göre eşleşen değerin olup olmadığına bakar
        /// Eğer soru listede var ise aynı soru listeye eklenmeyecektir
        /// Listede yok ise soruSayaci bir artırılır
        /// SecilenSoruDto sınıfından bir örnek alınır ve propertyleri grid üzerindeki seçili sorunun değerleri ile manuel map edilir
        /// Bu dto nesnesi listeye eklenir
        /// Listenin  valuemember propertysi dto nun Id değerini alır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListeyeAktar_Click(object sender, EventArgs e)
        {
            if(winExplorerViewSorular.GetFocusedRow() == null)
            {
                MessageBox.Show("Lütfen bir soru seçiniz", "Uyarı");
                return;
            }
            
            var secilenSoruEntity = winExplorerViewSorular.GetFocusedRow() as Soru;
            bool soruListedeVarMi = lstSecilenSorular.Items.Cast<SecilenSoruDto>().Any(soru => soru.Id == secilenSoruEntity.Id);
            if(soruListedeVarMi)
            {
                MessageBox.Show("Seçilen soru zaten listede var!", "Uyarı");
                return;
            }
            ++soruSayaci;
            SecilenSoruDto secilenSoru = new SecilenSoruDto
            {
                Id = secilenSoruEntity.Id,
                DersAdi = secilenSoruEntity.Ders.Adi,
                SoruSayaci = soruSayaci
            };
            lstSecilenSorular.Items.Add(secilenSoru);
            lstSecilenSorular.ValueMember = secilenSoru.Id.ToString();
        }

        /// <summary>
        /// Eğer listede hiç öğe yok ise (soru listeye eklenmemiş ise ) uyarı verir
        /// Değilse SinavFormSoruDto listesi örneği oluşturur
        /// enumerator ile listedeki öğeler iterasyona tabi tutulur
        /// Döngü boyunca enumerator bir öğe ilerler
        /// Bu her bir öğe SecilenSoruDto ya cast edilir
        /// soruMap değişkeni ise SoruService servisinin Get metodu ile o anki sorunun Id ile gelen bilgisini ve Ders bilgisini alır
        /// secenekler değişkeni ise SecenekService servisinin Get metodu ile  soru nun Id değerine göre filtreleme yaparak sorunun seçeneklerini alır
        /// sinavFormuSorulari listesine iterasyon boyunca SinavFormSoruDto tipinde nesne eklenir ve propertyleri seçilen soru (soruMap) ile eşleştirilir
        /// SinavSoruListesi, sinavFormSorulari listesinin değerini alır
        /// FrmSinavSihirbazi tipinde bir nesne oluşturulur ve SinavSoruListesini parametre olarak alır
        /// FrmSinavSihirbazi ekranda dialog olarak gösterilir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormOlustur_Click(object sender, EventArgs e)
        {
            if(lstSecilenSorular.Items.Count <= 0)
            {
                MessageBox.Show("Sınav formu oluşturmak için lütfen listeye soru ekleyiniz", "Uyarı");
                return;
            }
            List<SinavFormSoruDto> sinavFormuSorulari = new List<SinavFormSoruDto>();  
            var enumerator = lstSecilenSorular.Items.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var suankiSoru = enumerator.Current as SecilenSoruDto;
                var soruMap = _worker.SoruService.Get(x => x.Id == suankiSoru.Id, x=>x.Ders);
                var secenekler = _worker.SecenekService.GetList(x => x.SoruId == soruMap.Id);
                sinavFormuSorulari.Add(new SinavFormSoruDto
                {
                    Id = soruMap.Id,
                    Ders = soruMap.Ders,
                    Gorsel = soruMap.Gorsel,
                    Metin = soruMap.Metin,
                    Secenekler = secenekler
                });
            }
            SinavSoruListesi = sinavFormuSorulari;
            FrmSinavSihirbazi frmSinavSihirbazi = new FrmSinavSihirbazi(SinavSoruListesi);
            frmSinavSihirbazi.ShowDialog();
        }

        /// <summary>
        /// Seçili soruyu çıkar butonu aksiyonu (<)
        /// eğer listede bir öğe seçili ise bu öğeyi listeden çıkarır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeciliSoruyuCikar_Click(object sender, EventArgs e)
        {
            if(lstSecilenSorular.SelectedItem != null)
            {
                lstSecilenSorular.Items.Remove(lstSecilenSorular.SelectedItem);
            }
        }

        /// <summary>
        /// Tüm soruları çıkar buton aksiyonu (<<)
        /// listedeki öğe sayısı 0 dan büyükse tüm liste öğeleri temizlenir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTumSorulariCikar_Click(object sender, EventArgs e)
        {
            if(lstSecilenSorular.Items.Count > 0)
            {
                lstSecilenSorular.Items.Clear();
            }
        }
        /// <summary>
        /// Tümünü Listeye Aktar buton aksiyonu (>>)
        /// rowCount, grid üzerindeki satır sayısını alır
        /// Eğer satır sayısı 0 dan büyükse
        /// while ile satır sayısı miktarınca iterasyon yapılır
        /// iterasyon boyunca soruSayaci bir artırılır
        /// Satır seçilir
        /// Seçilen satır Soru tipine cast edilir
        /// seçili sorunun listede olup, olmadığına bakılır
        /// Eğer soru listede yoksa SecilenSoruDto nesnesinden örnek alınır ve propertyleri o sırada seçilen soru ile eşleştirilir (manuel map)
        /// secilenSoruDto örneği listeye eklenir
        /// listenin valueMember öğesine secilenSoruDto nesnesinin Id değeri atanır
        /// sayac bir artırılır
        /// eğer sayac, satırsayısına eşit ise döngü kırılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTumunuAktar_Click(object sender, EventArgs e)
        {
            var rowCount = winExplorerViewSorular.DataRowCount;
            if(rowCount > 0)
            {
                int i = 0;
                while(rowCount > 0)
                {
                    ++soruSayaci;
                    winExplorerViewSorular.SelectRow(i);
                    var focusedRow = winExplorerViewSorular.GetRow(i) as Soru;
                    bool soruListedeVarMi = lstSecilenSorular.Items.Cast<SecilenSoruDto>().Any(soru => soru.Id == focusedRow.Id);
                    if (soruListedeVarMi) break;
                    SecilenSoruDto secilenSoru = new SecilenSoruDto
                    {
                        Id = focusedRow.Id,
                        DersAdi = focusedRow.Ders.Adi,
                        SoruSayaci = soruSayaci
                    };
                    lstSecilenSorular.Items.Add(secilenSoru);
                    lstSecilenSorular.ValueMember = secilenSoru.Id.ToString();
                    ++i;
                    if (i == rowCount) break;
                }
            }
        }
    }
}