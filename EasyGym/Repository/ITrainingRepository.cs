using EasyGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Repository
{
    public interface ITrainingRepository : IRepository<Training>
    {
        IEnumerable<Training> GetTopTraining(int count);
    }
}
