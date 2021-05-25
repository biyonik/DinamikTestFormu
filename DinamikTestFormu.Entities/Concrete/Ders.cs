using DinamikTestFormu.Entities.Concrete.Base;
using System.Collections.Generic;

namespace DinamikTestFormu.Entities.Concrete
{
    public class Ders: EntityBase
    {
        public string Adi { get; set; }

        public virtual ICollection<Soru> Sorular{ get; set; }
    }
}