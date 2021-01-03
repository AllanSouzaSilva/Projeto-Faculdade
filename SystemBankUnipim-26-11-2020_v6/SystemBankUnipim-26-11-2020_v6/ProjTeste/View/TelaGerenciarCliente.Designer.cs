namespace SystemBankUnipim
{
    partial class TelaGerenciarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenciarCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.textBoxCPFCNPJ = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelDados = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.buttonFinalizarCadastro = new System.Windows.Forms.Button();
            this.LabelDataNasc = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelCadastrarClientes = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCadastrar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 161);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.AutoSize = true;
            this.panelCadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCadastrar.Controls.Add(this.textBoxCPFCNPJ);
            this.panelCadastrar.Controls.Add(this.labelUsuario);
            this.panelCadastrar.Controls.Add(this.textBoxEmail);
            this.panelCadastrar.Controls.Add(this.labelTelefone);
            this.panelCadastrar.Controls.Add(this.labelCliente);
            this.panelCadastrar.Controls.Add(this.labelDados);
            this.panelCadastrar.Controls.Add(this.labelSenha);
            this.panelCadastrar.Controls.Add(this.textBoxSenha);
            this.panelCadastrar.Controls.Add(this.labelTel);
            this.panelCadastrar.Controls.Add(this.textBoxTel);
            this.panelCadastrar.Controls.Add(this.textBoxDataNascimento);
            this.panelCadastrar.Controls.Add(this.buttonFinalizarCadastro);
            this.panelCadastrar.Controls.Add(this.LabelDataNasc);
            this.panelCadastrar.Controls.Add(this.labelEmail);
            this.panelCadastrar.Controls.Add(this.labelCPFCNPJ);
            this.panelCadastrar.Controls.Add(this.labelNomeCliente);
            this.panelCadastrar.Controls.Add(this.textBoxNomeCliente);
            this.panelCadastrar.Controls.Add(this.labelCadastrarClientes);
            this.panelCadastrar.Location = new System.Drawing.Point(216, 204);
            this.panelCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(793, 398);
            this.panelCadastrar.TabIndex = 10;
            // 
            // textBoxCPFCNPJ
            // 
            this.textBoxCPFCNPJ.AcceptsTab = true;
            this.textBoxCPFCNPJ.Location = new System.Drawing.Point(140, 183);
            this.textBoxCPFCNPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCPFCNPJ.Name = "textBoxCPFCNPJ";
            this.textBoxCPFCNPJ.Size = new System.Drawing.Size(161, 22);
            this.textBoxCPFCNPJ.TabIndex = 27;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelUsuario.Location = new System.Drawing.Point(472, 110);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(114, 21);
            this.labelUsuario.TabIndex = 26;
            this.labelUsuario.Text = "Email de Usuário";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AcceptsTab = true;
            this.textBoxEmail.Location = new System.Drawing.Point(472, 132);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(132, 22);
            this.textBoxEmail.TabIndex = 25;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelTelefone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTelefone.Location = new System.Drawing.Point(139, 265);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(63, 21);
            this.labelTelefone.TabIndex = 22;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.labelCliente.Location = new System.Drawing.Point(135, 91);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(128, 24);
            this.labelCliente.TabIndex = 16;
            this.labelCliente.Text = "Dados do Cliente";
            // 
            // labelDados
            // 
            this.labelDados.AutoSize = true;
            this.labelDados.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDados.Location = new System.Drawing.Point(467, 91);
            this.labelDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(117, 24);
            this.labelDados.TabIndex = 15;
            this.labelDados.Text = "Dados de Login";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSenha.Location = new System.Drawing.Point(473, 160);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(48, 21);
            this.labelSenha.TabIndex = 14;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.AcceptsTab = true;
            this.textBoxSenha.Location = new System.Drawing.Point(472, 183);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(132, 22);
            this.textBoxSenha.TabIndex = 13;
            // 
            // labelTel
            // 
            this.labelTel.Location = new System.Drawing.Point(15, 215);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(100, 23);
            this.labelTel.TabIndex = 19;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(140, 287);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(132, 22);
            this.textBoxTel.TabIndex = 9;
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Location = new System.Drawing.Point(140, 233);
            this.textBoxDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDataNascimento.Mask = "  00/00/0000";
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(100, 22);
            this.textBoxDataNascimento.TabIndex = 6;
            // 
            // buttonFinalizarCadastro
            // 
            this.buttonFinalizarCadastro.BackColor = System.Drawing.Color.Red;
            this.buttonFinalizarCadastro.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonFinalizarCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonFinalizarCadastro.Location = new System.Drawing.Point(496, 279);
            this.buttonFinalizarCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFinalizarCadastro.Name = "buttonFinalizarCadastro";
            this.buttonFinalizarCadastro.Size = new System.Drawing.Size(91, 32);
            this.buttonFinalizarCadastro.TabIndex = 5;
            this.buttonFinalizarCadastro.Text = "Cadastrar";
            this.buttonFinalizarCadastro.UseVisualStyleBackColor = false;
            this.buttonFinalizarCadastro.Click += new System.EventHandler(this.ButtonFinalizarCadastro_Click);
            // 
            // LabelDataNasc
            // 
            this.LabelDataNasc.AutoSize = true;
            this.LabelDataNasc.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDataNasc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelDataNasc.Location = new System.Drawing.Point(136, 208);
            this.LabelDataNasc.Name = "LabelDataNasc";
            this.LabelDataNasc.Size = new System.Drawing.Size(132, 21);
            this.LabelDataNasc.TabIndex = 4;
            this.LabelDataNasc.Text = "Data de Nascimento";
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(15, 164);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 23);
            this.labelEmail.TabIndex = 21;
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelCPFCNPJ.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(136, 159);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(71, 21);
            this.labelCPFCNPJ.TabIndex = 4;
            this.labelCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelNomeCliente.Location = new System.Drawing.Point(136, 107);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(49, 21);
            this.labelNomeCliente.TabIndex = 4;
            this.labelNomeCliente.Text = "Nome ";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.AcceptsTab = true;
            this.textBoxNomeCliente.Location = new System.Drawing.Point(140, 132);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(264, 22);
            this.textBoxNomeCliente.TabIndex = 3;
            // 
            // labelCadastrarClientes
            // 
            this.labelCadastrarClientes.AutoSize = true;
            this.labelCadastrarClientes.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelCadastrarClientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCadastrarClientes.Location = new System.Drawing.Point(13, 9);
            this.labelCadastrarClientes.Name = "labelCadastrarClientes";
            this.labelCadastrarClientes.Size = new System.Drawing.Size(154, 29);
            this.labelCadastrarClientes.TabIndex = 0;
            this.labelCadastrarClientes.Text = "Cadastrar Cliente";
            // 
            // buttonCompraVenda
            // 
            this.buttonCompraVenda.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompraVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCompraVenda.Location = new System.Drawing.Point(535, 153);
            this.buttonCompraVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCompraVenda.Name = "buttonCompraVenda";
            this.buttonCompraVenda.Size = new System.Drawing.Size(183, 36);
            this.buttonCompraVenda.TabIndex = 33;
            this.buttonCompraVenda.Text = "COMPRA/VENDA";
            this.buttonCompraVenda.UseVisualStyleBackColor = true;
            this.buttonCompraVenda.Click += new System.EventHandler(this.buttonCompraVenda_Click);
            // 
            // buttonTransacoes
            // 
            this.buttonTransacoes.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTransacoes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTransacoes.Location = new System.Drawing.Point(707, 153);
            this.buttonTransacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransacoes.Name = "buttonTransacoes";
            this.buttonTransacoes.Size = new System.Drawing.Size(183, 36);
            this.buttonTransacoes.TabIndex = 34;
            this.buttonTransacoes.Text = "TRANSAÇÕES";
            this.buttonTransacoes.UseVisualStyleBackColor = true;
            this.buttonTransacoes.Click += new System.EventHandler(this.buttonTransacoes_Click);
            // 
            // buttonRelatorios
            // 
            this.buttonRelatorios.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRelatorios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRelatorios.Location = new System.Drawing.Point(880, 153);
            this.buttonRelatorios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRelatorios.Name = "buttonRelatorios";
            this.buttonRelatorios.Size = new System.Drawing.Size(183, 36);
            this.buttonRelatorios.TabIndex = 35;
            this.buttonRelatorios.Text = "RELATÓRIOS";
            this.buttonRelatorios.UseVisualStyleBackColor = true;
            this.buttonRelatorios.Click += new System.EventHandler(this.buttonRelatorios_Click);
            // 
            // buttonCarteiras
            // 
            this.buttonCarteiras.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCarteiras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCarteiras.Location = new System.Drawing.Point(356, 153);
            this.buttonCarteiras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCarteiras.Name = "buttonCarteiras";
            this.buttonCarteiras.Size = new System.Drawing.Size(183, 36);
            this.buttonCarteiras.TabIndex = 36;
            this.buttonCarteiras.Text = "CARTEIRAS";
            this.buttonCarteiras.UseVisualStyleBackColor = true;
            this.buttonCarteiras.Click += new System.EventHandler(this.buttonCarteiras_Click);
            // 
            // buttonGerenciarMercado
            // 
            this.buttonGerenciarMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGerenciarMercado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGerenciarMercado.Location = new System.Drawing.Point(177, 153);
            this.buttonGerenciarMercado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGerenciarMercado.Name = "buttonGerenciarMercado";
            this.buttonGerenciarMercado.Size = new System.Drawing.Size(183, 36);
            this.buttonGerenciarMercado.TabIndex = 37;
            this.buttonGerenciarMercado.Text = "GERENCIAR MERCADO";
            this.buttonGerenciarMercado.UseVisualStyleBackColor = true;
            this.buttonGerenciarMercado.Click += new System.EventHandler(this.buttonGerenciarMercado_Click);
            // 
            // buttonMercado
            // 
            this.buttonMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMercado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMercado.Location = new System.Drawing.Point(-1, 153);
            this.buttonMercado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMercado.Name = "buttonMercado";
            this.buttonMercado.Size = new System.Drawing.Size(183, 36);
            this.buttonMercado.TabIndex = 38;
            this.buttonMercado.Text = "MERCADO";
            this.buttonMercado.UseVisualStyleBackColor = true;
            this.buttonMercado.Click += new System.EventHandler(this.buttonMercado_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.buttonEditarCadastro);
            this.panel1.Controls.Add(this.buttonCadastrarCliente);
            this.panel1.Controls.Add(this.labelGerenciarCliente);
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 326);
            this.panel1.TabIndex = 39;
            // 
            // buttonEditarCadastro
            // 
            this.buttonEditarCadastro.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonEditarCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditarCadastro.Location = new System.Drawing.Point(23, 126);
            this.buttonEditarCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarCadastro.Name = "buttonEditarCadastro";
            this.buttonEditarCadastro.Size = new System.Drawing.Size(111, 30);
            this.buttonEditarCadastro.TabIndex = 1;
            this.buttonEditarCadastro.Text = "Editar ";
            this.buttonEditarCadastro.UseVisualStyleBackColor = true;
            this.buttonEditarCadastro.Click += new System.EventHandler(this.buttonEditarCadastro_Click);
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonCadastrarCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(23, 79);
            this.buttonCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(111, 30);
            this.buttonCadastrarCliente.TabIndex = 1;
            this.buttonCadastrarCliente.Text = "Cadastrar";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.buttonCadastrarCliente_Click_1);
            // 
            // labelGerenciarCliente
            // 
            this.labelGerenciarCliente.AutoSize = true;
            this.labelGerenciarCliente.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelGerenciarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGerenciarCliente.Location = new System.Drawing.Point(27, 32);
            this.labelGerenciarCliente.Name = "labelGerenciarCliente";
            this.labelGerenciarCliente.Size = new System.Drawing.Size(93, 29);
            this.labelGerenciarCliente.TabIndex = 0;
            this.labelGerenciarCliente.Text = "Gerenciar";
            // 
            // TelaGerenciarCliente
            // 
            this.AcceptButton = this.buttonFinalizarCadastro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1061, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCompraVenda);
            this.Controls.Add(this.buttonTransacoes);
            this.Controls.Add(this.buttonRelatorios);
            this.Controls.Add(this.buttonCarteiras);
            this.Controls.Add(this.buttonGerenciarMercado);
            this.Controls.Add(this.buttonMercado);
            this.Controls.Add(this.panelCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaGerenciarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEMBANK-Cadastrar Cliente";
            this.Load += new System.EventHandler(this.TelaGerenciarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.Label labelCadastrarClientes;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Button buttonFinalizarCadastro;
        private System.Windows.Forms.Label LabelDataNasc;
        private System.Windows.Forms.MaskedTextBox textBoxDataNascimento;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonCompraVenda;
        private System.Windows.Forms.Button buttonTransacoes;
        private System.Windows.Forms.Button buttonRelatorios;
        private System.Windows.Forms.Button buttonCarteiras;
        private System.Windows.Forms.Button buttonGerenciarMercado;
        private System.Windows.Forms.Button buttonMercado;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEditarCadastro;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.Label labelGerenciarCliente;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCPFCNPJ;
    }
}