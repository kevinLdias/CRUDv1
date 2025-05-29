# 📇 Controle de Contatos  
[![License](https://img.shields.io/badge/license-MIT-green)](https://github.com/kevinLDias/CRUDv1/blob/main/LICENSE)

Este é um projeto simples de gerenciamento de contatos desenvolvido com **ASP.NET Core MVC**. Ele permite cadastrar, editar, excluir e listar contatos de forma prática.

---

## 🛠 Tecnologias Utilizadas

- C#  
- ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server (ou SQLite, dependendo da configuração)  
- Bootstrap (para a interface)

---

## 📸 Funcionalidades

- ✅ Cadastro de contatos  
- ✅ Listagem com paginação  
- ✅ Edição e exclusão de contatos  
- ✅ Validações básicas de formulário  

---

## 📂 Estrutura do Projeto

ControleContatos/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── wwwroot/
├── appsettings.json

---

## ▶️ Como Rodar o Projeto

### ✅ Pré-requisitos

- .NET SDK 8.0 instalado  
- SQL Server (ou SQLite, se adaptado)  
- Pacotes NuGet:
  - Microsoft.EntityFrameworkCore  
  - Microsoft.EntityFrameworkCore.Design  
  - Microsoft.EntityFrameworkCore.SqlServer  
  - Microsoft.EntityFrameworkCore.Tools
---

### 💻 No Visual Studio

1. **Clone o repositório:**

```bash
git clone git@github.com:kevinLdias/CRUDv1.git
```
Abra o projeto:

No Visual Studio, vá em Arquivo > Abrir > Projeto/Solução e selecione o arquivo .csproj ou a pasta do projeto.

Configure a connection string:

No arquivo appsettings.json, substitua pela sua conexão local do SQL Server:

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=ControleContatosDB;User Id=SEU_USUARIO;Password=SUA_SENHA;"
}
```

Rode as migrations:

Vá até o Console do Gerenciador de Pacotes (Ferramentas > Gerenciador de Pacotes NuGet > Console) e execute:

```bash
Update-Database
```

Execute o projeto!

---

💻 No JetBrains Rider
Clone o repositório:

```bash

git clone git@github.com:kevinLdias/CRUDv1.git
```

Abra o projeto no Rider:

Vá em File > Open... e selecione a pasta CRUDv1.

Restaure os pacotes NuGet:

O Rider deve restaurar automaticamente, mas você também pode rodar:

```bash 
dotnet restore
```

Configure a connection string:

Edite o arquivo appsettings.json com as informações do seu banco:

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=ControleContatosDB;User Id=SEU_USUARIO;Password=SUA_SENHA;"
}
```

Rode as migrations:

Use o terminal do Rider para aplicar as migrações:

```bash
dotnet ef database update
```

⚠️ Se dotnet ef não estiver disponível, instale a ferramenta globalmente:

```bash
dotnet tool install --global dotnet-ef
```

Execute a aplicação!

👤 Autor
Kevin Gabriel Lima Dias
📧 kevinhg2222@gmail.com

📄 Licença
Este projeto está licenciado sob a Licença MIT.
