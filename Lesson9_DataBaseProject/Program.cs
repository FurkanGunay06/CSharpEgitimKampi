using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen Getirmek İstediginiz Tablo Numarasını giriniz");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------");


            SqlConnection connection = new SqlConnection("Data Source=.\\;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From  TblCategory", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()) ;
                }
                Console.WriteLine();

            }

            connection.Close();





           // Console.Read();
        }
    }
}
