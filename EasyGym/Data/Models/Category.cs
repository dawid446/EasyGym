using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Data.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string NameCategory { get; set; }
        public ICollection<Exercises> Exercises { get; set; }
    }
}
