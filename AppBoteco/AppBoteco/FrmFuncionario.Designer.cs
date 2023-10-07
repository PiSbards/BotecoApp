namespace AppBoteco
{
    partial class FrmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvFuncionario = new System.Windows.Forms.DataGridView();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInserir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.cbxCargo = new System.Windows.Forms.ComboBox();
			this.btnBuscaCep = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.Color.Snow;
			this.btnLocalizar.BackgroundImage = global::AppBoteco.Properties.Resources.busca;
			this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLocalizar.FlatAppearance.BorderSize = 0;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Location = new System.Drawing.Point(155, 10);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(118, 78);
			this.btnLocalizar.TabIndex = 21;
			this.btnLocalizar.UseVisualStyleBackColor = false;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.Red;
			this.btnFechar.FlatAppearance.BorderSize = 0;
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.ForeColor = System.Drawing.Color.White;
			this.btnFechar.Location = new System.Drawing.Point(705, 229);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(193, 46);
			this.btnFechar.TabIndex = 19;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Maroon;
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Location = new System.Drawing.Point(705, 163);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(193, 46);
			this.btnExcluir.TabIndex = 18;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Brown;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Location = new System.Drawing.Point(705, 90);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(193, 46);
			this.btnEditar.TabIndex = 16;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(31, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 15);
			this.label4.TabIndex = 23;
			this.label4.Text = "CELULAR";
			// 
			// mtxtCelular
			// 
			this.mtxtCelular.Location = new System.Drawing.Point(34, 229);
			this.mtxtCelular.Mask = "(99)99999-9999";
			this.mtxtCelular.Name = "mtxtCelular";
			this.mtxtCelular.Size = new System.Drawing.Size(224, 20);
			this.mtxtCelular.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 15);
			this.label3.TabIndex = 22;
			this.label3.Text = "CPF";
			// 
			// dgvFuncionario
			// 
			this.dgvFuncionario.AllowUserToAddRows = false;
			this.dgvFuncionario.AllowUserToDeleteRows = false;
			this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionario.Location = new System.Drawing.Point(12, 356);
			this.dgvFuncionario.Name = "dgvFuncionario";
			this.dgvFuncionario.ReadOnly = true;
			this.dgvFuncionario.Size = new System.Drawing.Size(903, 263);
			this.dgvFuncionario.TabIndex = 20;
			this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(34, 109);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(323, 20);
			this.txtNome.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 17;
			this.label2.Text = "NOME";
			// 
			// mtxtCpf
			// 
			this.mtxtCpf.Location = new System.Drawing.Point(34, 166);
			this.mtxtCpf.Mask = "000,000,000-00";
			this.mtxtCpf.Name = "mtxtCpf";
			this.mtxtCpf.Size = new System.Drawing.Size(224, 20);
			this.mtxtCpf.TabIndex = 11;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(34, 34);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID";
			// 
			// btnInserir
			// 
			this.btnInserir.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnInserir.FlatAppearance.BorderSize = 0;
			this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.ForeColor = System.Drawing.Color.White;
			this.btnInserir.Location = new System.Drawing.Point(705, 16);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(193, 46);
			this.btnInserir.TabIndex = 15;
			this.btnInserir.Text = "INSERIR";
			this.btnInserir.UseVisualStyleBackColor = false;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(387, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 15);
			this.label5.TabIndex = 25;
			this.label5.Text = "CEP";
			// 
			// mtxtCep
			// 
			this.mtxtCep.Location = new System.Drawing.Point(390, 90);
			this.mtxtCep.Mask = "99999-999";
			this.mtxtCep.Name = "mtxtCep";
			this.mtxtCep.Size = new System.Drawing.Size(109, 20);
			this.mtxtCep.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(387, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 15);
			this.label6.TabIndex = 27;
			this.label6.Text = "ENDEREÇO";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(387, 249);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 15);
			this.label7.TabIndex = 29;
			this.label7.Text = "BAIRRO";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(387, 312);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 15);
			this.label8.TabIndex = 31;
			this.label8.Text = "CIDADE";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(31, 277);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 15);
			this.label9.TabIndex = 33;
			this.label9.Text = "CARGO";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(390, 147);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(260, 20);
			this.txtEndereco.TabIndex = 34;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(390, 267);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(146, 20);
			this.txtBairro.TabIndex = 35;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(390, 330);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(165, 20);
			this.txtCidade.TabIndex = 36;
			// 
			// cbxCargo
			// 
			this.cbxCargo.FormattingEnabled = true;
			this.cbxCargo.Items.AddRange(new object[] {
            "Gerente",
            "Caixa",
            "Garçom",
            "Segurança",
            "Cozinheiro"});
			this.cbxCargo.Location = new System.Drawing.Point(34, 295);
			this.cbxCargo.Name = "cbxCargo";
			this.cbxCargo.Size = new System.Drawing.Size(171, 21);
			this.cbxCargo.TabIndex = 38;
			// 
			// btnBuscaCep
			// 
			this.btnBuscaCep.BackColor = System.Drawing.Color.Transparent;
			this.btnBuscaCep.BackgroundImage = global::AppBoteco.Properties.Resources.cep;
			this.btnBuscaCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBuscaCep.FlatAppearance.BorderSize = 0;
			this.btnBuscaCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscaCep.Location = new System.Drawing.Point(513, 58);
			this.btnBuscaCep.Name = "btnBuscaCep";
			this.btnBuscaCep.Size = new System.Drawing.Size(137, 78);
			this.btnBuscaCep.TabIndex = 39;
			this.btnBuscaCep.UseVisualStyleBackColor = false;
			this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(387, 193);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 16);
			this.label10.TabIndex = 40;
			this.label10.Text = "COMPLEMENTO";
			// 
			// txtComplemento
			// 
			this.txtComplemento.Location = new System.Drawing.Point(390, 210);
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(119, 20);
			this.txtComplemento.TabIndex = 41;
			// 
			// FrmFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(925, 631);
			this.Controls.Add(this.txtComplemento);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnBuscaCep);
			this.Controls.Add(this.cbxCargo);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.mtxtCep);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mtxtCelular);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvFuncionario);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mtxtCpf);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnInserir);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmFuncionario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmFuncionario";
			this.Load += new System.EventHandler(this.FrmFuncionario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Button btnBuscaCep;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtComplemento;
	}
}