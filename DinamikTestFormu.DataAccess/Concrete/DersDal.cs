using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    public class DersDal: Repository<Ders>, IDersDal
    {
        public DersDal(DbContext context) : base(context)
        {
        }
    }
}