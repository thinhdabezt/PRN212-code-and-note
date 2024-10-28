using AirConditionerShop.DAL.Models;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class SupplierService
    {
        private SupplierRepository _repo = new SupplierRepository();

        public List<SupplierCompany> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
