using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    public class SinavDal: Repository<Sinav>, ISinavDal
    {
        public SinavDal(DbContext context) : base(context)
        {
        }
    }
}