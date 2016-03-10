using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream first = new FileStream(@"C:\Users\Lenovo\pt16\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream second = new FileStream(@"C:\Users\Lenovo\pt16\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader re = new StreamReader(first);
            StreamWriter wr = new StreamWriter(second);
            string[] array = re.ReadLine().Split();
            int mn, mx;
            mn = int.Parse(array[0]);
            mx = int.Parse(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                int nums = int.Parse(array[i]);
                if (mn > nums)
                {
                    mn = nums;
                }
                if (mx < nums)
                {
                    mx = nums;
                }
            }
            //Console.WriteLine("MIN = {0}, MAX = {1}", mn, mx); 
            wr.WriteLine("Min = {0}, Max = {1}", mn, mx);

            re.Close();
            wr.Close();
            first.Close();
            second.Close();
            Console.ReadKey();


        }
    }
}
