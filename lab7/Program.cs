using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[ReadInt("a")];
            double[] b = new double[ReadInt("b")];
            double[] c = new double[ReadInt("c")];

            //for a
            for (int i = 0; i < a.Length; i++)
            {
               // a[0] = GetFunc();
            }
           

        }

        private static int ReadInt(string value)
        {
            try
            {
                Console.WriteLine($"Введите {value} - ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка " + ex.Message);
                return ReadInt(value);
            }
        }

        //private static double GetFunc()
        //{

        //}
    }
}
