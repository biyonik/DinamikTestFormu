using System.Collections.Generic;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.Entities.Concrete
{
    public class Sinav: EntityBase
    {
        public string Adi { get; set; }

        public virtual ICollection<SinavSoru> SinavSorulari{ get; set; }
    }
}