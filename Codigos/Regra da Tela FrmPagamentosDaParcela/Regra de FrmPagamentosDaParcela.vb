



4️⃣ CABEÇALHO — Dados da Parcela (somente leitura)
🔹 Container

KryptonPanel

Nome: pnlResumoParcela

🔹 Controles (padronizados)
Informação	Controle	Observação
Cliente	txtCliente	ReadOnly
Venda	txtVendaId	ReadOnly
Parcela	txtNumeroParcela	Ex: 3/6
Data da Venda	txtDataVenda	ReadOnly
Vencimento	txtDataVencimento	ReadOnly
Valor da Parcela	txtValorParcela	ReadOnly
Total Recebido	txtValorRecebido	ReadOnly
Saldo	txtSaldo	ReadOnly
Status	lblStatusParcela	Label estilizado
🎨 Regra visual do Status (obrigatória)
Status	Cor
Paga	Verde
Parcial	Azul
Atrasada	Vermelho
Cancelada	Cinza

📌 Status nunca será TextBox
📌 É informação de estado, não dado editável

5️⃣ GRID — Pagamentos da Parcela
🔹 Container

KryptonPanel

Nome: pnlPagamentos
🔹 DataGridView
Nome: dgvPagamentosParcela
🔹 Colunas

Coluna	Observação
Data do Pagamento	dd/MM/yyyy
Forma de Pagamento	Texto
Valor Pago	Moeda
Observação	Texto livre
Usuário	Opcional
📌 Regras do grid

❌ Sem checkbox
❌ Sem edição inline
❌ Sem seleção múltipla

✔️ Apenas leitura
✔️ Ordenado por DataPagamento ASC

6️⃣ RODAPÉ — Ações da Parcela
🔹 Container

KryptonPanel

Nome: pnlAcoesParcela

🔹 Botões (nomes definitivos)
Botão	Nome	Regra
Baixar Parcela	btnBaixarParcela	se não paga
Estornar Pagamento	btnEstornarPagamento	se ValorRecebido > 0
Gerar Recibo	btnGerarRecibo	se houver pagamentos
Gerar PDF Detalhado	btnGerarPdfParcela	sempre
Fechar	btnFechar	sempre

📌 Botões não somem
📌 Apenas habilitam/desabilitam conforme regra

👉 DEFINIÇÃO CRÍTICA
O QUE SAI DO FrmFinanceiro
❌ REMOVIDO do FrmFinanceiro

dgvPagamentos

lógica de seleção de pagamentos

geração de recibo por pagamento individual

visualização detalhada de pagamentos parciais

📌 O FrmFinanceiro passa a ser:
✔️ lista de parcelas
✔️ filtros
✔️ ações de alto nível
✔️ O QUE PERMANECE NO FrmFinanceiro

dgvContasAReceber

filtros (período, cliente, status)

seleção de parcelas

botões:
Baixar
Estornar
Detalhe (novo)

📌 Novo botão sugerido

btnDetalharParcela

Ícone: lupa / detalhe / extrato

🔁 FLUXO DE ABERTURA DO FrmDetalheParcela
1️⃣ Usuário seleciona UMA parcela

clique duplo na linha OU

botão Detalhar Parcela

2️⃣ FrmFinanceiro envia APENAS:

ParcelaID

(opcional) VendaID, ClienteID para título

📌 Nada de lista
📌 Nada de pagamentos

3️⃣ FrmDetalheParcela faz:

busca completa da parcela
busca dos pagamentos
cálculo de saldo
definição de status
habilitação dos botões

4️⃣ Ao fechar

Se houve alteração (baixa / estorno):
DialogResult.OK
FrmFinanceiro → CarregarContasAReceber()
Se apenas visualizou:
DialogResult.Cancel

🔒 REGRAS DE NEGÓCIO APLICADAS NO FrmDetalheParcela

✔️ Parcela paga → não baixa
✔️ Parcela cancelada → nada permitido
✔️ Sem pagamento → estorno desabilitado
✔️ PDF sempre disponível

📌 Regra nunca duplicada no FrmFinanceiro



1️⃣ CONTRATO DE ENTRADA DO FrmDetalheParcela

O formulário recebe APENAS UM DADO:

ParcelaID (long)


📌 Todo o resto ele busca sozinho
📌 Nada de passar DTO gigante
📌 Nada de dependência do FrmFinanceiro

2️⃣ MÉTODOS USADOS NO LOAD DO FORM
🔹 2.1 Buscar dados da Parcela (Cabeçalho)
✔️ BLL
ParcelaBLL.BuscarPorId(long parcelaId)

