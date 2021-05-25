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
        private DtfWorker _worker = new DtfWorker();
        private static int soruSayaci = 0;
        private List<SinavFormSoruDto> SinavSoruListesi;
        public FrmSinavOlustur()
        {
            InitializeComponent();
            _worker.SoruService.Load(null, x => x.Secenekler, x => x.Ders);
            gridControlSoruListesi.DataSource = _worker.SoruService.BindingList();
            SinavSoruListesi = new List<SinavFormSoruDto>();
            soruSayaci = soruSayaci != 0 ? 0 : soruSayaci;
        }

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
                var soruMap = _worker.SoruService.Get(x => x.Id == suankiSoru.Id, x=>x.Secenekler, x=>x.Ders);
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

        private void btnSeciliSoruyuCikar_Click(object sender, EventArgs e)
        {
            if(lstSecilenSorular.SelectedItem != null)
            {
                lstSecilenSorular.Items.Remove(lstSecilenSorular.SelectedItem);
            }
        }

        private void btnTumSorulariCikar_Click(object sender, EventArgs e)
        {
            if(lstSecilenSorular.Items.Count > 0)
            {
                lstSecilenSorular.Items.Clear();
            }
        }
    }
}