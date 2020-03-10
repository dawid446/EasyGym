using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Data.Models
{
    public class TrainingExercises
    {
        [Key]
        public int TrainingExercisesID { get; set; }
        public int Set { get; set; }
        public int Repeats { get; set; }
        public int Weight { get; set; }
        public DateTime Rest { get; set;  }
        [ForeignKey("Exercises")]
        public int ExercisesID { get; set; }
        [ForeignKey("Training")]
        public int TrainingID { get; set; }
        public Training Training { get; set; }
        public Exercises Exercises { get; set; }
    }
}
