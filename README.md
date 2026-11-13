
Readme · MD
# Sistema de Gerenciamento de Veículos
 
Projeto da avaliação **N1** da disciplina de **Estrutura de Dados** (Ciência da Computação), em C#.
 
O sistema lê uma base de registros de veículos e permite consultar, filtrar e gerar relatórios sobre eles por meio de um menu interativo no console.
 
---
 
##  Sumário
 
- [Registro](#-registro)
- [Funcionalidades](#️-funcionalidades)
- [Menu](#️-menu)
- [Requisitos de arquitetura](#️-requisitos-de-arquitetura)
- [Regiões e Estados](#️-regiões-e-estados)
- [Estrutura sugerida do projeto](#-estrutura-sugerida-do-projeto)
---
 
##  Registro
 
Um **registro** é uma linha completa, composta por todos os campos (todas as colunas).
 
| Campo | Tipo | Exemplo |
|---|---|---|
| Nome do proprietário | `string` | `Daniel Garcia Felicione` |
| Estado (UF) | `string` | `PR` |
| Placa | `string` | `KSR4186` |
| Ano de fabricação | `int` | `2009` |
| Valor do veículo | `decimal` | `38981.25` |
 
Exemplo de linha na base de dados:
 
```
Daniel Garcia Felicione PR KSR4186 2009 38981.25
```
 
> A base possui 58 registros fornecidos no enunciado. O nome do proprietário pode ter de 2 a 4 palavras, então o parsing deve considerar que os **4 últimos campos** da linha são sempre `UF`, `placa`, `ano` e `valor`.
 
---
 
##  Funcionalidades
 
### 1. Filtrar por região
 
Lista todos os registros dos Estados de uma região escolhida pelo usuário.
 
Exemplo: ao escolher **"sul"**, exibir todos os registros de **PR, SC e RS**.
 
### 2. Cálculo de imposto
 
Imprime todos os registros com uma **6ª coluna** contendo o valor do imposto, calculado pelo percentual da região do veículo:
 
| Região | Alíquota |
|---|---|
| Sul | 3,5% |
| Sudeste | 4,5% |
| Centro-Oeste | 5,2% |
| Norte | 4,8% |
| Nordeste | 4,9% |
 
A 6ª coluna pode exibir o veículo como **isento** por dois critérios:
 
**2.1 – Isenção por valor:** veículos com valor **igual ou inferior a R$ 20.000,00** são isentos.
 
**2.2 – Isenção por idade do veículo:**
 
| Região | Idade para isenção |
|---|---|
| Sul | 12 anos |
| Sudeste | 14 anos |
| Centro-Oeste | 16 anos |
| Norte | 11 anos |
| Nordeste | 15 anos |
 
### 3. Filtrar por ano de fabricação
 
Lista todos os registros de um determinado ano informado pelo usuário.
 
Exemplo: se o usuário solicitar **2020**, listar todos os carros fabricados em 2020.
 
### 4. Relatório de frequência por ano de fabricação
 
- **4.1** – Método que indica o **ano do carro mais novo**.
- **4.2** – Método que indica o **ano do carro mais velho**.
- **4.3** – Usando os resultados de 4.1 e 4.2, contar **quantos carros foram fabricados em cada ano** dentro do intervalo.
### 5. Valor médio por região
 
Calcula e exibe o **valor médio dos veículos de cada região** do país.
 
### 6. Amplitude de valor entre anos de fabricação
 
- **6.1** – Descobrir o **ano de fabricação e o valor do carro mais barato**.
- **6.2** – Descobrir o **ano de fabricação e o valor do carro mais caro**.
- **6.3** – Imprimir as duas linhas (6.1 e 6.2) e, em uma **terceira linha**, a **diferença entre os anos e entre os valores**.
### 7. Validação de emplacamento
 
Verifica se a **letra inicial da placa** é coerente com a região do Estado do veículo, segundo a regra:
 
| Região | Letras iniciais permitidas |
|---|---|
| Sul | G, H, I, J, K |
| Sudeste | A, B, C, D, E, F |
| Centro-Oeste | L, M, N, O |
| Norte | P, Q, R, S, T |
| Nordeste | U, V, W, X, Y, Z |
 
Para cada **violação** encontrada, imprimir: **nome do proprietário, Estado, placa, ano de fabricação e valor do carro**.
 
---
 
##  Menu
 
O programa deve ter um **menu interativo** para o usuário escolher a opção desejada. Após exibir a resposta de qualquer opção, **o menu deve ser exibido novamente**.
 
Exemplo:
 
```
===== GERENCIAMENTO DE VEÍCULOS =====
1 - Filtrar por região
2 - Calcular imposto
3 - Filtrar por ano de fabricação
4 - Relatório de frequência por ano
5 - Valor médio por região
6 - Amplitude de valor entre anos
7 - Validar emplacamento
0 - Sair
Escolha uma opção:
```
 
---
 
## 🏗️ Requisitos de arquitetura
 
- O projeto deve conter **classes que resolvem cada enunciado** e **retornam os dados para a função `Main`**.
- A leitura, o processamento e a impressão devem ficar **separados**: as classes calculam e retornam, o `Main` exibe.
---
 
## 🗺️ Regiões e Estados
 
| Região | Estados |
|---|---|
| Sul | PR, SC, RS |
| Sudeste | SP, RJ, MG, ES |
| Centro-Oeste | GO, MT, MS, DF |
| Norte | AC, AP, AM, PA, RO, RR, TO |
| Nordeste | AL, BA, CE, MA, PB, PE, PI, RN, SE |
 
---
 
