using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Abstract
{
    /// <summary>
    /// Secenek entity için Service arayüzü. IBaseService arayüzünden kalıtılır ve Secenek somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISecenekService: IBaseService<Secenek>
    {
        
    }
}