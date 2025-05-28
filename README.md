# 📇 Controle de Contatos

Este é um projeto simples de gerenciamento de contatos desenvolvido com ASP.NET Core MVC. Ele permite **cadastrar, editar, excluir e listar contatos** de forma prática.

## 🚀 Acesse o projeto online

🔗 [Clique aqui para acessar a aplicação](https://seusite.com)  

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

Caso deseje rodar localmente, siga os passos abaixo:

1. Clone o repositório:
   git clone https://github.com/seuusuario/Controlecontatos.git

2. Abra o projeto com o Visual Studio.

3. Configure a connection string no arquivo appsettings.json.

4. Rode as migrations (se aplicável):
-dotnet ef database update

5. Execute a aplicação:

-dotnet run

