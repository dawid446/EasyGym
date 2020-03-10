﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyGym.Data.Models;
using EasyGym.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        public GymController(IUnitOfWork repo)
        {
            _context = repo;
        }
        public int GetAll()
        {
            return _context.Training.Find(s=> s.TrainingID == 1).Count();
            
        }
        
          

    }
}