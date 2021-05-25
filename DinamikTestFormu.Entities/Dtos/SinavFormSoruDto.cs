using DinamikTestFormu.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DinamikTestFormu.Entities.Dtos
{
    public class SinavFormSoruDto
    {
        public Guid Id { get; set; }
        public byte[] Gorsel { get; set; }
        public string Metin { get; set; }
        public Ders Ders{ get; set; }
        public IEnumerable<Secenek> Secenekler { get; set; }
    }
}
