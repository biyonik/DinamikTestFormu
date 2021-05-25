using System;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.Entities.Concrete.Base
{
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