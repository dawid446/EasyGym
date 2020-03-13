using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Dtos
{
    public class NewTrainingDTO
    {
        public String NameOfTraining { get; set; }
        public DateTime DateOfTraining { get; set; }
        public int[] IdOfExercises { get; set; }
    }
}
