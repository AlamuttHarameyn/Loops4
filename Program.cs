
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._18_Cevrimler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i == 100)//i'yi 100e kadar döndür.
                    break;//döngüyü 100de sonlandırıyor.
                Console.Write("{0,3}", i);
            }
            //forr yazıp iki kere tab tuşuna basınca tam tersi oluyor. yani 100den başlayıp sıfıra gidiyor.
            //{
            //    if (i % 3 == 0)//inin mod üçü 0 kalanlıysa 3 ve 3ün katına eşittir.
            //        continue;//contunie deyimi 1 arttırır.
            //    Console.Write("{0,3}",i);
            //}
            Console.ReadKey();
        }
    }
}
