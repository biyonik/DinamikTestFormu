using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    /// <summary>
    /// SoruDal, Repository sınıfından kalıtılır ve ISoruDal arayüzü ile kontrat imzalar
    /// SoruDal, Soru entity için Repository sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda DbContext sınıfından bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SoruDal: Repository<Soru>, ISoruDal
    {
        public SoruDal(DbContext context) : base(context)
        {
        }
    }
}