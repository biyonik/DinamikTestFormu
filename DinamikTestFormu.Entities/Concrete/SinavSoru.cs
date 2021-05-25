using System;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.Entities.Concrete
{
    public class SinavSoru: EntityBase
    {
        public Guid SinavId { get; set; }
        public virtual Sinav Sinav { get; set; }
        
        public Guid SoruId { get; set; }
        public virtual Soru Soru { get; set; }
    }
}