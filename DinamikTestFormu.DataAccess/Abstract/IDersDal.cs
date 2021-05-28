using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Abstract
{
    /// <summary>
    /// Ders entity için Repository arayüzü. IRepository arayüzünden kalıtılır ve Ders somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface IDersDal: IRepository<Ders>
    {
    }
}