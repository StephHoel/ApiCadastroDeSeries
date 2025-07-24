# SeriesCatalog

O objetivo desta API é criar um catálogo de séries. Para isto, foi utilizado .Net 9 e SQLite no CRUD inicial.

---

## Info adicional

Para alterar banco de dados (Seed incluso), utilizar os comandos direto da pasta `./src`:

`dotnet ef migrations add <NomeDaMigration> -p Infra -s Api` para criar a migration

`dotnet ef database update -p Infra -s Api` para atualizar o banco
