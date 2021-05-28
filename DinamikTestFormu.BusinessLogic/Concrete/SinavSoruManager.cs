using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    /// <summary>
    /// SinavSoruManager, BaseManager sınıfından kalıtılır ve ISinavSoruService arayüzü ile kontrat imzalar
    /// SinavSoruManager, SinavSoru entity için BaseManager sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda IUnitOfWork arayüzünden bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SinavSoruManager: BaseManager<SinavSoru>, ISinavSoruService
    {
        public SinavSoruManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}