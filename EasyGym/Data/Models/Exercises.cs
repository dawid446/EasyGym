using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Data.Models
{
    public class Exercises
    {
        public int ExercisesID { get; set; }
        public string NameExercises { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<TrainingExercises> TrainingExercises { get; set; }
    }
}
