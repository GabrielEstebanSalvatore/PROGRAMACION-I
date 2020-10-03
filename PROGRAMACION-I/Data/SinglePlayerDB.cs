using PROGRAMACION_I.Player;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROGRAMACION_I.Data
{
    class SinglePlayerDB
    {
        DataBase connection;

        public SinglePlayerDB()
        {
            connection = new DataBase();
        }

        public bool Add(SinglePlayer oSinglePlayer)
        {
            return connection.ExecuteSqlTransaction("INSERT INTO [dbo].[SinglePlayer]([name]) VALUES('"+oSinglePlayer.Name +"')");
        }
        public int Delete(int oSinglePlayerID)
        {
            connection.ExecuteSqlTransaction("DELETE FROM SinglePlayer WHERE ID =" + oSinglePlayerID);   
            return 1;
        }

        public DataSet ShowPlayer()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM SinglePlayer");
            return connection.DataContextS(sentencia);
        }

        public DataSet ShowPlayer(int ID)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM SinglePlayer WHERE ID = " + ID);
            return connection.DataContextS(sentencia);
        }
        public DataSet ShowPlayer(string NAME)
        {
            if (NAME == null || NAME == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                throw new Exception("Debe ingresar un nombre");
            }
            SqlCommand sentencia = new SqlCommand("SELECT * FROM SinglePlayer WHERE NAME = '" + NAME + "'");
            return connection.DataContextS(sentencia);
        }
        public List<QuinielaScore> DataContextListQuiniela(int ID)
        {
            SqlCommand sentencia = new SqlCommand("SELECT quini.Score, sp.name as Nombre from dbo.SinglePlayer sp inner " +
                                                   " join dbo.QuinielaScores quini on quini.SinglePlayerID = sp.id" +
                                                   " where sp.id = " + ID);
            return connection.DataContextListQuiniela(sentencia);
        }
        public List<DarVueltaScore> DataContextListDarVueltas(int ID)
        {
            SqlCommand sentencia = new SqlCommand("SELECT dvs.Score, sp.name as Nombre from dbo.SinglePlayer sp inner " +
                                                   " join dbo.DarVueltaScores dvs on dvs.SinglePlayerID = sp.id"+
                                                   " where sp.id = " + ID );

            return connection.DataContextListDarVueltas(sentencia);
        }

        public List<AdivinaCartaScore> DataContextListAdivinaCartaScore(int ID)
        {
            SqlCommand sentencia = new SqlCommand("SELECT adc.Score, sp.name as Nombre from dbo.SinglePlayer sp inner " +
                                                   " join dbo.AdivinaLaCartaScores adc on adc.SinglePlayerID = sp.id" +
                                                   " where sp.id = " + ID);
            return connection.DataContextListAdivinaCartaScore(sentencia);
        }

        public bool AddScoreQuiniela(SinglePlayer sp, int score)
        {
            var query = $"INSERT INTO [dbo].[QuinielaScores]([SinglePlayerID],[Score]) VALUES('{sp.ID}', '{score}')";
            return connection.ExecuteSqlTransaction(query); ;
        }
        public bool AddScoreAdivinaCarta(SinglePlayer sp, int score)
        {
            var query = $"INSERT INTO [dbo].[AdivinaLaCartaScores]([SinglePlayerID],[Score]) VALUES('{sp.ID}', '{score}')";
            return connection.ExecuteSqlTransaction(query); ;
        }
        public bool AddScoreDarVueltas(SinglePlayer sp, int score)
        {
            var query = $"INSERT INTO [dbo].[DarVueltaScores]([SinglePlayerID],[Score]) VALUES('{sp.ID}', '{score}')";
            return connection.ExecuteSqlTransaction(query); ;
        }
    }
}
