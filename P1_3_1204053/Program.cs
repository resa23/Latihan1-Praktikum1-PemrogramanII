using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204053
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("ANAK AYAM TURUN ");
            int JumlahAyam = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            int i = JumlahAyam;

            if (i > 10)
            {
                Console.Write("Anak ayam maksimal 10 ya !\n");

            }

            else if (i < 1)
            {
                Console.Write("Anak ayam tidak ada yang bernilai negatif ya !\n");
            }
            else
            {
                while (i > 1)
                {
                    Console.WriteLine("Anak ayam turunlah " + i + ", mati satu tinggallah " + (i - 1) + "\n");
                    i--;
                }
                Console.WriteLine("Anak ayam turunlah 1" + ", mati satu tinggallah induknya\n");
                Console.ReadKey();
            }
        }
    }
}

           