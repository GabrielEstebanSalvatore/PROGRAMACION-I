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
        private string CadenaConexion = "Data Source = (localdb)\\MSSQLLocalDB; " +
                    "Initial Catalog = TableroDeJuegos; " +
                    "Integrated Security = True; Connect Timeout = 30;" +
                    " Encrypt = False; TrustServerCertificate = False;" +
                    " ApplicationIntent = ReadWrite; " +
                    "MultiSubnetFailover = False";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }

        //metodos DELETE, INSERT, UPDATE sin retorno de datos
        public bool DataContextDIU(string strCommand) {
            try
            {
               
                SqlCommand command = new SqlCommand();

                command.CommandText = strCommand; 
                command.Connection = this.EstablecerConexion();
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

        //metodo SELECT con retorno de datos
        public bool DataContextS(string strCommand)
        {
            try
            {

                SqlCommand command = new SqlCommand();

                command.CommandText = strCommand;
                command.Connection = this.EstablecerConexion();
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
