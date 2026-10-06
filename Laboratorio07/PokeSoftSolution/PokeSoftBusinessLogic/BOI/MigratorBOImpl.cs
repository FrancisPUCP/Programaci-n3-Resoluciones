using PokeSoftBusinessLogic.BO;
using PokeSoftDAO.DAO;
using PokeSoftDAO.Impl;
using PokeSoftModel;

namespace PokeSoftBusinessLogic.BOI
{
    public class MigratorBOImpl : IMigratorBO
    {
        private readonly PokemonDAO daoPokemon;
        private readonly PokemonDTODAO daoPokemonDTO;
        private readonly TipoPokemonDAO daoTipoPokemon;

        public MigratorBOImpl()
        {
            daoPokemon = new PokemonImpl();
            daoPokemonDTO = new PokemonDTOImpl();
            daoTipoPokemon = new TipoPokemonImpl();
        }

        public void Run()
        {
            List<PokemonDTO> pokemonDTOs = daoPokemonDTO.listarTodos();

            foreach (PokemonDTO pokemonDTO in pokemonDTOs)
            {
                string nombreTipo = pokemonDTO.NombreTipo ?? string.Empty;

                TipoPokemon tipoPokemon = new TipoPokemon(nombreTipo);

                int idTipoPokemon =
                    daoTipoPokemon.buscarIDPorNombre(nombreTipo);

                if (idTipoPokemon == 0)
                {
                    idTipoPokemon =
                        daoTipoPokemon.insertar(tipoPokemon);
                }

                tipoPokemon.IdTipoPokemon = idTipoPokemon;

                Pokemon pokemon = new Pokemon
                {
                    Altura = pokemonDTO.Altura,
                    Descripcion = pokemonDTO.DescripcionPokemon,
                    EstadoEvolutivo = pokemonDTO.EstadoEvolutivo,
                    Nombre = pokemonDTO.NombrePokemon,
                    Peso = pokemonDTO.Peso,
                    TipoPokemon = tipoPokemon
                };

                daoPokemon.insertar(pokemon);
            }
        }
    }
}
