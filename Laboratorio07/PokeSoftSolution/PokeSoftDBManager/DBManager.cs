using MySql.Data.MySqlClient;

namespace PokeSoftDBManager
{
    public class DBManager
    {
        private static DBManager? instance;
        private string? cadenaConexion;

        public void Inicializar(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

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
                MySqlConnection con =
                    new MySqlConnection(cadenaConexion);

                con.Open();
                return con;
            }
        }
    }
}
