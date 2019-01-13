namespace Persistencia
{
    public static class ConnectionString
    {
        public static string Server { private get; set; }
        public static string Database { private get; set; }
        public static string UserId { private get; set; }
        public static string Password { private get; set; }


        public static void SetConnection(string server, string database, string userId, string password)
        {
            ConnectionString.Server = server;
            ConnectionString.Database = database;
            ConnectionString.UserId = userId;
            ConnectionString.Password = password;
        }

        public static string GetConnection()
        {
            return "Server=" + Server + ";Database=" + Database
                + ";User ID=" + UserId + ";Password=" + Password + ";";
        }
    }
}
