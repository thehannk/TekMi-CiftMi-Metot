using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftMi_TekMi_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Birinci sayıyı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            
            kontrolEt(sayi1, sayi2);
            Console.ReadLine();

        }

        static void kontrolEt(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Birinci sayı ikinci sayıdan büyüktür.");
            }
            else if (a == b)
            {
                Console.WriteLine("İki sayı da birbirine eşittir.");
            }
            else
            {
                Console.WriteLine("Birinci sayı ikinci sayıdan küçüktür.");
            }
        }

    }
}