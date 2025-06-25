using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else





            //Console.Write("Lütfen Şifreyi Giriniz:");
            //string password;
            //password= Console.ReadLine();

            //if (password == "abcd") 

            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")

            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}

            //else
            //{
            //    Console.WriteLine("Veriler yanlış");
            //}





            //int number;
            //Console.WriteLine("Sayıyı giriniz");
            //number = int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}







            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1 :");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2 :");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3 :");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);


            //if (average > 0 & average <= 50)
            //{
            //    result = ("Kaldı");
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = ("Orta");
            //}
            //if (average > 70 & average <= 85)
            //{
            //    result = ("İyi");
            //}
            //if (average > 85)
            //{
            //    result = ("Çok İyi");
            //}

            //Console.WriteLine(result);








            //string city;
            //Console.WriteLine("Lütfen şehrinizi giriniz");

            //city = Console.ReadLine();


            //if (city == "ankara" | city == "denizli" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}






            //Console.Write("  Kullanıcı adını giriniz ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı bulunamadı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldniz");
            //}



            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;

            //int result =  number % 5;
            //Console.WriteLine(result);






            //Console.WriteLine("Lütfen 1. sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan:" + result);




            #endregion


            #region Char Dğişkenler İle Karar Yapıları




            //char team;

            //Console.WriteLine("Lütfen Takım semolü giriniz");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galtasaray");
            //}




            #endregion


            #region Örnek Proje


            //Console.WriteLine("**** Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-FastFood Ürünleri");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------");

            //string menuItem;
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------ANA YEMEKLER-----------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Patlıcan Musakka");
            //    Console.WriteLine("3_Köfte Patates");
            //    Console.WriteLine("4-Balık");
            //    Console.WriteLine("5-Steak");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar-----------");
            //    Console.WriteLine("1-Şehriye");
            //    Console.WriteLine("2-Tavuk");
            //    Console.WriteLine("3_Un");
            //    Console.WriteLine("4-Mercimek");
            //    Console.WriteLine("5-Domates");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------FastFood-----------");
            //    Console.WriteLine("1-Kızarmış Tavuk Topları");
            //    Console.WriteLine("2-Patates Çubukları");
            //    Console.WriteLine("3_Köfte Topçukları");
            //    Console.WriteLine("4-Pizza Üçgeni");
            //    Console.WriteLine("5-Hamburg Hamburger");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler-----------");
            //    Console.WriteLine("1-Soğukçay");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3_Ayran");
            //    Console.WriteLine("4-Zafer");
            //    Console.WriteLine("5-Fanta");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar-----------");
            //    Console.WriteLine("1-Tavuk Göğüsü");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3_Trileçe");
            //    Console.WriteLine("4-Dondurma");
            //    Console.WriteLine("5-Tartolet");
            //}




            #endregion


            #region Switch Case

            //Console.Write("Bir Ay Giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());


            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default:Console.WriteLine(" Hatalı");
            //        break;
            //}
















            #endregion


            #region Switch Case Hesap Makinesi



            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. Sayıyı giriniz:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak istenen işlemi giriniz");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:" + result);
                
            //        break;


            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark:" + result);
                
            //        break;


            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım:" + result);
                
            //        break;


            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Büölüm:" + result);
                
            //        break;

            //}




            #endregion


            Console.Read();






















        }
    }
}
