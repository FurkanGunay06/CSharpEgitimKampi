using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekler

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "yellow";
            //colors[2] = "white";
            //colors[3] = "blue";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Yozgat", "Kayseri", "Ankara", "Edirne" };
            //Console.WriteLine(cities[0]);
            #endregion
            #region Dizideki tüm elemanları listeleme
            //string[] colors = { "Sarı", "Lacivert", "Mor", "Lila" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for(int i=0; i < numbers.Length; i++) 
            //    {
            //        if (numbers[i] % 3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //    }
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0;i<symbols.Length;i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber =myArray[0];


            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //       maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "veli", "ayşe", "cem" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //} 

            #endregion
            #region Dizi Metotları
            //string[] teachers = { "furkan", "murat", "erhan", "seda" };
            //int index = Array.IndexOf(teachers,"murat");
            //Console.WriteLine(index);
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı:"+numbers.Max()+" Dizinin en küçük elemanı:"+numbers.Min());
            #endregion

            #region kullanıcıdan değer alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.sayiyi giriniz");
            //    numbers[i] = int.Parse( Console.ReadLine() );
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("Çift Sayilar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Tek sayilar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
               Console.Read();
        }
    }
}
