using EasyGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyGym.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GymContext _context;
        public ITrainingRepository Training { get; private set; }
        public UnitOfWork(GymContext context)
        {
            _context = context;
            Training = new TrainingRepository(_context);
        }
       

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
