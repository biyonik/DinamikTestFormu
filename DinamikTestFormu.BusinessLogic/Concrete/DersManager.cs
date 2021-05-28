using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    /// <summary>
    /// DersManager, BaseManager sınıfından kalıtılır ve IDersService arayüzü ile kontrat imzalar
    /// DersManager, Ders entity için BaseManager sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda IUnitOfWork arayüzünden bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class DersManager: BaseManager<Ders>, IDersService
    {
        public DersManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}