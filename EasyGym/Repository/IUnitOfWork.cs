using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ITrainingRepository Training { get; }
        int Complete();
    }
}
