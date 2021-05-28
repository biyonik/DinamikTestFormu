using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Abstract
{
    /// <summary>
    /// Sinav entity için Service arayüzü. IBaseService arayüzünden kalıtılır ve Sinav somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISinavService: IBaseService<Sinav>
    {
        
    }
}