using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Data.Models
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options)
            : base(options)
        {
        }

        public DbSet<Training> Training { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<TrainingExercises> TrainingExercises { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
