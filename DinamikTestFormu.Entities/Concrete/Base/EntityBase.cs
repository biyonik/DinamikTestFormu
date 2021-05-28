using System;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.Entities.Concrete.Base
{
    /// <summary>
    /// EntityBase sınıfı kendisinden miras alan sınıflar için aşağıdaki propertyleri miras verir
    /// </summary>
    public class EntityBase: IEntity
    {
        public Guid Id { get; set; }
        public string Ekleyen { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public string Duzenleyen { get; set; }
        public DateTime DuzenlenmeTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}