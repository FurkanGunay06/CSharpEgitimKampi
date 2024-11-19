using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_DatabaseCrud
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("***** Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();
            Console.WriteLine("------------------------------");

            #region kategori

            //Console.WriteLine("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=.\\;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion Kategori


            #region ürün ekleme
            /* Console.WriteLine("Eklemek istediginiz Ürün Adı");
             string productName = Console.ReadLine();
             Console.WriteLine("Ürün Fiyati");
             decimal productPrice = decimal.Parse(Console.ReadLine());

             SqlConnection connection = new SqlConnection("Data Source=.\\;initial Catalog=EgitimKampiDb;integrated security=true");

             connection.Open();

             SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values" +
                 " (@productName,@productPrice,@productStatus)",connection);

             command.Parameters.AddWithValue("@productName",productName);
             command.Parameters.AddWithValue("@productPrice", productPrice);
             command.Parameters.AddWithValue("@productStatus", true);
             command.ExecuteNonQuery();
             connection.Close();
             Console.WriteLine("Ürün Eklemesi Başarılı");
            */
            #endregion

            #region ürün listeleme

            //SqlConnection connection = new SqlConnection("Data Source=.\\;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adaptaer = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adaptaer.Fill(dt);

            //foreach (DataRow row in dt.Rows)  // Bütün satırları okuma tek tek 
            //{ 
            //    foreach(var item in row.ItemArray) // Satırları sütun şeklinde okumak
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region ürün silme

            //Console.WriteLine("Silmek istediginiz ürüünin idisini girinzi");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=.\\;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();  

            //connection.Close();
            //Console.WriteLine("Silme işlemi başarılı");
            #endregion

            #region güncelleme


            Console.Write("Güncellenecek ürün id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün adı: ");

            string productName = Console.ReadLine();
            Console.Write("Güncellenecek Ürün fiyatı: ");

            decimal productPrice = decimal.Parse(Console.ReadLine());   
            

            SqlConnection connection = new SqlConnection("Data Source=.\\;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();


            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice" +
                " where ProductId=@productId", connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme başarılı");




            #endregion


            Console.Read();

        }
    }
}
