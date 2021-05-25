using System;

namespace DinamikTestFormu.BusinessLogic.Workers.Abstract
{
    public interface IWorker: IDisposable
    {
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}