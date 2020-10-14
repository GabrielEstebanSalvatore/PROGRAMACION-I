using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PROGRAMACION_I.message;
using PROGRAMACION_I.Player;

namespace PROGRAMACION_I.Data
{
    class DataBase
    {
        private string CadenaConexion = 
                    "Integrated Security = True; Connect Timeout = 30;" +
                    " Encrypt = False; TrustServerCertificate = False;" +
                    " ApplicationIntent = ReadWrite; " +
                    "MultiSubnetFailover = False";
        SqlConnection Conexion;
        SqlDataReader LeerFilas;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }

        //metodos DELETE, INSERT, UPDATE sin retorno de datos
        public bool DataContextDIU(string strCommand) {
            Conexion.Open();
            SqlTransaction transaction = Conexion.BeginTransaction("SampleTransaction");
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = strCommand; 
                command.Connection = this.EstablecerConexion();
                
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                command.Transaction.Commit();
                Conexion.Close();

                return true;    
            }
            catch(Exception e)
            {
                try
                {
                   transaction.Rollback();
                }
                catch (Exception)
                {
                    ErrorMessage errorMessage = new ErrorMessage(e.ToString());
                    errorMessage.Visible = true;
                    throw e;
                }
                    return false;
                
            }
        }

        public bool ExecuteSqlTransaction(string strCommand)
        {
            using (SqlConnection connection = new SqlConnection(this.CadenaConexion))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = strCommand;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
                return false;
            }
        }

        //metodo SELECT con retorno de datos
        public DataSet DataContextS(SqlCommand sqlCommand)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand();
                command = sqlCommand;
                command.Connection = EstablecerConexion();
                adapter.SelectCommand = command;
                Conexion.Open();
                adapter.Fill(dataSet);
                Conexion.Close();
                return dataSet;
            }
            catch(Exception e)
            {
                ErrorMessage errorMessage = new ErrorMessage(e.ToString());
                errorMessage.Visible = true;
                throw e;
            }

        }

        public List<QuinielaScore> DataContextListQuiniela(SqlCommand sqlCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand();
                command = sqlCommand;
                command.Connection = EstablecerConexion();
                adapter.SelectCommand = command;
                Conexion.Open();
                LeerFilas = command.ExecuteReader();
                List<QuinielaScore> Listar = new List<QuinielaScore>();
                while (LeerFilas.Read())
                {
                    Listar.Add(new QuinielaScore
                    {
                        SinglePlayer = new SinglePlayer(LeerFilas["Nombre"].ToString()),
                        Score = int.Parse(LeerFilas["Score"].ToString())
                    });
                }

                Conexion.Close();
                LeerFilas.Close();
                return Listar;
            }
            catch (Exception e)
            {
                ErrorMessage errorMessage = new ErrorMessage(e.ToString());
                errorMessage.Visible = true;
                throw e;
            }
        }

        public List<DarVueltaScore> DataContextListDarVueltas(SqlCommand sqlCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand();
                command = sqlCommand;
                command.Connection = EstablecerConexion();
                adapter.SelectCommand = command;
                Conexion.Open();
                LeerFilas = command.ExecuteReader();
                List<DarVueltaScore> Listar = new List<DarVueltaScore>();
                while (LeerFilas.Read())
                {
                    Listar.Add(new DarVueltaScore
                    {
                        SinglePlayer = new SinglePlayer(LeerFilas["Nombre"].ToString()),
                        Score = int.Parse(LeerFilas["Score"].ToString())
                    }) ;
                }

                Conexion.Close();
                LeerFilas.Close();
                return Listar;
            }
            catch (Exception e)
            {
                ErrorMessage errorMessage = new ErrorMessage(e.ToString());
                errorMessage.Visible = true;
                throw e;
            }
        }

        public List<AdivinaCartaScore> DataContextListAdivinaCartaScore(SqlCommand sqlCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand();
                command = sqlCommand;
                command.Connection = EstablecerConexion();
                adapter.SelectCommand = command;
                Conexion.Open();
                LeerFilas = command.ExecuteReader();
                List<AdivinaCartaScore> Listar = new List<AdivinaCartaScore>();
                while (LeerFilas.Read())
                {
                    Listar.Add(new AdivinaCartaScore
                    {
                        SinglePlayer = new SinglePlayer(LeerFilas["Nombre"].ToString()),
                        Score = int.Parse(LeerFilas["Score"].ToString())
                    });
                }

                Conexion.Close();
                LeerFilas.Close();
                return Listar;
            }
            catch (Exception e)
            {
                ErrorMessage errorMessage = new ErrorMessage(e.ToString());
                errorMessage.Visible = true;
                throw e;
            }
        }


    }
}
