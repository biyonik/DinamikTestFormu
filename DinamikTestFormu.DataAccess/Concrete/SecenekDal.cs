using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    public class SecenekDal: Repository<Secenek>, ISecenekDal
    {
        public SecenekDal(DbContext context) : base(context)
        {
        }
    }
}