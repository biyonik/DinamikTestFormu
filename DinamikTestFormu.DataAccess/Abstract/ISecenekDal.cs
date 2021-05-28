using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.DataAccess.Abstract
{
    /// <summary>
    /// Secenek entity için Repository arayüzü. IRepository arayüzünden kalıtılır ve Secenek somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISecenekDal: IRepository<Secenek>
    {
    }
}