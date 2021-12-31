using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 202516044
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final,  bütünleme, ortalama, ortalama2 ;
            Console.Write("Vize notunu giriniz = ");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notunu giriniz = ");
            final = Convert.ToDouble(Console.ReadLine());
            ortalama = (vize * 0.4 + final * 0.6);
            if (final>45 && ortalama > 50)
            {
                Console.WriteLine("Dersi Geçer");
            }
            else
            {
                Console.WriteLine("Bütünlemeye Kalır");

                Console.Write("Bütünleme Notunu Giriniz = ");
                bütünleme = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vize notunu giriniz = ");
                vize = Convert.ToDouble(Console.ReadLine());
                ortalama2 = (vize * 0.4 + bütünleme * 0.6);
                if (final/bütünleme>45 && ortalama2 > 50)
                {
                    Console.WriteLine("Dersi Geçer");
                }
                else
                {
                    Console.WriteLine("Dersten Kalır");
                }

            }




            Console.Read();

        }
    }
}
