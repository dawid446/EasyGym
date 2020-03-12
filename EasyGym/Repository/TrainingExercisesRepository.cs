using EasyGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EasyGym.Repository
{
    public class TrainingExercisesRepository : Repository<TrainingExercises>, ITrainingExercisesRepository
    {
        public TrainingExercisesRepository(GymContext context)
            : base(context)
        {

        }
        public void AddExercisesToTraning(TrainingExercises trainingExercises)
        {
            throw new NotImplementedException();
        }
        public GymContext GymContext
        {
            get { return Context as GymContext; }
        }

    }
}
