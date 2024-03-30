using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1.Базовый_уровень_Вариант_19
{
    internal class MyClass
    {
        public int x;
        public int y;

        public MyClass()
        {

        }

        public void Info()
        {
            Console.WriteLine("Объект класса Class");
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public int Perimetr()
        {
            return 2 * (x + y);
        }
    }
}
