using AppBoteco.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBoteco
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            List<Produto> pro = produto.listacliente();
            dgvProduto.DataSource = pro;
            cbxTipo.SelectedIndex = 0;
			btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cbxTipo.Text == "" || txtQuantidade.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Por Favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                Produto produto = new Produto();
                produto.Inserir(txtNome.Text, cbxTipo.Text, quantidade, txtPreco.Text);
                MessageBox.Show("Produto inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> pro = produto.listacliente();
                dgvProduto.DataSource = pro;
                txtNome.Text = "";
				cbxTipo.SelectedIndex = 0;
				txtQuantidade.Text = "";
                txtPreco.Text = "";
                this.txtNome.Focus();
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
                int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                Produto pro = new Produto();
                pro.Atualizar(Id, txtNome.Text, cbxTipo.Text, quantidade, txtPreco.Text);
                MessageBox.Show("Produto atualizado com sucesso!!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produto = pro.listacliente();
                dgvProduto.DataSource = produto;
                txtNome.Text = "";
				cbxTipo.SelectedIndex = 0;
				txtQuantidade.Text = "";
                txtPreco.Text = "";
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor, digite um ID para localizar!", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Produto pro = new Produto();
                pro.Localizar(Id);
                txtNome.Text = pro.nome;
                cbxTipo.Text = pro.tipo;
                txtQuantidade.Text = pro.quantidade.ToString();
                txtPreco.Text = pro.preco.ToString();

                if (txtNome.Text != null)
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				int Id = Convert.ToInt32(txtId.Text.Trim());
				Produto produtos = new Produto();
				produtos.Excluir(Id);
				MessageBox.Show("Produto excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
				List<Produto> pro = produtos.listacliente();
				dgvProduto.DataSource = pro;
				txtNome.Text = "";
				cbxTipo.SelectedIndex = 0;
				txtQuantidade.Text = "";
				txtPreco.Text = "";
				this.ActiveControl = txtNome;
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
				this.dgvProduto.Rows[e.RowIndex].Selected = true;
				txtId.Text = row.Cells[0].Value.ToString();
				txtNome.Text = row.Cells[1].Value.ToString();
				cbxTipo.Text = row.Cells[2].Value.ToString();
                txtQuantidade.Text = row.Cells[3].Value.ToString();
				txtPreco.Text = row.Cells[4].Value.ToString();
			}
			btnEditar.Enabled = true;
			btnExcluir.Enabled = true;
		}
	} 
}
