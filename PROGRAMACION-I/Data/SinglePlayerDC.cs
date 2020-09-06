namespace PROGRAMACION_I.Data
{
    class SinglePlayerDC
    {
        DataBase connection;

        public SinglePlayerDC()
        {
            connection = new DataBase();
        }

        public bool Add()
        {
            return connection.DataContextDIU("INSERT INTO [dbo].[SinglePlayer]([name],[coins]) VALUES('jugador3', 100)");
        }
    }
}
