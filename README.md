# Desenvolvimento De Software Visual

Passos para a criação e configuração do projeto da API (C#) e do FRONT (Angular).

**Autor**<br>
[Franciele do Carmo Silveira](https://www.linkedin.com/in/cfrancielesilveira/)

## Configuração de ambiente

**SDK .NET 5.0**<br>
Download: https://dotnet.microsoft.com/download<br>
Teste:<br>

    dotnet --version

<br>

**Visual Studio Code**<br>
Download: https://code.visualstudio.com/<br>
    <h5>**Extensões:**

   - **Auto Import:** Auxilia no importação de módulos externos;
   - **Auto-Save on Window Change:** salva os arquivos ao mudar de janela;
   - **Auto Rename Tag:** Permite renomear uma tag sem a necessidade de alterar o fechamento da tag;
   - **Bracket Pair Colorize 2:** Cria marcações coloridas na abertura e fechamento de tags, métodos e etc;
   - **C#**: Extensão que auxiliará no desenvolvimento de projetos em C#;
   - **Color Highlight:** Identifica e colore trechos de código onde cores são identificadas;
   - **Dracula Official:** Modifica o tema do ambiente de trabalho;
   - **EditorConfig for VS Code:** Auxilia na construção do arquivo .editorconfig;
   - **HTML CSS Support:** Dá suporte para a escrita de código HTML e CSS;
   - **Live Server:** Permite executar e alterar trechos de código sem a necessidade de recarregar o navegador;
   - **Material Icon Theme:** Altera os ícones de pastas e arquivos;
   - **Path Intelisense:** Ajuda encontrar caminhos, arquivos e pastas dentro da workspace;
   - **Prettier:** Organiza, formata e identa o código;
   - **Rest Client** - Permite executar requisições HTTP direto do Visual Studio Code;
   - **Settings Sync:** Permite guardar as configurações do Visual Studio Code para utilizar em qualquer máquina;
   - **Visual Studio IntelliCode:** Recurso de autocompletar para várias linguagens.</h5>

**Node.js LTS**<br>
Ddownload: https://nodejs.org/en/<br>
Teste: `npm --version`<br>

**Angular**<br>
Instrução do download: https://angular.io/guide/setup-local<br>
Instalação: `npm install -g @angular/cli`<br>
Teste: `ng --version`<br>

**Git Bash**<br>
Download: https://git-scm.com/downloads<br>
Teste: `git --version`<br>

## Criação do projeto

<h3>Abrir um terminal (PowerShell, cmd, GitBash) na pasta onde será criada a pasta do projeto, executar o:</h3>

* `dotnet new console --name PrimeiroApp`

     **Descrição:** Cria um projeto do tipo Console nomeando-o como PrimeiroApp.
<br>

<h3>Navegar atá a pasta criada e executar o comando para abrir o projeto criado com o VS Code:</h3>

* `code .`

* `dotnet run`

     **Descrição:** Roda o projeto.
