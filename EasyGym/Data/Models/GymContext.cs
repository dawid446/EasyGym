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
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    NameCategory = "Chest"
                },
                new Category
                {
                    CategoryID = 2,
                    NameCategory = "Back"
                },
                new Category
                {
                    CategoryID = 3,
                    NameCategory = "Shoulders"
                }
            );
            modelBuilder.Entity<Exercises>().HasData(
                
                new Exercises
                {
                    ExercisesID = 1,
                    NameExercises = "Benchpress",
                    CategoryID = 1

                },
                new Exercises
                {
                    ExercisesID = 2,
                    NameExercises = "Dead Lift",
                    CategoryID = 2

                },
                new Exercises
                {
                    ExercisesID = 3,
                    NameExercises = "Benchpress",
                    CategoryID = 3
                }
            );
        }
    }
}
