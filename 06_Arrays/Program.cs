using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]


            //string[] colors = new string[10];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Yeşil";
            //colors[4] = "Pembe";
            //colors[5] = "Kahverengi";
            //colors[6] = "Siyah";
            //colors[7] = "Mor";
            //colors[8] = "Lacivert";
            //colors[9] = "Beyaz";
            //Console.WriteLine(colors[5]);




            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 212;
            //numbers[5] = 423;
            //numbers[8] = 63;
            //numbers[9] = 132;
            //Console.WriteLine(numbers[4]);




            //string[] cities = { "İstanbul", "Denilzi", "Bursa", "Antalya", "Muş" };
            //Console.WriteLine(cities[4]);





            #endregion



            #region Dizideki Tüm Elemanları Listeleme

            //String[] colors = { "Sarı", "Mavi", "Kırmızı", "Yeşil", "Mor", "Beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}






            //int[] numbers = { 8, 36, 98, 165, 486, 789, 989, 1289, 1580, 1783, 1920 };

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}






            //char[] symbols = { 'a', 'b', '/', '?', '*' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}





            //int[] myArray = { 386, 981, 35, 87, 945, 278, 21, 989, 900 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);





            //String[] persons = { "Messi", "Ronaldo", "Pele", "Maradona", "Mbappe" };
            //Console.WriteLine(persons.Length);





            //int [] numbers = { 38, 65, 87, 26, 41, 83, 38, 57, 91, 48, 93, 28, 86, };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}





            //int[] numbers = { 38, 65, 87, 26, 41, 83, 38, 57, 91, 48, 93, 28, 86, };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion



            #region Dizi Metotları



            //String[] persons = { "Ali", "Buse", "Çınar", "Kaya", "Ada", "Selim" };
            //int index = Array.IndexOf(persons, "Ada");
            //Console.WriteLine(index);




            //int[] numbers = { 24, 67, 64, 98, 68, 93, 51, 68, 80, 72, 37 };
            //Console.WriteLine(" Dizinin En Büyük Elemanı:" + numbers.Max() + " " + " Dizinin En Küçük Elemanı:" + numbers.Min());








            #endregion



            #region Kullanıcıda Değer Alma


            //string[] cities = new string[7];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}








            //int[] numbers = { 10, 260, 30, 400, 5060, 70, 80, 730, 90, 100, 390 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum); 








            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-----------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion







            Console.Read();


        }
    }
}
