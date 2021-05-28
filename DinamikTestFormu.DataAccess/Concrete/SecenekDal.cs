using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    /// <summary>
    /// SecenekDal, Repository sınıfından kalıtılır ve ISecenekDal arayüzü ile kontrat imzalar
    /// SecenekDal, Secenek entity için Repository sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda DbContext sınıfından bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SecenekDal: Repository<Secenek>, ISecenekDal
    {
        public SecenekDal(DbContext context) : base(context)
        {
        }
    }
}