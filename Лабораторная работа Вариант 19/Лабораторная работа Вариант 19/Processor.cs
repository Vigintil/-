using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_Вариант_19
{
    internal class Processor
    {
        public string mark;
        public string GHz;
        public string cash;
        public string price;

        public Processor()
        {

        }

        public void Info()
        {
            Console.WriteLine(mark ?? "-");
            Console.WriteLine(GHz ?? "-");
            Console.WriteLine(cash ?? "-");
            Console.WriteLine(price ?? "-");
        }


    }
}
