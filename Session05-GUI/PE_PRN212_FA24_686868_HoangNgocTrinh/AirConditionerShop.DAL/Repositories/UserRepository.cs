using AirConditionerShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class UserRepository
    {
        private AirConditionerShop2024DbContext _context;

        //class userrepo dùng để thao tác trên table staffmember
        //không yêu cầu crud trên table này
        //table staffmember là table dính đến login
        //vậy ngoài hàm crud, ta còn làm thêm hàm check login
        //với login = email thì email không quan tâm hoa thường
        //                  pass thì quan tâm hoa thường
        //email và pass là chuỗi, để so sánh chuỗi thì:
        //java: chuỗi là object, cấm so sánh 2 biến object dùng toán tử ==, vì đó là so sánh địa chỉ, tọa độ
        //c#: y chang
        //nhưng c# còn đưa ra kỹ thuật vừa giống, thêm phần khác so với java để tăng tính lợi ích khi so sánh chuỗi
        //ta đc quyền dùng toán tử == để so sánh 2 chuỗi trong c#
        //so sánh dùng == có phân biệt hoa thường
        //hàm login luôn trả về tối đa 1 object tương ứng với account đang login, hoặc trả về null nếu tìm không thấy
        public StaffMember? GetOne(string email, string password)
        {
            _context = new AirConditionerShop2024DbContext();
            return _context.StaffMembers.FirstOrDefault(a => a.EmailAddress.ToLower() == email.ToLower() && a.Password == password);
        }
    }
}
