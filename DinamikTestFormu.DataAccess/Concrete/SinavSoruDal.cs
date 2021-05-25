using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    public class SinavSoruDal: Repository<SinavSoru>, ISinavSoruDal
    {
        public SinavSoruDal(DbContext context) : base(context)
        {
        }
    }
}