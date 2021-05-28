using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Abstract
{
    /// <summary>
    /// Sinav entity için Repository arayüzü. IRepository arayüzünden kalıtılır ve Sinav somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISinavDal: IRepository<Sinav>
    {
    }
}