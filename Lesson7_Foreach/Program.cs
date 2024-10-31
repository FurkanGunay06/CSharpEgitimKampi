using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //:Foreach(1;2;3;4)
            //:1 Değişken türü
            //:2 Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,Diziler

            //string[] cities = { "ankara", "istanbul", "yozgat", "çorum", "kayseri" };


            //foreach (string i in cities)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 5, 15, 52, 52, 52, 52, 62, 62 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbers = { 5, 15, 52, 12, 43, 55, 21, 62 };

            //foreach (int i in numbers)
            //{
            //    if(i %2== 0)
            //        Console.WriteLine(i);


            //}


            //int[] numbers = { 5, 15, 52, 12, 43, 55, 21, 62 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;


            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>();

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //List<char> chars = new List<char>();
            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //   chars.Add(c);
            //}

            //foreach (char c in chars)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek sınav sistemi

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isim ve notl ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her Öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}.isimli öğrencinin  {j + 1}. sınav notunu giriniz ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }
            // Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                // Öğrencinin geçip kalma durumları

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }


            }
            Console.Read();


            #endregion
        }
    }
}
