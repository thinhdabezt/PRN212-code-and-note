using BookManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Repository
{
    public class UserRepository
    {
        private BookManagementDbContext _context;

        public UserAccount GetOne(string email, string password)
        {
            _context = new BookManagementDbContext();
            return _context.UserAccounts.FirstOrDefault(u => u.Email.ToLower() == email.ToLower() && u.Password == password);
        }
    }
}
