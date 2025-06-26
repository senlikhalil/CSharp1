using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış,azalış



            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //Console.WriteLine("Eğitim");
            //}



            //for (int i = 0; i<30; i++)
            //{
            //    Console.WriteLine(i);
            //}




            //for(int i = 0; i<=500; i+=17)
            //{
            //    Console.WriteLine(i);   
            //}



            //Console.Write(" Tekrarlamak istediğiniz sayı: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Denizli");
            //}





            #endregion



            #region For Döngüsü İle Karar Yapıları


            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}





            //int totalValue = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //   totalValue += i; 
            //}

            //Console.WriteLine(totalValue);





            //int totalValue = 0;

            //for (int i = 0; i <= 40; i++)
            //{
            //    if (i % 2 == 0)
            //    { 
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);





            //int count = 0;
            //for (int i = 1; i <= 80; i++)
            //{
            //    if (i % 8 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);





            //int bacterium = 1;

            //for (int i = 1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saaat Sonunda: " + bacterium);
            //}



            #endregion



            #region While Döngüsü



            //While(Şart)
            // {
            //    İşlemler
            // }


            //int i = 1;
            //while (i <= 20)
            //{
            //    Console.WriteLine("HELLO");
            //    i++;         
            //}





            //int i = 1;

            //while (i < 30)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}






            //int i = 1;
            //int sum = 0;

            //while (i <= 50)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum); 





            #endregion



            #region Örnek Sınav Sorusu


            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Örnek--->  456---->  4 + 5 + 6 = 15



            //Console.WriteLine("3 Basamaklı sayı giriniz");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100) / 10;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;


            #endregion





            Console.Read();

        }
    }
}
