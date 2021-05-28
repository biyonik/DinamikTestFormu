using System.Collections.Generic;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.Entities.Concrete
{
    /// <summary>
    /// Sinav entity, veritabanındaki "Sinavlar" tablosunun varlık sınıfıdır.
    /// EntityBase sınıfından kalıtım alır ve IEntity arayüzü ile kontrat imzalar
    /// </summary>
    public class Sinav: EntityBase
    {
        public string Adi { get; set; }

        public virtual ICollection<SinavSoru> SinavSorulari{ get; set; }
    }
}