using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    /// <summary>
    /// SinavDal, Repository sınıfından kalıtılır ve ISinavDal arayüzü ile kontrat imzalar
    /// SinavDal, Sinav entity için Repository sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda DbContext sınıfından bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SinavDal: Repository<Sinav>, ISinavDal
    {
        public SinavDal(DbContext context) : base(context)
        {
        }
    }
}