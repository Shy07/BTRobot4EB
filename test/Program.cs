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
        static extern int test(string str, string dir);
        static string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\QR.bmp";
        
        static void Main(string[] args)
        {
            string str = "http://www.zara.com/qr/0330640380003";
            
            //IntPtr ptrStr = Marshal.AllocHGlobal(str.Length + 1);
            //Marshal.Copy(str.ToCharArray(), 0, ptrStr, str.Length);
            
            //IntPtr ptrDir = Marshal.AllocHGlobal(dir.Length + 1);
            //Marshal.Copy(dir.ToCharArray(), 0, ptrDir, dir.Length);

            test(str, dir);

        }
    }
}

