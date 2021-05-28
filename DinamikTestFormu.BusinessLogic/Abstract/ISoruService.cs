using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Abstract
{
    /// <summary>
    /// Soru entity için Service arayüzü. IBaseService arayüzünden kalıtılır ve Soru somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISoruService: IBaseService<Soru>
    {
        
    }
}