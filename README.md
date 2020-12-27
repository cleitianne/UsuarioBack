# UsuarioBack
Uma api para realizar CRUD de usuários, construída em .Net Core.

## Configuração do ambiente.
  - Instale o dotnet core: https://dotnet.microsoft.com/download/dotnet-core.
  - Instale o SQL SERVER 2019: https://docs.microsoft.com/pt-br/sql/sql-server/editions-and-components-of-sql-server-version-15?view=sql-server-ver15.
  - Baixe o Visual Studio Code: https://code.visualstudio.com/download.
  - Abra o projeto no Visual Code e cheque se suas credencias do banco de dados estão certas no arquivo ```appSettings.json```.
  - Agora, basta rodar o comando ```dotnet ef database update``` para aplicar as migrations e criar o banco de dados no SQL SERVER.
  - Pronto, com o banco criado é só rodar o comando ```dotnet run``` para excutar o projeto.
 
## Descrição das funcionalidades.
  - Listar todos os usuários. Para listar todos os usuários, basta realizar um GET em ```api\usuarios```
  - Listar usuários que possuem um determinado nome. Basta realizar um GET em ```api\usuarios?nome={nome}```
  - Exibir usuário que possui um determinado cpf. É preciso realizar um GET em ```api\usuarios\cpf?cpf={cpf}```
  - Exibir usuário que possui um determinado rg. É preciso realizar um GET em ```api\usuarios\rg?rg={rg}```
  - Para criar um novo usuário. Basta fazer um post em ```api\usuarios```
  - Para excluir um usuário. É preciso fazer um post em ```api\usuarios\{id}```
