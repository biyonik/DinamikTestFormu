using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    /// <summary>
    /// SinavSoruDal, Repository sınıfından kalıtılır ve ISinavSoruDal arayüzü ile kontrat imzalar
    /// SinavSoruDal, SinavSoru entity için Repository sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda DbContext sınıfından bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SinavSoruDal: Repository<SinavSoru>, ISinavSoruDal
    {
        public SinavSoruDal(DbContext context) : base(context)
        {
        }
    }
}