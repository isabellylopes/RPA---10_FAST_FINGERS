RPA - 10 Fast Fingers

Este é um script de automação desenvolvido em C# utilizando Selenium WebDriver para realizar um teste de digitação no site 10fastfingers.com e extrair informações como palavras por minuto (WPM), número de teclas digitadas, precisão, palavras corretas e palavras erradas. Além disso, os dados são inseridos em um banco de dados PostgreSQL para posterior análise.
Pré-requisitos

Certifique-se de ter instalado:

    .NET Core SDK
    WebDriver para o navegador utilizado (por padrão, o script está configurado para usar o Firefox WebDriver, mas você pode ajustar para outros navegadores)
    Banco de dados PostgreSQL

Como usar

    Clone o repositório:

bash

git clone https://github.com/seu-usuario/rpa-10-fast-fingers.git

    Abra o projeto em sua IDE favorita (Visual Studio, Visual Studio Code, etc.).

    Abra o arquivo Program.cs.

    Execute o projeto.

    O script abrirá um navegador, navegará até a página do teste de digitação do site 10fastfingers.com e extrairá as informações.

    Os resultados serão exibidos no console e inseridos no banco de dados PostgreSQL.

Configuração do Banco de Dados

Certifique-se de configurar corretamente a conexão com o banco de dados PostgreSQL no arquivo Connection.cs antes de executar o script.
Observações

    Certifique-se de ajustar o caminho dos elementos no script para refletir a estrutura atual do site 10fastfingers.com, pois eles podem mudar ao longo do tempo.
    Este script foi desenvolvido para fins educacionais e de demonstração. Certifique-se de estar em conformidade com os Termos de Serviço do site 10fastfingers.com ao utilizá-lo.

Autor

Isabelly Cristine Lopes
