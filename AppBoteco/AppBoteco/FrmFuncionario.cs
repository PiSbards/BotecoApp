using AppBoteco.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AppBoteco
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> clientes = funcionario.listacliente();
            dgvFuncionario.DataSource = clientes;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCpf.Text == "" || mtxtCelular.Text == "")
            {
                MessageBox.Show("Por Favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Funcionario funcionario = new Funcionario();
                if (funcionario.RegistroRepetido(mtxtCpf.Text) == true)
                {
                    MessageBox.Show("Funcionário já cadastrado!", "Funcionário Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    mtxtCelular.Text = "";
                    mtxtCep.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtEndereco.Text = "";
                    cbxCargo.SelectedIndex = 0;
                    return;
                }
                else
                {
                    funcionario.Inserir(txtNome.Text, mtxtCpf.Text,txtEndereco.Text, string bairro, string cidade, mtxtCelular.Text, string cep, string cargo);
                    MessageBox.Show("Funcionário inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> funcionarios = funcionario.listacliente();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    mtxtCelular.Text = "";
                    mtxtCep.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtEndereco.Text = "";
                    cbxCargo.SelectedIndex = 0;
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor, digite um ID para localizar!", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario func = new Funcionario();
                func.Localizar(Id);
                txtNome.Text = func.nome;
                mtxtCelular.Text = func.celular;
                mtxtCpf.Text = func.cpf;
                mtxtCep.Text = func.cep;
                txtBairro.Text = func.bairro;
                txtCidade.Text = func.cidade;
                txtEndereco.Text = func.endereco;
                cbxCargo.Text = func.cargo;

                if (txtNome.Text != null)
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
