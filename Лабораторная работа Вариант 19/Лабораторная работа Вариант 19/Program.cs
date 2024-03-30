using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_Вариант_19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Processor processor = new Processor();
            try
            {
                Console.WriteLine("mark");
                processor.mark = Console.ReadLine();
                Console.WriteLine("price");
                processor.price = Console.ReadLine();
                Console.WriteLine("cash");
                processor.cash = Console.ReadLine();
                Console.WriteLine("GHz");
                processor.GHz = Console.ReadLine();
            }
            catch(Exception e) { Console.WriteLine(e); }
            Motherboard motherboard = new Motherboard();
            try
            {
                Console.WriteLine("CPU");
                motherboard.CPU = Console.ReadLine();
            }
            catch(Exception e) { Console.WriteLine(e); }
            processor.Info();
            motherboard.Info();
        }
    }
}
