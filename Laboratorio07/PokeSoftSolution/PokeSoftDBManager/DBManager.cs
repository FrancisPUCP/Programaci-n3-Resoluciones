using MySql.Data.MySqlClient;

namespace PokeSoftDBManager
{
    public class DBManager
    {
        private static DBManager? instance;

        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBManager();

                return instance;
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                // Reemplaza estos valores solo en tu copia local.
                // No subas credenciales reales al repositorio.
                string cadena =
                    "Server=TU_ENDPOINT_AWS;" +
                    "Port=3306;" +
                    "Database=TU_BASE_DE_DATOS;" +
                    "User ID=TU_USUARIO;" +
                    "Password=TU_PASSWORD;";

                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                return con;
            }
        }
    }
}
