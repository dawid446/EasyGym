using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Data.Models
{
    public class Training
    {
        [Key]
        public int TrainingID { get; set; }
        public string? NameTraining { get; set; }
        public DateTime Data { get; set; }

        public ICollection<TrainingExercises> TrainingExercises { get; set; }
    }
}
