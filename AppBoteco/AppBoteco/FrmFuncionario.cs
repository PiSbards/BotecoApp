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
            List<Funcionario> func = funcionario.listacliente();
            dgvFuncionario.DataSource = func;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCpf.Text == "" || mtxtCelular.Text == "" || txtEndereco.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || mtxtCep.Text == ""|| cbxCargo.Text == "")
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
					txtComplemento.Text = "";
					cbxCargo.SelectedIndex = 0;
					return;
                }
                else
                {
                    funcionario.Inserir(txtNome.Text, mtxtCpf.Text,txtEndereco.Text,txtComplemento.Text,txtBairro.Text, txtCidade.Text, mtxtCelular.Text, mtxtCep.Text, cbxCargo.Text);
                    MessageBox.Show("Funcionário inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> func = funcionario.listacliente();
                    dgvFuncionario.DataSource = func;
					txtNome.Text = "";
					mtxtCpf.Text = "";
					mtxtCelular.Text = "";
					mtxtCep.Text = "";
					txtBairro.Text = "";
					txtCidade.Text = "";
					txtEndereco.Text = "";
					txtComplemento.Text = "";
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
                txtComplemento.Text = func.complemento;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Atualizar(Id,txtNome.Text,mtxtCpf.Text,txtEndereco.Text,txtComplemento.Text,txtBairro.Text,txtCidade.Text,mtxtCelular.Text,mtxtCep.Text,cbxCargo.Text);
                MessageBox.Show("Funcionário atualizado com sucesso!!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> func = funcionario.listacliente();
                dgvFuncionario.DataSource = func;
				txtNome.Text = "";
				mtxtCpf.Text = "";
				mtxtCelular.Text = "";
				mtxtCep.Text = "";
				txtBairro.Text = "";
				txtCidade.Text = "";
				txtEndereco.Text = "";
				txtComplemento.Text = "";
				cbxCargo.SelectedIndex = 0;
				this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Excluir(Id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> func = funcionario.listacliente();
                dgvFuncionario.DataSource = func;
                txtNome.Text = "";
                mtxtCpf.Text = "";
                mtxtCelular.Text = "";
                mtxtCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                cbxCargo.SelectedIndex = 0;
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                this.dgvFuncionario.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();

                mtxtCpf.Text = row.Cells[3].Value.ToString();

                txtEndereco.Text = row.Cells[4].Value.ToString();

                txtComplemento.Text = row.Cells[5].Value.ToString();

                txtBairro.Text = row.Cells[6].Value.ToString();

                txtCidade.Text = row.Cells[7].Value.ToString();

                mtxtCelular.Text = row.Cells[2].Value.ToString();

                mtxtCep.Text = row.Cells[8].Value.ToString();  
                
                cbxCargo.Text = row.Cells[9].Value.ToString();
                
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

		private void btnBuscaCep_Click(object sender, EventArgs e)
		{
            BuscaCEP cEP = new BuscaCEP();
            cEP.buscaCep(mtxtCep.Text);
			txtBairro.Text = cEP.bairro;
			txtCidade.Text = cEP.cidade;
			txtEndereco.Text = cEP.endereco;
			txtComplemento.Text = cEP.complemento;

		}
	}
}
