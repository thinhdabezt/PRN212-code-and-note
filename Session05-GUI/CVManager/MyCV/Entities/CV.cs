using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCV.Entities
{
    public class CV
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public string Position { get; set; }
        //không làm hàm ToString() lý do:
        //cái grid nó tự trích ra từng column qua hàm get, ta đâu cần ghép chuỗi rồi mất công cắt
        //ToString() hay dùng cho debug, ghi log file để kiểm tra trong lúc run
    }
}
