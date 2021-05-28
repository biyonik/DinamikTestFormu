using DinamikTestFormu.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DinamikTestFormu.Entities.Dtos
{
    /// <summary>
    /// DataTransformationObjects katman üyesi
    /// SinavFormSoru ile ilgili bilgileri taşıyan sınıf
    /// Single Responsibility yaklaşımı gereğince "Soru" entity sınıfının tek bir görevi vardır ilkesi gereği tanımlanmış ve kullanılmıştır
    /// </summary>
    public class SinavFormSoruDto
    {
        public Guid Id { get; set; }
        public byte[] Gorsel { get; set; }
        public string Metin { get; set; }
        public Ders Ders{ get; set; }
        public IEnumerable<Secenek> Secenekler { get; set; }
    }
}
