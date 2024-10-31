using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region if
        //Console.WriteLine("Lütfen gecerli Sifreyi Giriniz");
        //string password;
        //password = Console.ReadLine();
        //if (password == "abcd")
        //{
        //    Console.WriteLine("Sifre Dogru ");
        //}
        //else
        //{
        //    Console.WriteLine("Sifre Yanlış");
        //}
        //Console.Read();
        //string capital, country;
        //Console.WriteLine("Başkenti Giriniz...");
        //capital = Console.ReadLine();
        //Console.WriteLine("Ülkeyi Giriniz");
        //country = Console.ReadLine();

        //if (capital =="ankara"& country=="türkiye")
        //{
        //    Console.WriteLine("Veriler Doğrulandı");
        //}
        //else
        //{
        //    Console.WriteLine("hatalı bilgi");
        //}
        /*
                    int number;
                    Console.WriteLine("Bir sayi giriniz");
                    number = int.Parse(Console.ReadLine());

                    if(number == 5)
                    {
                        Console.WriteLine("Sayi Dogru");
                    }
                    else
                    {
                        Console.WriteLine("Sayi hatalı"); 
                    }*/

        //int exam1, exam2, exam3, average;
        //string result = "hata";

        //Console.WriteLine("Sınav1: ");
        //exam1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Sınav2 ");
        //exam2 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Sınav3 ");
        //exam3 = int.Parse(Console.ReadLine());

        //average = (exam1 + exam2 + exam3) / 3;

        //Console.WriteLine("Sınavların ortalaması :" + average);

        //if (average > 0 && average <= 50)
        //{
        //    result = "Sonuç vasat";

        //}
        //if (average > 50 && average <= 70)
        //{
        //    result = "Sonuç orta";
        //}
        //if (average > 70 && average <= 84)
        //{
        //    result = "Sonuç iyi";
        //}
        //if (average > 84)
        //{
        //    result = "Sonuç Çok iyi";
        //}
        //Console.WriteLine(result);

        //string city;
        //Console.WriteLine("Lütfen Sehir Girişi Yapiniz");
        //city = Console.ReadLine();

        //if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
        //{
        //    Console.WriteLine("Şehir Mevcut");
        //}
        //else
        //{
        //    Console.WriteLine("Şehir Mevcut Degil");
        //}

        //Console.WriteLine("Lütffen kullanıcıadını giriniz");
        //string username = Console.ReadLine();

        //if (username != "admin")
        //{
        //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez");
        //}
        //else
        //{
        //    Console.WriteLine("Welcome");
        //}
        #endregion

        #region mod İşlemleri

        //int number = 26;

        //int result = number % 5;
        //Console.WriteLine(result);

        //Console.WriteLine("Birinci sayiyi giriniz");
        //int number1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("İkinci sayiyi giriniz");
        //int number2 = int.Parse(Console.ReadLine());

        //int result = number1%number2;
        //Console.WriteLine("Birinci sayiyinin ikinci sayiya bölümünden kalan:"+result);

        //Console.WriteLine("Lütfen sayiyi giriniz:");
        //int number = int.Parse(Console.ReadLine());

        //if (number % 2 == 0)
        //{
        //    Console.WriteLine("Bu sayi çift sayidir");
        //}
        //else
        //{
        //    Console.WriteLine("Sayi Tek Sayidir");
        //}

        //Not if if if kullanımlarında son ifden sonra elseye geçmez ilk ifden sonra diğer iflere girmeyip else bloğuna gider
        // bu durumun önüne geçebilmek için else if kullanımı




        #endregion
        #region char değişkenler
        //char team;
        //Console.WriteLine("Karakter girinzi");
        //team = char.Parse(Console.ReadLine());

        //if (team == 'F' || team == 'f')
        //{
        //    Console.WriteLine("Şampiyonuz bu sene FENERBAHÇEE");
        //}
        //if(team == 'G' || team =='g')
        //{
        //    Console.WriteLine("Galatasaray");
        //}
        //if (team == 'B' || team == 'b')
        //{
        //    Console.WriteLine("Beşiktaş");
        //}
        //else
        //{
        //    Console.WriteLine("F,G,B,f,b,g değerlerinden başka tuş girmeyiniz");
        //}
        #endregion

        #region uygulama

        //Console.WriteLine("****** C# Eğitim Kampı Restoron ******");
        //Console.WriteLine();
        //Console.WriteLine("------------------------");
        //Console.WriteLine("1-Ana Yemekler");
        //Console.WriteLine("2-Çorbalar");
        //Console.WriteLine("3-Pizzalar");
        //Console.WriteLine("4-İçecekler");
        //Console.WriteLine("5-Tatlılar");
        //Console.WriteLine("------------------------");
        //Console.WriteLine();


        //string menuItem;
        //Console.WriteLine("Detayını girmek istediginiz menu seçimi");
        //menuItem = Console.ReadLine();

        //if (menuItem == "1")
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("------------Ana yemekler------------");
        //    Console.WriteLine();
        //    Console.WriteLine("1-Köri Soslu Tavuk");
        //    Console.WriteLine("2-Kızartma Tava");
        //    Console.WriteLine("3-Fasulye Pilav");
        //    Console.WriteLine("4-Fırında Somun");
        //    Console.WriteLine("5-Patlıcan Musakka");
        //    Console.WriteLine();
        //}
        //if (menuItem == "2")
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("------------Çorbalar------------");
        //    Console.WriteLine();
        //    Console.WriteLine("1-Kelle Paça Çorbası");
        //    Console.WriteLine("2-Mercimek Çorbası");
        //    Console.WriteLine("3-Ezogelin Çorbası");
        //    Console.WriteLine();
        //}
        //if (menuItem == "3")
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("------------Pizzalar------------");
        //    Console.WriteLine();
        //    Console.WriteLine("1-Ballı Hardallı Tavuklu Pizza");
        //    Console.WriteLine("2-Akdeniz Pizza");
        //    Console.WriteLine("3-Margaritha");
        //    Console.WriteLine();
        //}
        //if (menuItem == "4")
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("------------İçecekler------------");
        //    Console.WriteLine();
        //    Console.WriteLine("1-Açık Ayran");
        //    Console.WriteLine("2-Kapalı Ayran");
        //    Console.WriteLine("3-Su");
        //    Console.WriteLine();
        //}
        //if (menuItem == "5")
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("------------Tatlılar------------");
        //    Console.WriteLine();
        //    Console.WriteLine("1-Künefe");
        //    Console.WriteLine("2-Sütlaç");
        //    Console.WriteLine("3-Ezogelin");
        //    Console.WriteLine();
        //}

        #endregion

        #region switch
        //Console.WriteLine("Please enter the Month");
        //int montNumber = int.Parse(Console.ReadLine());

        //switch (montNumber)
        //{

        //    case 1: Console.WriteLine("January"); break;
        //    case 2: Console.WriteLine("February"); break;
        //    case 3: Console.WriteLine("March"); break;
        //    case 4: Console.WriteLine("April"); break;
        //    case 5: Console.WriteLine("May"); break;
        //    case 6: Console.WriteLine("June"); break;
        //    case 7: Console.WriteLine("July"); break;
        //    case 8: Console.WriteLine("August"); break;
        //    case 9: Console.WriteLine("September"); break;
        //    case 10: Console.WriteLine("October"); break;
        //    case 11: Console.WriteLine("November"); break;
        //    case 12 : Console.WriteLine("December"); break;
        //    default:
        //        Console.WriteLine("Hatalı veri girişi "); break;

        //}

        #endregion

        #region SwitchCase Hesap Makinesi
        deneme:
            int number1, number2, result;
            char symbol;
            Console.WriteLine("1. Sayiyi giriniz:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayiyi giriniz");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result); break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result); break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Carpim: " + result); break;
                case '/':
                    result = number1 * number2;
                    Console.WriteLine("Bolum: " + result); break;
                default:
                    Console.WriteLine("Hatalı Sembol Girişi Tekrar deneyiniz");
                    goto deneme;
            }
            #endregion
        }
    }
}
