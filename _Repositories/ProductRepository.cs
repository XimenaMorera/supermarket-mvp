using Microsoft.Data.SqlClient;
using Supermarket_mevp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())

            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.ProductName;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productsModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id =@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product 
                                    SET Product_Name =@name,
                                    Product_Observation =@observation
                                    WHERE Product_Id =@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.ProductName;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productsModel.Observation;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = productsModel.Product_Id;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Product_id"];
                        productModel.ProductName = reader["Product_Name"].ToString();
                        productModel.Observation = reader["Product_Observation"].ToString();
                        productList.Add(productModel);

                    }
                }
            }
            return productList;
        }
        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                     WHERE Product_Id=@id or Product_Name LIKE @name+ '%'
                                     ORDER By Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id= (int)reader["Product_Id"];
                        productModel.ProductName = reader["Product_Name"].ToString();
                        productModel.Observation = reader["Product_Observation"].ToString();
                        productList.Add(productModel);

                    }
                }

            }
            return productList;
        }
    }
    }
