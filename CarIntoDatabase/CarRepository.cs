using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace CarIntoDatabase
{
    public class CarRepository
    {
        public string? ConnectionString { get; set; }

        public CarRepository() 
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            ConnectionString = config.GetConnectionString("MyDBConnection");
        }

        public void Create(Car car)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Car (Make, Model, Year, Description)" +
                                                 "VALUES(@Make,@Model,@Year,@Description)" +
                                                 "SELECT @@IDENTITY", con);
                cmd.Parameters.Add("@Make", SqlDbType.NVarChar).Value = car.Make;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = car.Model;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = car.Year;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = car.Description;
                car.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
