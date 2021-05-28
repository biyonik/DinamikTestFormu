using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Abstract
{
    /// <summary>
    /// Soru entity için Repository arayüzü. IRepository arayüzünden kalıtılır ve Soru somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISoruDal: IRepository<Soru>
    {
    }
}