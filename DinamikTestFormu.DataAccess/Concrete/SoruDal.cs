using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    public class SoruDal: Repository<Soru>, ISoruDal
    {
        public SoruDal(DbContext context) : base(context)
        {
        }
    }
}