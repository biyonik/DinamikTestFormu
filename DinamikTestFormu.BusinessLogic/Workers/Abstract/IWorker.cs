using System;

namespace DinamikTestFormu.BusinessLogic.Workers.Abstract
{
    /// <summary>
    /// IWorker arayüzü
    /// DataAccess(Veri Erişim) katmanındaki IUnitOfWork arayüzünün BusinessLogic(İş) katmanındaki karşılığıdır
    /// </summary>
    public interface IWorker: IDisposable
    {
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}