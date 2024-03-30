using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Средний_уровень_Вариант_19
{
    internal class MyClass : MyVector
    {
        string name;
        public MyClass() 
        {
            
        }

        MyClass(string name)
        {
            this.name = name;
        }
        ~MyClass()
        {
            Console.WriteLine("Объект удалён");
        }

        public int S()
        {
            int y = y2 - y1;
            int x = x2 - x1;
            return y*x;
        }
        public int[] V2()
        {
            y2 *= 2;
            x2 *= 2;
            return new int[] { y2, x2 };
        }
        
    }
}
