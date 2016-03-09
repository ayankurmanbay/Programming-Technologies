using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace min_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream first = new FileStream(@"C:\Users\Lenovo\pt16\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream second = new FileStream(@"C:\Users\Lenovo\pt16\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader first_r = new StreamReader(first);
            StreamWriter second_w = new StreamWriter(second);

            string[] s = first_r.ReadLine().Split();
            int mn = 10000001;
            bool pr;
            for (int i = 0; i < s.Length; i++)
            {
                int a = int.Parse(s[i]);
                pr = true;

                for (int j = 2; j < Math.Sqrt(a); j++)
                {
                    if (a % j == 0)
                    {
                        pr = false;
                        break;
                    }
                }
                if (pr == true && mn > a && a!=1)
                    mn = a;
            }
            second_w.WriteLine("min prime number = {0}", mn);
            first_r.Close();
            second_w.Close();
            first.Close();
            second.Close();
            Console.ReadKey();
        }
    }
}
