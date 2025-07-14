# Tech Products Store

O projeto desenvolvido é um sistema de gerenciamento de produtos de uma loja de artigos de tecnologia e eletrônicos.

Foram implementados o back-end, que possui o serviço de autenticação de usuários, e o banco de dados do sistema. Faltou ser implementado o front-end por questões de conhecimento técnico e tempo que eu tinha disponível para continuar desenvolvendo o projeto.

Tentei construir um front-end para a aplicação utilizando ferramentas de IA generativa que guiassem o processo de desenvolvimento, pois não pude dedicar mais tempo nessa parte para adquirir conhecimentos técnicos que me permitissem construir uma interface funcional. Contudo, o resultado final do protótipo de aplicação front-end não foi satisfatório. Assim, estou enviando o projeto com todas as outras funcionalidades, exceto essa parte da interface da aplicação.

Foi minha primeira vez desenvolvendo com `C#`, bem como construindo uma API com ASP.NET Core, assim tive um processo inicial de aprendizado e entendimento. Então, nesse tempo não apenas desenvolvi o código em questão, mas estudei os materiais de referência para preparar o ambiente de desenvolvimento em ASP.NET Core e segui tutoriais de [construção de APIs](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio), de [configuração de banco de dados](https://tutorials.eu/how-to-create-a-database-in-asp-net-core/) e de [construção de serviços de autenticação de usuários](https://www.youtube.com/watch?v=S0RSsHKiD6Y).

O banco de dados utilizado foi o Microsoft SQL Server (MSS), utilizando a ferramenta MSS Management Studio para controle do BD.

Acrescento em seguida informações que foram úteis para a realização do teste:

***

**Materiais de Referência**

- [Visão geral do ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-9.0)
- [Visão geral do ASP.NET Core MVC](https://learn.microsoft.com/pt-br/aspnet/core/mvc/overview?view=aspnetcore-9.0)
- [Tutorial: Introdução ao EF Core em um aplicativo Web ASP.NET MVC](https://learn.microsoft.com/pt-br/aspnet/core/data/ef-mvc/intro?view=aspnetcore-9.0)
- [Tutorial: Criar um aplicativo ASP.NET Core com o React no Visual Studio](https://learn.microsoft.com/pt-br/visualstudio/javascript/tutorial-asp-net-core-with-react?view=vs-2022)
- [Início Rápido: Conectar-se a uma instância do SQL Server e consultá-la usando o SSMS (SQL Server Management Studio)](https://learn.microsoft.com/pt-br/ssms/quickstarts/ssms-connect-query-sql-server?view=sql-server-ver16&tabs=modern)
- [Como gerenciar migrações](https://learn.microsoft.com/pt-br/ef/core/managing-schemas/migrations/managing?tabs=vs)

***

**Informações de projeto:**

[Swagger UI](https://localhost:7025/swagger/index.html)

**SQL Server**
Nome da Instância: MSSQLSERVER  
Cadeia de Conexão: Server=localhost;Database=master;Trusted_Connection=True;  
Administradores SQL: DESKTOP-B9PGF75\mari4

Instalações com `npm` que seriam usadas no front-end:
> `npm i react-router-dom`  
> `npm i zustand`
