using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1232
{
    static internal class Class1
    {
        static public int a;
        static public int b;
        static public int c;

        public static int[] Calc()
        {
            int[] abc = new int[3];
            abc[0] = a;
            abc[1] = b;
            abc[2] = c;
            int buf;
            if (abc[0] > abc[1] ) 
            {
                buf = abc[0];
                abc[0] = abc[1];
                abc[1] = buf;
            }
            if (abc[0] > abc[2])
            {
                buf = abc[0];
                abc[0] = abc[2];
                abc[2] = buf;
            }
            if (abc[1] > abc[2])
            {
                buf = abc[1];
                abc[1] = abc[2];
                abc[2] = buf;
            }
            return abc;
        }
    }
}
