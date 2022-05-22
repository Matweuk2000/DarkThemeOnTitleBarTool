using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SetDarkThemeOnWindow
{
    class ClassMain
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        static void Main(string[] args)
        {
            
            IntPtr handle = GetConsoleWindow();

            if (args.Length != 0)
            {
                if(args[0] == "-silent")
                {
                    updateWindow upd = new updateWindow(false);
                    if (DwmSetWindowAttribute(handle, 19, new[] { 1 }, 4) != 0)
                        DwmSetWindowAttribute(handle, 20, new[] { 1 }, 4);
                    upd.Show(); // I have to show a form because i didnt found any other solution to properly update the title bar
                }
            }

            else
            {
                updateWindow upd = new updateWindow(true);
                if (DwmSetWindowAttribute(handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(handle, 20, new[] { 1 }, 4);
                Console.WriteLine("Add -silent as an argument to have no message!\n");
                Console.WriteLine("Applied dark theme on window");
                upd.Show(); // I have to show a form because i didnt found any other solution to properly update the title bar
            }

            
        }
    }
}
