# Financial System

## Descrição
Financial System é um sistema de fiscalização e gerenciamento de movimentações financeiras em contas bancárias e investimentos. O objetivo do sistema é rastrear transações com entradas e saídas de dinheiro, atualizar saldos e exibir históricos. Com isso as movimentações podem ser registradas e revisadas.

## Funcionalidades
1. Em contas bancárias
- Criar conta bancária
- Efetuar depósito
- Efetuar saque
- Exibir histórico

2. Em investimentos:
- Investir
- Atualizar valores
- Vender
- Exibir histórico

## Requisitos
.NET 8.0

## Instalação e Execução
1. Acesse o diretório onde pretende salvar o projeto e clone o repositório:
```bash
cd caminho/ate/a/pasta/
git clone git@github.com:eduardoalsilva/FinancialSystem.git
```
2. Acesse a pasta e execute o programa:
```bash
cd FinancialSystem
dotnet run
```

## Programa principal
Ao executar, o programa dá as boas vindas e cria exemplos. No final informa que o programa foi encerrado:
```bash
Bem vindo ao Sistema de fiscalização financeira simples

Histórico de Conta Corrente:
29/08/2025 - Salário: R$ 1.800,00
29/08/2025 - Pagamento de conta: -R$ 200,00
Saldo atual: R$ 1.600,00

Histórico de Ações Tech:
29/08/2025 - Compra inicial: R$ 5.000,00
29/08/2025 - Apreciação: R$ 500,00
29/08/2025 - Venda parcial: -R$ 1.000,00
Saldo atual: R$ 4.500,00

Sistema de fiscalização financeira encerrado
```

## Melhorias futuras
- Persistencia de dados
- Serialização em JSON

## Autor
Eduardo Almeida da Silva

```bash
Esse README resume bem o projeto, servindo como um guia rápido. Caso precise de mais alguma informação ou ajuste, me avise! 😊
```