✔️ DAL (interno à BLL)
ParcelaDAL.BuscarPorId(long parcelaId)

📌 Retorna (exemplo conceitual)

ParcelaID

VendaID

NumeroParcela

DataVencimento

ValorParcela

Juros

Multa

ValorRecebido

Status

DataPagamento

🔹 2.2 Buscar dados da Venda (para cabeçalho)
✔️ BLL
VendaBLL.ObterVendaPorId(int vendaId)


📌 Já existe e você usa no FrmFinanceiro

Usado para:

Nome do Cliente

Data da Venda

VendaID

🔹 2.3 Buscar Pagamentos da Parcela (Grid)
✔️ DAL (direto, como você já faz)
PagamentoParcialDal.ListarPagamentosPorParcelaCompleto(long parcelaId)


📌 Mesmo método que hoje você chama no:

dgvContasAReceber_SelectionChanged


📌 Não cria outro

3️⃣ MÉTODOS PARA AÇÕES DO RODAPÉ
🔹 3.1 Baixar Parcela
✔️ BLL
ParcelaBLL.BaixarParcelaParcial(...)
ou
ParcelaBLL.BaixarParcelasEmLote(...)


📌 No FrmDetalheParcela:

SEMPRE UMA PARCELA

SEMPRE chama o método unitário

📌 Regra:

Parcela não paga

Valor informado > 0

🔹 3.2 Estornar Pagamento
✔️ BLL
ParcelaBLL.EstornarPagamento(
    long parcelaId,
    decimal valor,
    string motivo
)


📌 Mesmo método que você já usa hoje
📌 Só muda o ponto de entrada (agora no detalhe)

🔹 3.3 Gerar Recibo
✔️ BLL
PagamentoBLL.ListarPagamentosPorParcela(long parcelaId)

✔️ PDF
PDFGenerator.GerarReciboPagamentos(...)


📌 Aqui o FrmDetalheParcela decide:

Recibo da parcela inteira

(sem checkbox, sem seleção confusa)

🔹 3.4 Gerar PDF Detalhado da Parcela
✔️ BLL
ExtratoBLL.ObterExtratoPorParcela(long parcelaId)

✔️ PDF
PDFGenerator.GerarExtratoPDF(...)


📌 Mesmo padrão de extrato que você já tem
📌 Apenas escopo menor (1 parcela)

4️⃣ MÉTODOS DE APOIO (internos do form)

Esses não são DAL/BLL, mas fazem parte do fluxo:

AtualizarResumoParcela()
AtualizarStatusVisual()
AtualizarEstadoBotoes()


📌 São métodos de UI, não de negócio
📌 Não duplicam regra — apenas refletem o estado

5️⃣ O QUE O FrmDetalheParcela NÃO PODE CHAMAR

❌ ContasAReceberDAL.ListarContasAReceber
❌ filtros
❌ pesquisa por período
❌ qualquer método de lista

📌 Ele trabalha sempre com 1 ParcelaID

6️⃣ MAPA FINAL (VISÃO RÁPIDA)
FrmDetalheParcela
│
├── ParcelaBLL.BuscarPorId
├── VendaBLL.ObterVendaPorId
├── PagamentoParcialDal.ListarPagamentosPorParcelaCompleto
│
├── ParcelaBLL.BaixarParcelaParcial
├── ParcelaBLL.EstornarPagamento
│
├── PagamentoBLL.ListarPagamentosPorParcela
├── ExtratoBLL.ObterExtratoPorParcela
│
└── PDFGenerator (Recibo / Extrato)

✅ RESULTADO

Você agora tem:
✔️ contrato claro
✔️ zero método duplicado
✔️ responsabilidades bem separadas
✔️ FrmFinanceiro limpo
✔️ FrmDetalheParcela poderoso e focado


🔄 FLUXO COMPLETO DE ABERTURA
FrmFinanceiro
   ↓
Usuário dá duplo clique na linha
   ↓
Valida CurrentRow
   ↓
Obtém ParcelaID
   ↓
Abre FrmDetalheParcela(ParcelaID)
   ↓
FrmDetalheParcela carrega:
   - Dados da parcela
   - Pagamentos
   - Status
   - Permissões de botão

   🔁 COMPORTAMENTO AO FECHAR O DETALHE
✔️ Regra padrão

Se nada foi alterado → fecha normal
Se houve baixa / estorno → retorna DialogResult.OK

✔️ FrmFinanceiro reage assim:
Se DialogResult.OK → CarregarContasAReceber()

Caso contrário → não faz nada
📌 Refresh somente quando necessário


