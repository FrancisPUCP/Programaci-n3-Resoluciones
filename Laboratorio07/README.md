# Laboratorio 07 - PokeSoft

Resolución de práctica en C# con arquitectura por capas.

## Estructura

- `PokeSoftModel`: clases del dominio.
- `PokeSoftDBManager`: administra la conexión a MySQL.
- `PokeSoftDAO`: acceso a datos.
- `PokeSoftBusinessLogic`: lógica de migración.
- `PokemonSoftApp`: aplicación de consola y lectura de configuración.

## Flujo actualizado de configuración

`appsettings.json -> Program.cs -> DBManager.Inicializar() -> BusinessLogic -> DAO -> DBManager.Connection -> MySQL`

La cadena de conexión ya no se encuentra escrita directamente en `DBManager.cs`. La aplicación ejecutable lee `appsettings.json` usando `ConfigurationBuilder` y luego entrega la cadena al singleton `DBManager`.

El archivo `appsettings.json` de este repositorio contiene solamente un valor de ejemplo. Coloca tu cadena real únicamente en tu copia local y evita publicar credenciales.

## appsettings.json

La clave usada por el programa es:

`ConnectionStrings:MySqlConnection`

Además, el proyecto ejecutable configura:

`<CopyToOutputDirectory>Always</CopyToOutputDirectory>`

para que el archivo se copie al directorio de ejecución.

## Migración

La lógica lee `pokemon_tipo_raw`, busca o inserta el tipo correspondiente y finalmente inserta cada Pokémon normalizado.
