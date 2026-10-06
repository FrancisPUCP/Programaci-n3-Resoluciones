namespace PokeSoftModel
{
    public class TipoPokemon
    {
        private int _idTipoPokemon;
        private string? _nombre;

        public TipoPokemon() { }

        public TipoPokemon(string? nombre)
        {
            _nombre = nombre;
        }

        public TipoPokemon(int idTipoPokemon, string? nombre)
        {
            _idTipoPokemon = idTipoPokemon;
            _nombre = nombre;
        }

        public int IdTipoPokemon
        {
            get => _idTipoPokemon;
            set => _idTipoPokemon = value;
        }

        public string? Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
    }
}
