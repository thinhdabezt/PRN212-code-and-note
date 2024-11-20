using AirConditionerShop.DAL.Models;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class UserService
    {
        private UserRepository _repo = new UserRepository();

        public StaffMember? CheckLogin(string email, string password)
        {
            return _repo.GetOne(email, password);
        }
    }
}
