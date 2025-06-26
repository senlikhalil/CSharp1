using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Yıldız Sıralama 1


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}



            #endregion



            #region Yıldız Sıralama 2


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion



            #region Yıldız Sıralama3


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("***********");
            //}



            #endregion



            #region Yıldızlarla Dik Üçgen


            //for (int i = 1; i <= 28; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}










            #endregion



            #region Ters Dik Üçgen


            //for (int i = 28; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion



            #region 2 Üçgen Birleşimi

            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 12; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}














            #endregion



            #region Baklava

            //int n = 8;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}








            #endregion



            #region Pirmit

            //int n = 12;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i ; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            #endregion



            #region Ters Piramit

            //int n = 12;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--) 
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion



            Console.Read();





        }
    }
}
