# Laboratorio 07 - PokeSoft

Resolución de práctica en C# con arquitectura por capas:

- `PokeSoftModel`: dominio/modelo.
- `PokeSoftDBManager`: conexión MySQL.
- `PokeSoftDAO`: persistencia y procedimientos almacenados.
- `PokeSoftBusinessLogic`: lógica de migración.
- `PokemonSoftApp`: aplicación de consola.

## Flujo principal

`PokemonSoftApp -> BusinessLogic -> DAO -> DBManager -> MySQL`

La migración lee `pokemon_tipo_raw`, busca o inserta cada tipo Pokémon y luego inserta el Pokémon normalizado.

## Configuración de base de datos

En `PokeSoftDBManager/DBManager.cs`, reemplaza temporalmente:

- `TU_ENDPOINT_AWS`
- `TU_BASE_DE_DATOS`
- `TU_USUARIO`
- `TU_PASSWORD`

por tus credenciales locales antes de ejecutar.

**No subas credenciales reales a GitHub.**
