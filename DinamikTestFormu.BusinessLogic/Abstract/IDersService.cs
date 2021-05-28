using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Abstract
{
    /// <summary>
    /// Ders entity için Service arayüzü. IBaseService arayüzünden kalıtılır ve Ders somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface IDersService: IBaseService<Ders>
    {
        
    }
}