using PokeSoftModel;

namespace PokeSoftDAO.DAO
{
    public interface TipoPokemonDAO : IDAO<TipoPokemon>
    {
        int buscarIDPorNombre(string nombre);
    }
}
