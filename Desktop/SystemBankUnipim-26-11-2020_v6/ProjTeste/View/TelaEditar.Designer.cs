namespace ProjTeste.View
{
    partial class TelaEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCompraVenda = new System.Windows.Forms.Button();
            this.buttonTransacoes = new System.Windows.Forms.Button();
            this.buttonRelatorios = new System.Windows.Forms.Button();
            this.buttonCarteiras = new System.Windows.Forms.Button();
            this.buttonGerenciarMercado = new System.Windows.Forms.Button();
            this.buttonMercado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditarCadastro = new System.Windows.Forms.Button();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.labelGerenciarCliente = new System.Windows.Forms.Label();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.LabelDataNasc = new System.Windows.Forms.Label();
            this.textBoxCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelEditar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 131);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCompraVenda
            // 
            this.buttonCompraVenda.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompraVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCompraVenda.Location = new System.Drawing.Point(401, 124);
            this.buttonCompraVenda.Name = "buttonCompraVenda";
            this.buttonCompraVenda.Size = new System.Drawing.Size(137, 29);
            this.buttonCompraVenda.TabIndex = 15;
            this.buttonCompraVenda.Text = "COMPRA/VENDA";
            this.buttonCompraVenda.UseVisualStyleBackColor = true;
            this.buttonCompraVenda.Click += new System.EventHandler(this.buttonCompraVenda_Click);
            // 
            // buttonTransacoes
            // 
            this.buttonTransacoes.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTransacoes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTransacoes.Location = new System.Drawing.Point(530, 124);
            this.buttonTransacoes.Name = "buttonTransacoes";
            this.buttonTransacoes.Size = new System.Drawing.Size(137, 29);
            this.buttonTransacoes.TabIndex = 16;
            this.buttonTransacoes.Text = "TRANSAÇÕES";
            this.buttonTransacoes.UseVisualStyleBackColor = true;
            this.buttonTransacoes.Click += new System.EventHandler(this.buttonTransacoes_Click);
            // 
            // buttonRelatorios
            // 
            this.buttonRelatorios.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRelatorios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRelatorios.Location = new System.Drawing.Point(660, 124);
            this.buttonRelatorios.Name = "buttonRelatorios";
            this.buttonRelatorios.Size = new System.Drawing.Size(137, 29);
            this.buttonRelatorios.TabIndex = 17;
            this.buttonRelatorios.Text = "RELATÓRIOS";
            this.buttonRelatorios.UseVisualStyleBackColor = true;
            this.buttonRelatorios.Click += new System.EventHandler(this.buttonRelatorios_Click);
            // 
            // buttonCarteiras
            // 
            this.buttonCarteiras.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCarteiras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCarteiras.Location = new System.Drawing.Point(267, 124);
            this.buttonCarteiras.Name = "buttonCarteiras";
            this.buttonCarteiras.Size = new System.Drawing.Size(137, 29);
            this.buttonCarteiras.TabIndex = 18;
            this.buttonCarteiras.Text = "CARTEIRAS";
            this.buttonCarteiras.UseVisualStyleBackColor = true;
            this.buttonCarteiras.Click += new System.EventHandler(this.buttonCarteiras_Click);
            // 
            // buttonGerenciarMercado
            // 
            this.buttonGerenciarMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGerenciarMercado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGerenciarMercado.Location = new System.Drawing.Point(133, 124);
            this.buttonGerenciarMercado.Name = "buttonGerenciarMercado";
            this.buttonGerenciarMercado.Size = new System.Drawing.Size(137, 29);
            this.buttonGerenciarMercado.TabIndex = 19;
            this.buttonGerenciarMercado.Text = "GERENCIAR MERCADO";
            this.buttonGerenciarMercado.UseVisualStyleBackColor = true;
            this.buttonGerenciarMercado.Click += new System.EventHandler(this.buttonGerenciarMercado_Click);
            // 
            // buttonMercado
            // 
            this.buttonMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMercado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMercado.Location = new System.Drawing.Point(-1, 124);
            this.buttonMercado.Name = "buttonMercado";
            this.buttonMercado.Size = new System.Drawing.Size(137, 29);
            this.buttonMercado.TabIndex = 20;
            this.buttonMercado.Text = "MERCADO";
            this.buttonMercado.UseVisualStyleBackColor = true;
            this.buttonMercado.Click += new System.EventHandler(this.buttonMercado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.buttonEditarCadastro);
            this.panel1.Controls.Add(this.buttonCadastrarCliente);
            this.panel1.Controls.Add(this.labelGerenciarCliente);
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 265);
            this.panel1.TabIndex = 21;
            // 
            // buttonEditarCadastro
            // 
            this.buttonEditarCadastro.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonEditarCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditarCadastro.Location = new System.Drawing.Point(17, 110);
            this.buttonEditarCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarCadastro.Name = "buttonEditarCadastro";
            this.buttonEditarCadastro.Size = new System.Drawing.Size(83, 24);
            this.buttonEditarCadastro.TabIndex = 1;
            this.buttonEditarCadastro.Text = "Editar ";
            this.buttonEditarCadastro.UseVisualStyleBackColor = true;
            this.buttonEditarCadastro.Click += new System.EventHandler(this.buttonEditarCadastro_Click);
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonCadastrarCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(17, 64);
            this.buttonCadastrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(83, 24);
            this.buttonCadastrarCliente.TabIndex = 1;
            this.buttonCadastrarCliente.Text = "Cadastrar";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.buttonCadastrarCliente_Click);
            // 
            // labelGerenciarCliente
            // 
            this.labelGerenciarCliente.AutoSize = true;
            this.labelGerenciarCliente.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelGerenciarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGerenciarCliente.Location = new System.Drawing.Point(20, 26);
            this.labelGerenciarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGerenciarCliente.Name = "labelGerenciarCliente";
            this.labelGerenciarCliente.Size = new System.Drawing.Size(74, 23);
            this.labelGerenciarCliente.TabIndex = 0;
            this.labelGerenciarCliente.Text = "Gerenciar";
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCadastrar.Controls.Add(this.buttonExcluir);
            this.panelCadastrar.Controls.Add(this.buttonAlterar);
            this.panelCadastrar.Controls.Add(this.labelSenha);
            this.panelCadastrar.Controls.Add(this.textBoxSenha);
            this.panelCadastrar.Controls.Add(this.textBoxEmail);
            this.panelCadastrar.Controls.Add(this.labelEmail);
            this.panelCadastrar.Controls.Add(this.labelTel);
            this.panelCadastrar.Controls.Add(this.textBoxTel);
            this.panelCadastrar.Controls.Add(this.textBoxDataNascimento);
            this.panelCadastrar.Controls.Add(this.LabelDataNasc);
            this.panelCadastrar.Controls.Add(this.textBoxCPFCNPJ);
            this.panelCadastrar.Controls.Add(this.labelCPFCNPJ);
            this.panelCadastrar.Controls.Add(this.labelNomeCliente);
            this.panelCadastrar.Controls.Add(this.textBoxNomeCliente);
            this.panelCadastrar.Controls.Add(this.dataGridView1);
            this.panelCadastrar.Controls.Add(this.labelEditar);
            this.panelCadastrar.Location = new System.Drawing.Point(146, 166);
            this.panelCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(595, 323);
            this.panelCadastrar.TabIndex = 22;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Coral;
            this.buttonExcluir.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(446, 263);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 30);
            this.buttonExcluir.TabIndex = 23;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.Coral;
            this.buttonAlterar.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonAlterar.ForeColor = System.Drawing.Color.White;
            this.buttonAlterar.Location = new System.Drawing.Point(359, 263);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 30);
            this.buttonAlterar.TabIndex = 22;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSenha.Location = new System.Drawing.Point(282, 222);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 18);
            this.labelSenha.TabIndex = 19;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(335, 222);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(333, 196);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(158, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEmail.Location = new System.Drawing.Point(283, 196);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 18);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelTel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTel.Location = new System.Drawing.Point(16, 270);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 18);
            this.labelTel.TabIndex = 13;
            this.labelTel.Text = "Telefone";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(77, 270);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel.TabIndex = 12;
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Location = new System.Drawing.Point(132, 242);
            this.textBoxDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDataNascimento.Mask = "  00/00/0000";
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(76, 20);
            this.textBoxDataNascimento.TabIndex = 11;
            // 
            // LabelDataNasc
            // 
            this.LabelDataNasc.AutoSize = true;
            this.LabelDataNasc.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDataNasc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelDataNasc.Location = new System.Drawing.Point(16, 243);
            this.LabelDataNasc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDataNasc.Name = "LabelDataNasc";
            this.LabelDataNasc.Size = new System.Drawing.Size(108, 18);
            this.LabelDataNasc.TabIndex = 10;
            this.LabelDataNasc.Text = "Data de Nascimento";
            // 
            // textBoxCPFCNPJ
            // 
            this.textBoxCPFCNPJ.Location = new System.Drawing.Point(77, 218);
            this.textBoxCPFCNPJ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCPFCNPJ.Name = "textBoxCPFCNPJ";
            this.textBoxCPFCNPJ.Size = new System.Drawing.Size(131, 20);
            this.textBoxCPFCNPJ.TabIndex = 9;
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelCPFCNPJ.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(16, 218);
            this.labelCPFCNPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(57, 18);
            this.labelCPFCNPJ.TabIndex = 8;
            this.labelCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelNomeCliente.Location = new System.Drawing.Point(16, 196);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(40, 18);
            this.labelNomeCliente.TabIndex = 6;
            this.labelNomeCliente.Text = "Nome ";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(77, 196);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(131, 20);
            this.textBoxNomeCliente.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 152);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelEditar
            // 
            this.labelEditar.AutoSize = true;
            this.labelEditar.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelEditar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEditar.Location = new System.Drawing.Point(10, 7);
            this.labelEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditar.Name = "labelEditar";
            this.labelEditar.Size = new System.Drawing.Size(119, 23);
            this.labelEditar.TabIndex = 0;
            this.labelEditar.Text = "Editar Cadastros";
            // 
            // TelaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.panelCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCompraVenda);
            this.Controls.Add(this.buttonTransacoes);
            this.Controls.Add(this.buttonRelatorios);
            this.Controls.Add(this.buttonCarteiras);
            this.Controls.Add(this.buttonGerenciarMercado);
            this.Controls.Add(this.buttonMercado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEMBANK-Editar";
            this.Load += new System.EventHandler(this.TelaEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCompraVenda;
        private System.Windows.Forms.Button buttonTransacoes;
        private System.Windows.Forms.Button buttonRelatorios;
        private System.Windows.Forms.Button buttonCarteiras;
        private System.Windows.Forms.Button buttonGerenciarMercado;
        private System.Windows.Forms.Button buttonMercado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEditarCadastro;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.Label labelGerenciarCliente;
        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEditar;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.MaskedTextBox textBoxCPFCNPJ;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox textBoxDataNascimento;
        private System.Windows.Forms.Label LabelDataNasc;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
    }
}