using BookManagement.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DLL.Repositories
{
    public class UserRepository
    {
        private BookManagementDbContext _context;

        public UserAccount GetOne(string email, string password)
        {
            _context = new BookManagementDbContext();
            return _context.UserAccounts.FirstOrDefault(a => a.Email.ToLower() == email.ToLower() && a.Password == password);
        }
    }
}
