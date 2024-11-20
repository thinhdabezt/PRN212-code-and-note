using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfume.DAL.Repositories
{
    public class AccountRepository
    {
        private Fall24PerfumeStoreDbContext _context;

        public Psaccount? Check(string email, string password)
        {
            _context = new Fall24PerfumeStoreDbContext();
            return _context.Psaccounts.FirstOrDefault(a => a.EmailAddress.ToLower() == email.ToLower() && a.Password == password);
        }
    }
}
