using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_Вариант_19
{
    internal class Motherboard : Processor
    {
        public string CPU;

        public void Info()
        {
            Console.WriteLine(CPU);
        }
    }
}
