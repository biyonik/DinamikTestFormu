using DinamikTestFormu.Entities.Concrete.Base;
using System;

namespace DinamikTestFormu.Entities.Concrete
{
    public class Secenek: EntityBase
    {
        public string Opsiyon { get; set; }

        public Guid SoruId { get; set; }
        public virtual Soru Soru { get; set; }
    }
}