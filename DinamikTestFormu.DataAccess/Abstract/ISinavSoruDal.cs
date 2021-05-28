using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Abstract
{
    /// <summary>
    /// SinavSoru entity için Repository arayüzü. IRepository arayüzünden kalıtılır ve SinavSoru somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISinavSoruDal: IRepository<SinavSoru>
    {
    }
}