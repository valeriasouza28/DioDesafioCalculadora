# Calculadora Console em C#

Este projeto consiste em uma aplicação de console que realiza operações básicas de calculadora e mantém um histórico das últimas três operações realizadas. A calculadora suporta adição, subtração, multiplicação e divisão.

## Estrutura do Projeto

A solução está dividida em três projetos:
1. **CalculadoraConsole**: Contém a lógica da calculadora.
2. **CalculadoraApp**: Aplicação de console que utiliza a lógica da calculadora.
3. **Calculadora.Tests**: Projeto de testes unitários para validar a funcionalidade da calculadora.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) versão 6.0 ou superior.

## Configuração do Projeto

### Passo 1: Clonar o Repositório

Clone o repositório para sua máquina local.

```sh
git clone https://github.com/seu-usuario/seu-repositorio.git

cd seu-repositorio
```
### Passo 2: Restaurar Dependências. Navegue até o diretório raiz da solução e restaure as dependências dos projetos.
```sh
dotnet restore
```

### Estrutura de Diretórios
```
/SolutionDirectory
  /CalculadoraConsole
    CalculadoraConsole.csproj
    CalculadoraMetodos.cs
  /CalculadoraApp
    CalculadoraApp.csproj
    Program.cs
  /Calculadora.Tests
    Calculadora.Tests.csproj
    CalculadoraTests.cs
    ```
### Executando a Aplicação de Console
Navegue até o diretório do projeto CalculadoraApp e execute o aplicativo de console.
```sh
cd CalculadoraApp
dotnet run
```

### Uso
1. Selecione uma operação:
-  1: Adição
- 2: Subtração
- 3: Multiplicação
- 4: Divisão5: Exibir Histórico
- 6: Sair
2. **Digite os números** conforme solicitado.
3. **Visualize o resultado** da operação.
4. **Exiba o histórico** das últimas três operações selecionando a opção 5.
### 5. Executando os Testes

Navegue até o diretório do projeto Calculadora.Tests e execute os testes unitários usando o comando:
```
cd Calculadora.Tests
dotnet test
```
#### Os testes validam as seguintes funcionalidades:
- Operações básicas: adição, subtração, multiplicação e divisão.
- Exceção para divisão por zero.
- Histórico de operações, garantindo que apenas as últimas três operações sejam armazenadas.
