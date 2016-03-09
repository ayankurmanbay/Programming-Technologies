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

            string[] array = first_r.ReadLine().Split();
            int mn = 1000001;
            bool pr;
            for (int i = 0; i< array.Length; i++)
            {
                int a = int.Parse(array[i]);
                pr = true;
                for (int j=2; j<Math.Sqrt(a); j++)
                {
                    if (a % j == 0)
                    {
                        pr = false;
                        break;
                    }
                }
                if (pr = true && mn>a)
                {
                    mn = a;
                }
                second_w.WriteLine("min prime number = {0}" + mn);
                first.Close();
                second.Close();
                first_r.Close();
                second_w.Close();
            }
        }
    }
}
