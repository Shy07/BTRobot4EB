using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace test
{
    class Program
    {
        [DllImport("QR_Encode.dll")]
        static extern int test();

        [DllImport("QR_Encode.dll")]
        static extern int hello();

        static void Main(string[] args)
        {
            //test();
            hello();
        }
    }
}

