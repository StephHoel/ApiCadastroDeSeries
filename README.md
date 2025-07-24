# SeriesCatalog

O objetivo desta API é criar um catálogo de séries. Para isto, foi utilizado .Net 9 e SQLite no CRUD inicial.

---

## Info adicional

Ao alterar BD (Seed incluso), utilizar os comandos direto da pasta `./src`.

Criar migration:
`dotnet ef migrations add <NomeDaMigration> -p Infra -s Api`

Atualizar banco:
`dotnet ef database update -p Infra -s Api`
