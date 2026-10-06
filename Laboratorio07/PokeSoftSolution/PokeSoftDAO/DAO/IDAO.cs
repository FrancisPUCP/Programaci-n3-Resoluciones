namespace PokeSoftDAO.DAO
{
    public interface IDAO<T>
    {
        int insertar(T objeto);
        List<T> listarTodos();
    }
}
