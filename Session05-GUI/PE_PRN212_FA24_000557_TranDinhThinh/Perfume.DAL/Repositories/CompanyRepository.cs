﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfume.DAL.Repositories
{
    public class CompanyRepository
    {
        private Fall24PerfumeStoreDbContext _context;

        public List<ProductionCompany> GetAll()
        {
            _context = new Fall24PerfumeStoreDbContext();
            return _context.ProductionCompanies.ToList();
        }
    }
}
