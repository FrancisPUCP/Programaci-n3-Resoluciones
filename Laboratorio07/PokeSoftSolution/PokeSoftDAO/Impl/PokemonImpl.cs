using MySql.Data.MySqlClient;
using PokeSoftDAO.DAO;
using PokeSoftDBManager;
using PokeSoftModel;
using System.Data;

namespace PokeSoftDAO.Impl
{
    public class PokemonImpl : PokemonDAO
    {
        public int insertar(Pokemon pokemon)
        {
            int resultado;

            try
            {
                using MySqlConnection con = DBManager.Instance.Connection;
                using MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertar_pokemon";

                cmd.Parameters.AddWithValue("@p_nombre", pokemon.Nombre);
                cmd.Parameters.AddWithValue(
                    "@p_fid_tipo",
                    pokemon.TipoPokemon!.IdTipoPokemon);
                cmd.Parameters.AddWithValue("@p_altura", pokemon.Altura);
                cmd.Parameters.AddWithValue("@p_peso", pokemon.Peso);
                cmd.Parameters.AddWithValue(
                    "@p_estado_evolutivo",
                    pokemon.EstadoEvolutivo.ToString());
                cmd.Parameters.AddWithValue(
                    "@p_descripcion",
                    pokemon.Descripcion);

                cmd.Parameters.Add("@p_id_pokemon", MySqlDbType.Int32)
                    .Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                resultado =
                    Convert.ToInt32(cmd.Parameters["@p_id_pokemon"].Value);

                pokemon.IdPokemon = resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al insertar el pokemon: " + ex.Message,
                    ex);
            }

            return resultado;
        }

        public List<Pokemon> listarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
