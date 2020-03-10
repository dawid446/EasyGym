using EasyGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Repository
{
    public class TrainingRepository : Repository<Training>, ITrainingRepository
    {
        public TrainingRepository(GymContext context)
            : base(context)
        {

        }

        public IEnumerable<Training> GetTopTraining(int count)
        {
            return GymContext.Training.OrderBy(c => c.Data).Take(10).ToList();
        }
        public GymContext GymContext
        {
            get { return Context as GymContext;  }
        }
    }
}
