#📇 Controle de contatos
(https://github.com/kevinLdias/CRUDv1/blob/main/LICENSE)

Este é um projeto simples de gerenciamento de contatos desenvolvido com ASP.NET Core MVC. Ele permite **cadastrar, editar, excluir e listar contatos** de forma prática.

## 🛠 Tecnologias utilizadas

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server (ou SQLite, dependendo da configuração)
- Bootstrap (interface)

## 📸 Funcionalidades

- ✅ Cadastro de contatos
- ✅ Listagem com paginação
- ✅ Edição e exclusão
- ✅ Validações básicas de formulário

## 📂 Estrutura

O projeto está estruturado da seguinte forma:

Controlecontatos/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── wwwroot/
├── appsettings.json

Como rodar localmente, siga os passos abaixo:
``` bash

Devem estar instalados:
Versão .net 8.0, com pacotes EF Core / EF Core Design / EF SQL SERVER e EF Core Tools - todos na versão 8.0.16 

1. Clone o repositório:
   git clone https://github.com/KevinLDias/Controlecontatos.git

2. Abra o projeto com o Visual Studio.

3. Configure a connection string no arquivo appsettings.json (com seu id de usuário do seu SQL e sua senha).

4. Rode as migrations:
-dotnet ef database update

5. Execute a aplicação:
-dotnet run
```

Autor:

Kevin Gabriel Lima Dias
📧 kevinhg2222@gmail.com

