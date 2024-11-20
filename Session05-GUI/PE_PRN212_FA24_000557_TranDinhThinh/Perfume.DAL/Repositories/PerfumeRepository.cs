using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfume.DAL.Repositories
{
    public class PerfumeRepository
    {
        private Fall24PerfumeStoreDbContext _context;

        public List<PerfumeInformation> GetAll()
        {
            _context = new Fall24PerfumeStoreDbContext();
            return _context.PerfumeInformations.Include("ProductionCompany").ToList();
        }

        public void Create(PerfumeInformation perfumeInformation)
        {
            _context = new Fall24PerfumeStoreDbContext();
            _context.Add(perfumeInformation);
            _context.SaveChanges();
        }

        public void Update(PerfumeInformation perfumeInformation)
        {
            _context = new Fall24PerfumeStoreDbContext();
            _context.Update(perfumeInformation);
            _context.SaveChanges();
        }

        public void Delete(PerfumeInformation perfumeInformation)
        {
            _context = new Fall24PerfumeStoreDbContext();
            _context.Remove(perfumeInformation);
            _context.SaveChanges();
        }
    }
}
