using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    /// <summary>
    /// SoruManager, BaseManager sınıfından kalıtılır ve ISoruService arayüzü ile kontrat imzalar
    /// SoruManager, Soru entity için BaseManager sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda IUnitOfWork arayüzünden bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SoruManager: BaseManager<Soru>, ISoruService
    {
        public SoruManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}