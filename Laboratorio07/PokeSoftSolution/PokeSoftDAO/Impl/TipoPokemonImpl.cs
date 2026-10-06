using MySql.Data.MySqlClient;
using PokeSoftDAO.DAO;
using PokeSoftDBManager;
using PokeSoftModel;
using System.Data;

namespace PokeSoftDAO.Impl
{
    public class TipoPokemonImpl : TipoPokemonDAO
    {
        public int buscarIDPorNombre(string nombre)
        {
            int resultado = 0;

            using MySqlConnection con = DBManager.Instance.Connection;
            using MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "obtener_tipo_pokemon_por_nombre";

            cmd.Parameters.AddWithValue("@p_nombre", nombre);
            cmd.Parameters.Add("@p_id_tipo", MySqlDbType.Int32)
                .Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            if (cmd.Parameters["@p_id_tipo"].Value != DBNull.Value)
            {
                resultado = Convert.ToInt32(
                    cmd.Parameters["@p_id_tipo"].Value);
            }

            return resultado;
        }

        public int insertar(TipoPokemon tipoPokemon)
        {
            int resultado;

            try
            {
                using MySqlConnection con = DBManager.Instance.Connection;
                using MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertar_tipo_pokemon";

                cmd.Parameters.AddWithValue("@p_nombre", tipoPokemon.Nombre);

                cmd.Parameters.Add("@p_id_tipo", MySqlDbType.Int32)
                    .Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                tipoPokemon.IdTipoPokemon =
                    Convert.ToInt32(cmd.Parameters["@p_id_tipo"].Value);

                resultado = tipoPokemon.IdTipoPokemon;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al insertar el tipo de pokemon: " + ex.Message,
                    ex);
            }

            return resultado;
        }

        public List<TipoPokemon> listarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
