using System;

namespace DinamikTestFormu.Entities.Dtos
{
    /// <summary>
    /// DataTransformationObjects katman üyesi
    /// SecilenSoru ile ilgili bilgileri taşıyan sınıf
    /// Single Responsibility yaklaşımı gereğince "Soru" entity sınıfının tek bir görevi vardır ilkesi gereği tanımlanmış ve kullanılmıştır
    /// </summary>
    public class SecilenSoruDto
    {
        public Guid Id { get; set; }
        public string  DersAdi { get; set; }
        public int SoruSayaci { get; set; }

        public override string ToString()
        {
            return $"{SoruSayaci}. Soru - {DersAdi} | Id={Id}";
        }
    }
}
