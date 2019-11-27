﻿using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class PostoService
    {
        private readonly ApplicationDbContext _context;


        public PostoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Posto> FindAll()
        {
            return _context.Posto.ToList();
        }

    }
}