using System;

namespace DinamikTestFormu.Entities.Dtos
{
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
