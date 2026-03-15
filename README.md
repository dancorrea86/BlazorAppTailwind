# BlazorAppTailwind - Projeto de Estudos 🚀

Este projeto é um laboratório pessoal desenvolvido para aprofundar conhecimentos em **Blazor** e **Tailwind CSS**. O objetivo principal é explorar a integração de um framework de componentes robusto do ecossistema .NET com a flexibilidade e agilidade do CSS utilitário.

## 🛠️ Tecnologias Utilizadas

- **.NET 10**: Versão mais recente do framework da Microsoft.
- **Blazor (ASP.NET Core)**: Para construção da interface interativa e lógica de front-end.
- **Tailwind CSS v4**: Para estilização moderna, responsiva e performática.
- **ASP.NET Core Identity**: Sistema completo de autenticação e autorização pré-configurado.
- **Node.js/npm**: Utilizados para o processamento e build das classes do Tailwind.

## 📁 Estrutura do Projeto

A organização segue as melhores práticas de desenvolvimento em Blazor:

- **/Components**: Contém os componentes `.razor` da aplicação.
    - **/Account**: Telas e lógica de identidade (Login, Registro, etc.).
    - **/Layout**: Componentes de estrutura (MainLayout, NavMenu).
    - **/Pages**: Páginas principais da aplicação (Home, Starships, Form, etc.).
- **/Data**: Contexto do banco de dados e migrações do EF Core.
- **/Models**: Classes de domínio (ex: `Starship.cs`).
- **/Service**: Camada de lógica de negócio e repositórios (ex: `StarshipRepository.cs`).
- **/Styles**: Arquivos CSS fonte onde o Tailwind é importado.
- **/wwwroot**: Arquivos estáticos e o CSS final processado.

## ✨ Funcionalidades em Estudo

- [x] **Autenticação**: Implementação do Identity com customização de UI.
- [x] **Componentização**: Criação de componentes reutilizáveis como `Card.razor` e `Form.razor`.
- [x] **Consumo de Dados**: Listagem e gerenciamento de naves espaciais (Starships).
- [x] **Estilização Utilitária**: Uso intensivo de classes Tailwind para evitar CSS personalizado complexo.

## 🚀 Como Rodar o Projeto

1.  **Pré-requisitos**:
    - .NET 10 SDK instalado.
    - Node.js instalado.

2.  **Configurar o Tailwind**:
    ```bash
    npm install
    # O build do CSS geralmente acontece automaticamente durante o build do dotnet, 
    # ou via script configurado no package.json
    ```

3.  **Executar a Aplicação**:
    ```bash
    dotnet run --project BlazorAppTailwind/BlazorAppTailwind.csproj
    ```

---
*Este projeto é estritamente para fins educacionais e experimentação técnica.*
