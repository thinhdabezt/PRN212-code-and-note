using AirConditionerShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class SupplierRepository
    {
        private AirConditionerShop2024DbContext _context;

        public List<SupplierCompany> GetAll()
        {
            _context = new AirConditionerShop2024DbContext();
            return _context.SupplierCompanies.ToList();
        }
        //về lý thuyết, 1 table phải làm đủ hàm crud
    }
}
