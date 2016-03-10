using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            DT(@"C:\Users\Lenovo\pt16");
        }
        static void DT(string path) {
            Stack<string> st = new Stack<string>();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(path + ": " + Directory.GetFiles(path).Length);
            st.Push(path);
            while (st.Count > 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string[] subDir = Directory.GetDirectories(st.Pop());
                foreach (string qs in subDir)
                {
                    Console.WriteLine(qs + ": " + Directory.GetFiles(qs).Length);
                    st.Push(qs);
                    Console.ReadKey();
                }
            }
        }
    }
}
