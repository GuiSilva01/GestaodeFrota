﻿using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeFrota.Services
{
    public class ApoliceService
    {
        private readonly ApplicationDbContext _context;


        public ApoliceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Apolice> FindAll()
        {
            return _context.Apolice.ToList();
        }

    }
}