using MySql.Data.MySqlClient;
using PokeSoftDAO.DAO;
using PokeSoftDBManager;
using PokeSoftModel;
using System.Data;

namespace PokeSoftDAO.Impl
{
    public class PokemonDTOImpl : PokemonDTODAO
    {
        public int insertar(PokemonDTO objeto)
        {
            throw new NotImplementedException();
        }

        public List<PokemonDTO> listarTodos()
        {
            List<PokemonDTO> listaPokemonDTO = new List<PokemonDTO>();

            using MySqlConnection con = DBManager.Instance.Connection;
            using MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listar_pokemon_tipo_raw";

            using MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                PokemonDTO pokemonDTO = new PokemonDTO();

                pokemonDTO.IdRaw = lector.GetInt32("id_raw");
                pokemonDTO.NombrePokemon = lector.GetString("nombre_pokemon");
                pokemonDTO.Altura = lector.GetDouble("altura");
                pokemonDTO.Peso = lector.GetDouble("peso");

                pokemonDTO.EstadoEvolutivo =
                    (EstadoEvolutivo)Enum.Parse(
                        typeof(EstadoEvolutivo),
                        lector.GetString("estado_evolutivo"));

                pokemonDTO.NombreTipo = lector.GetString("nombre_tipo");
                pokemonDTO.DescripcionPokemon = lector.GetString("descripcion_pokemon");

                listaPokemonDTO.Add(pokemonDTO);
            }

            return listaPokemonDTO;
        }
    }
}
