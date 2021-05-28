using System.Data.Entity;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Concrete
{
    /// <summary>
    /// DersDal, Repository sınıfından kalıtılır ve IDersDal arayüzü ile kontrat imzalar
    /// DersDal, Ders entity için Repository sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda DbContext sınıfından bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class DersDal: Repository<Ders>, IDersDal
    {
        public DersDal(DbContext context) : base(context)
        {
        }
    }
}