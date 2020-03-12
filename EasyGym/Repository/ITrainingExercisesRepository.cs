using EasyGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Repository
{
    interface ITrainingExercisesRepository : IRepository<TrainingExercises>
    {
        void AddExercisesToTraning(TrainingExercises trainingExercises);
    }
}
