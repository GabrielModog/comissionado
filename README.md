## Comissionado

Um projeto simples para obter comissionamento e fazer controle de estoque.

### Features
- Obter Comissionamento
- Controle de Estoque
- Multa

### Regras Comissionamento
- Vendas abaixo de R$100,00 não gera comissão
- Vendas abaixo de R$500,00 gera 1% de comissão
- A partir de R$500,00 gera 5% de comissão

### Regras de Estoque
- Um número identificador único.
- Uma descrição para identificar o tipo da movimentação realizada

### Juros de Multa
- A partir de uma data de vencimento e valor aplica multa
- Juros fixo de 2,5% por dia

### Stack
- .NET 8
- SQLite
- EF Core
- WinForms