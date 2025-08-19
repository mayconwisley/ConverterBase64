# ConverterBase64

O **ConverterBase64** é uma aplicação Windows Forms desenvolvida em C# (.NET 8) que permite ao usuário selecionar um arquivo do sistema e converter seu conteúdo para uma string Base64. O resultado pode ser visualizado, copiado para a área de transferência ou limpo diretamente pela interface.

## Funcionalidades

- **Selecionar Arquivo:** Permite ao usuário escolher um arquivo do sistema usando um diálogo padrão.
- **Converter para Base64:** Converte o arquivo selecionado para uma string Base64.
- **Copiar Resultado:** Copia o texto Base64 gerado para a área de transferência.
- **Limpar Resultado:** Limpa o campo de exibição do texto Base64.

## Como Usar

1. **Abrir o aplicativo:** Execute o `ConverterBase64.exe` após compilar o projeto.
2. **Selecionar arquivo:** Clique no botão "Procurar" e escolha o arquivo desejado.
3. **Converter:** Clique em "Converter" para gerar a string Base64 do arquivo selecionado.
4. **Copiar:** Clique em "Copiar" para enviar o resultado para a área de transferência.
5. **Limpar:** Clique em "Limpar" para apagar o conteúdo exibido.

## Estrutura do Projeto

- `FrmPrincipal.cs`: Formulário principal da aplicação e lógica dos botões.
- `LocalArquivo.cs`: Responsável por abrir o diálogo de seleção de arquivos.
- `Converter.cs`: Realiza a conversão do arquivo para Base64.
- `Program.cs`: Ponto de entrada da aplicação.

## Requisitos

- .NET 8 SDK
- Windows 10 ou superior

## Como Compilar

1. Clone o repositório:
```
  git clone <url-do-repositorio>
```
2. Abra a solução no Visual Studio 2022.
3. Compile o projeto (`Ctrl+Shift+B`).
4. Execute (`F5` ou `Ctrl+F5`).

## Observações

- O aplicativo não valida se o arquivo selecionado existe ou se é acessível. Certifique-se de selecionar arquivos válidos.
- O tamanho do arquivo pode impactar o desempenho e o tempo de conversão.

## Licença

Este projeto está licenciado sob a licença MIT.
