using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PROGRAMACION_I.Data
{
    class DataBase
    {
        public bool DataContext() {
            try
            {
                SqlConnection Conexion = new SqlConnection(
                    "Data Source = (localdb)\\MSSQLLocalDB; " +
                    "Initial Catalog = TableroDeJuegos; " +
                    "Integrated Security = True; Connect Timeout = 30;" +
                    " Encrypt = False; TrustServerCertificate = False;" +
                    " ApplicationIntent = ReadWrite; " +
                    "MultiSubnetFailover = False");

                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT * FROM SinglePlayer";
                command.Connection = Conexion;
                Conexion.Open();
                command.ExecuteNonQuery();
                Conexion.Close();
                return true;    
            }
            catch
            {
                return false;
            }
        }
    }
}
