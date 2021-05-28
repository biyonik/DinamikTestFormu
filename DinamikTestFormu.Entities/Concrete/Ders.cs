using DinamikTestFormu.Entities.Concrete.Base;
using System.Collections.Generic;

namespace DinamikTestFormu.Entities.Concrete
{
    /// <summary>
    /// Ders entity, veritabanındaki "Dersler" tablosunun varlık sınıfıdır.
    /// EntityBase sınıfından kalıtım alır ve IEntity arayüzü ile kontrat imzalar
    /// </summary>
    public class Ders: EntityBase
    {
        public string Adi { get; set; }

        public virtual ICollection<Soru> Sorular{ get; set; }
    }
}