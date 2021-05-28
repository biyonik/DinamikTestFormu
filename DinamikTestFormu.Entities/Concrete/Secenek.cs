using DinamikTestFormu.Entities.Concrete.Base;
using System;

namespace DinamikTestFormu.Entities.Concrete
{
    /// <summary>
    /// Secenek entity, veritabanındaki "Secenekler" tablosunun varlık sınıfıdır.
    /// EntityBase sınıfından kalıtım alır ve IEntity arayüzü ile kontrat imzalar
    /// </summary>
    public class Secenek: EntityBase
    {
        public string Opsiyon { get; set; }

        public Guid SoruId { get; set; }
        public virtual Soru Soru { get; set; }
    }
}