using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Abstract
{
    /// <summary>
    /// SinavSoru entity için Service arayüzü. IBaseService arayüzünden kalıtılır ve SinavSoru somut sınıfı jenerik olarak bu arayüze parametre geçilir
    /// </summary>
    public interface ISinavSoruService: IBaseService<SinavSoru>
    {
        
    }
}