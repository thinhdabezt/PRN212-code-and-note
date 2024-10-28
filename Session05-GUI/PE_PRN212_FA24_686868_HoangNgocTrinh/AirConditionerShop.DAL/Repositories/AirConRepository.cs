using AirConditionerShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConRepository
    {
        //logic/flow:
        //GUI(WPF) --- BLL (SERVICE)
        //                 --- DAL (REPO)
        //                         --- DbContext --- Table thật

        //Thằng repo là thằng giao tiếp trực tiếp với db
        //nên nó cần gọi dbcontext - giao tiếp với csdl do nó chứa chuối kết nối đến server

        private AirConditionerShop2024DbContext _context; //không new, lúc nào xài mới new
        //_context đại diện cho database, nó quản lý 3 table
        //giờ ta sẽ crud trên airconditioner nhờ _context xuống database
        public List<AirConditioner> GetAll()
        {
            _context =  new AirConditionerShop2024DbContext();
            //_context = new(); như nhau
            return _context.AirConditioners.ToList();
            //     trả về dbset            .ToList() để convert thành list
            //đã select * from
        }
        //hàm create(), update(), delete() đều nhận vào 1 object aircon
        public void Delete(AirConditioner obj) //object muốn xóa
        {
            _context.AirConditioners.Remove(obj); //xóa trong ram, build câu delete from
            _context.SaveChanges();
        }

        public void Update(AirConditioner obj) //object muốn update
        {
            _context.AirConditioners.Update(obj); //cập nhật trong ram, build câu update from
            _context.SaveChanges();
        }

        public void Create(AirConditioner obj) //object muốn create
        {
            _context.AirConditioners.Add(obj); //cập nhật trong ram, build câu insert into
            _context.SaveChanges();
        }
    }
}
