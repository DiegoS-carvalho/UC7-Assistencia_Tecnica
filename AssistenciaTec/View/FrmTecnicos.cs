using AssistenciaTec.Model;
using AssistenciaTec.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenciaTec.View
{
    public partial class FrmTecnicos : Form
    {
        private List<Tecnico> tecnicos = new List<Tecnico>();
        public FrmTecnicos()
        {
            InitializeComponent();
            DesabilitarBotoesCancelarSalvar();
            CarregarGridTecnicos();
        }



        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void CarregarGridTecnicos()
        {
            // Criar o repositório
            TecnicoRepository tecnicoRepository = new TecnicoRepository();

            // Obter a lista do repositório
            tecnicos = tecnicoRepository.ListarTodos();

            // Carregar o DatagridView com os dados
            DatagridViewTecnicos.Columns.Clear();
            DatagridViewTecnicos.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Código";
            colunaId.Width = 80;
            DatagridViewTecnicos.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do Tecnico";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatagridViewTecnicos.Columns.Add(colunaNome);

            // Informar de onde vem os dados da datagridview
            DatagridViewTecnicos.DataSource = tecnicos;

        }
        private void CarregarGridTecnicos(string nome)
        {
            // Criar o repositório
            TecnicoRepository tecnicoRepository = new TecnicoRepository();

            // Obter a lista do repositório
            tecnicos = tecnicoRepository.ListarPorNome(nome);

            // Carregar o DatagridView com os dados
            DatagridViewTecnicos.Columns.Clear();
            DatagridViewTecnicos.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Código";
            colunaId.Width = 80;
            DatagridViewTecnicos.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do Tecnico";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatagridViewTecnicos.Columns.Add(colunaNome);

            // Informar de onde vem os dados da datagridview
            DatagridViewTecnicos.DataSource = tecnicos;

        }
        private void DesabilitarBotoesCancelarSalvar()
        {
            toolStripButtonNovo.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonExcluir.Enabled = true;
            toolStripButtonSalvar.Enabled = false;
            toolStripButtonCancelar.Enabled = false;
            GroupBoxDadosCliente.Enabled = false;
        }

        private void HabilitarBotoesCancelarSalvar()
        {
            toolStripButtonNovo.Enabled = false;
            toolStripButtonEditar.Enabled = false;
            toolStripButtonExcluir.Enabled = false;
            toolStripButtonSalvar.Enabled = true;
            toolStripButtonCancelar.Enabled = true;
            GroupBoxDadosCliente.Enabled = true;
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            HabilitarBotoesCancelarSalvar();
            LimparCampos();
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtTelefone.Clear();
            LabelId.Text = "";
            TxtNome.Focus();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotoesCancelarSalvar();
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarBotoesCancelarSalvar();
        }


        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            // Criar um objeto Cliente
            Tecnico tecnico = new Tecnico();

            errorProvider1.Clear();
            limparControlesPreenchidos();

            try
            {
                tecnico.Nome = TxtNome.Text;
                tecnico.Telefone = TxtTelefone.Text;
                tecnico.Email = TxtEmail.Text;
                tecnico.Especialidade = TxtEndereco.Text;
            }
            catch (ArgumentException erro)
            {
                if (erro.ParamName == "Nome")
                {
                    errorProvider1.SetError(TxtNome, "Este campo é obrigatório");
                    TxtNome.BackColor = Color.Yellow;
                    LblErroNome.Visible = true;
                }
                else if (erro.ParamName == "Especialidade") // ou "Endereço", ajuste conforme o nome do parâmetro na sua exceção
                {
                    errorProvider1.SetError(TxtEndereco, "Este campo é obrigatório");
                    TxtEndereco.BackColor = Color.Yellow;
                    LblErroEndereco.Visible = true;
                }
                else if (erro.ParamName == "Email")
                {
                    errorProvider1.SetError(TxtEmail, "Este campo é obrigatório ou inválido");
                    TxtEmail.BackColor = Color.Yellow;
                    LblErroEmail.Visible = true;
                }
                else if (erro.ParamName == "Telefone")
                {
                    errorProvider1.SetError(TxtTelefone, "Este campo é obrigatório ou inválido");
                    TxtTelefone.BackColor = Color.Yellow;
                    LblErroTelefone.Visible = true;
                }

                return;
            }

            errorProvider1.Clear();

            // Criar um repositório de cliente
            TecnicoRepository tecnicoRepository = new TecnicoRepository();

            if (LabelId.Text == String.Empty)
            {
                var tecnicoId = tecnicoRepository.Salvar(tecnico);
                LabelId.Text = tecnicoId.ToString();
                MessageBox.Show(
                    "Tecnico criado com sucesso!",
                    "Cadastro de Tecnico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                tecnico.Id = int.Parse(LabelId.Text);
                tecnicoRepository.atualizar(tecnico);
                MessageBox.Show(
                    "Tecnico atualizado com sucesso!",
                    "Atualização de Tecnico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            DesabilitarBotoesCancelarSalvar();
            CarregarGridTecnicos();

        }

        private void limparControlesPreenchidos()
        {

            if (TxtNome.Text != String.Empty)
            {
                TxtNome.BackColor = Color.White;
                LblErroNome.Visible = false;
            }
        }
        private void DatagridViewTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirDetalhesDoCliente(e);
        }

        private void DatagridViewTecnicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            exibirDetalhesDoCliente(e);
        }

        private void exibirDetalhesDoCliente(DataGridViewCellEventArgs e)
        {
            var linha = e.RowIndex;

            if (linha == -1)
            {
                linha = 0;
            }

            // Recuperar os dados da linha que foi clicada
            var linhaSelecionada = DatagridViewTecnicos.Rows[linha];
            var tecnicoSelecionado = linhaSelecionada.DataBoundItem as Tecnico;

            LabelId.Text = tecnicoSelecionado.Id.ToString();
            TxtNome.Text = tecnicoSelecionado.Nome;
            TxtEmail.Text = tecnicoSelecionado.Email;
            TxtEndereco.Text = tecnicoSelecionado.Especialidade;
            TxtTelefone.Text = tecnicoSelecionado.Telefone;
        }

        private void toolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            // Confirmar se a exclusão deverá ocorrer
            var resposta = MessageBox.Show(
                "Confirma a exclusão do cliente selecionado?",
                "Exclusão de cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                var tecnicoRepository = new TecnicoRepository();
                var idSelecionado = int.Parse(LabelId.Text);

                var excluidos = tecnicoRepository.excluir(idSelecionado);

                if (excluidos > 0)
                {
                    MessageBox.Show(
                        "Cliente excluído com sucesso!",
                        "Exclusão de cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    CarregarGridTecnicos();
                    LimparCampos();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridTecnicos(TxtBuscarPorNome.Text);
        }
    }
}
