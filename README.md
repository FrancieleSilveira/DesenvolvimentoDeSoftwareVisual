# Desenvolvimento De Software Visual

Passos para a criação e configuração do projeto da API (C#) e do FRONT (Angular).

**Autor**<br>
[Franciele do Carmo Silveira](https://www.linkedin.com/in/cfrancielesilveira/)

## Configuração de ambiente

<h3>SDK .NET 5.0</h3>

* Download: https://dotnet.microsoft.com/download

* Teste:

        dotnet --version

<br>

<h3>Visual Studio Code</h3>

* Download: https://code.visualstudio.com/<br><br>
    **Extensões:**<br>
    - **Auto Import:** Auxilia no importação de módulos externos;<br>
    - **Auto-Save on Window Change:** salva os arquivos ao mudar de janela;<br>
    - **Auto Rename Tag:** Permite renomear uma tag sem a necessidade de alterar o fechamento da tag;<br>
    - **Bracket Pair Colorize 2:** Cria marcações coloridas na abertura e fechamento de tags, métodos e etc;<br>
    - **C#**: Extensão que auxiliará no desenvolvimento de projetos em C#;<br>
    - **Color Highlight:** Identifica e colore trechos de código onde cores são identificadas;<br>
    - **Dracula Official:** Modifica o tema do ambiente de trabalho;<br>
    - **EditorConfig for VS Code:** Auxilia na construção do arquivo .editorconfig;<br>
    - **HTML CSS Support:** Dá suporte para a escrita de código HTML e CSS;<br>
    - **Live Server:** Permite executar e alterar trechos de código sem a necessidade de recarregar o navegador;<br>
    - **Material Icon Theme:** Altera os ícones de pastas e arquivos;<br>
    - **Path Intelisense:** Ajuda encontrar caminhos, arquivos e pastas dentro da workspace;<br>
    - **Prettier:** Organiza, formata e identa o código;<br>
    - **Rest Client** - Permite executar requisições HTTP direto do Visual Studio Code;<br>
    - **Settings Sync:** Permite guardar as configurações do Visual Studio Code para utilizar em qualquer máquina;<br>
    - **Visual Studio IntelliCode:** Recurso de autocompletar para várias linguagens.<br>


<br>

<h3>Node.js LTS</h3>

* Ddownload: https://nodejs.org/en/

* Teste: 

        npm --version
    
<br>

<h3>Angular</h3>

* Instrução do download: https://angular.io/guide/setup-local 

* Instalação:

        npm install -g @angular/cli

* Teste: 

        ng --version
    
<br>

<h3>Git Bash</h3>

* Download: https://git-scm.com/downloads

* Teste:

        git --version
    
<br>

## Criação do projeto

<h3>Abrir um terminal (PowerShell, cmd, GitBash) na pasta onde será criada a pasta do projeto, executar o:</h3>

* `dotnet new console --name PrimeiroApp`

     **Descrição:** Cria um projeto do tipo Console nomeando-o como PrimeiroApp.
<br>

<h3>Navegar atá a pasta criada e executar o comando para abrir o projeto criado com o VS Code:</h3>

* `code .`

* `dotnet run`

     **Descrição:** Roda o projeto.
