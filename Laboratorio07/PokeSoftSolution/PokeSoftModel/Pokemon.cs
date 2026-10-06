namespace PokeSoftModel
{
    public class Pokemon
    {
        private int _idPokemon;
        private TipoPokemon? _tipoPokemon;
        private string? _nombre;
        private double _altura;
        private double _peso;
        private EstadoEvolutivo _estadoEvolutivo;
        private string? _descripcion;

        public Pokemon() { }

        public Pokemon(
            TipoPokemon? tipoPokemon,
            string? nombre,
            double altura,
            double peso,
            EstadoEvolutivo estadoEvolutivo,
            string? descripcion)
        {
            _tipoPokemon = tipoPokemon;
            _nombre = nombre;
            _altura = altura;
            _peso = peso;
            _estadoEvolutivo = estadoEvolutivo;
            _descripcion = descripcion;
        }

        public Pokemon(
            int idPokemon,
            TipoPokemon? tipoPokemon,
            string? nombre,
            double altura,
            double peso,
            EstadoEvolutivo estadoEvolutivo,
            string? descripcion)
            : this(tipoPokemon, nombre, altura, peso, estadoEvolutivo, descripcion)
        {
            _idPokemon = idPokemon;
        }

        public int IdPokemon { get => _idPokemon; set => _idPokemon = value; }
        public TipoPokemon? TipoPokemon { get => _tipoPokemon; set => _tipoPokemon = value; }
        public string? Nombre { get => _nombre; set => _nombre = value; }
        public double Altura { get => _altura; set => _altura = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public EstadoEvolutivo EstadoEvolutivo { get => _estadoEvolutivo; set => _estadoEvolutivo = value; }
        public string? Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
