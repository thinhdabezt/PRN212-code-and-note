using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Services
{
    public class Cabinet<T>
    {
        //class Cabinet nếu design chỉ chơi với 1 class khác -> gọi là TIGHT COUPLING
        //tuy nhiên code của chúng tương đồng nhau vậy tại sao lại phải làm nhiều class code tương đồng nhau
        //hãy để class cabinet không chơi với 1 class cụ thể nào, hãy buông các class cụ thể ra, mà nên hứa hẹn là: sẽ chơi đc với đc nhiều class khác nhau -> không gắn kết chặt chẽ thì gọi là LOOSE COUPLING -> giúp cho class linh hoạt, dễ dàng mở rộng, dễ dàng thích ứng với nhiều tình huống
        
        //class Cabinet có thể làm việc với đủ dạng class khác nhau, nếu ta chỉ cần CRUD trên các object của các class khác nhau
        private T[] _arr;
        private int _count;

        public Cabinet(int size)
        {
            if (size < 1)
                throw new ArgumentOutOfRangeException("Invalid size! Size must be at least 1!");
            _arr = new T[size];
        }

        public void Add(T item)
        {
            if(_count == _arr.Length)
            {
                Console.WriteLine("The list is full, no space left to add!");
                return;
            }
            _arr[_count++] = item;
        }

        public void Print()
        {
            if(_count == 0)
            {
                Console.WriteLine("There is no item in the cabinet, please add a new item first");
                return;
            }

            Console.WriteLine($"There is/are {_count} item(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
