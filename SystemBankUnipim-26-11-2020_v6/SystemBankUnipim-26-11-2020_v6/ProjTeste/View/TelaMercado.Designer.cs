namespace SystemBankUnipim
{
    partial class TelaMercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMercado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLitecoin = new System.Windows.Forms.Button();
            this.buttonEtherum = new System.Windows.Forms.Button();
            this.buttonBitcoin = new System.Windows.Forms.Button();
            this.buttonMercadoGeral = new System.Windows.Forms.Button();
            this.labelMercado = new System.Windows.Forms.Label();
            this.buttonCompraVenda = new System.Windows.Forms.Button();
            this.buttonTransacoes = new System.Windows.Forms.Button();
            this.buttonRelatorios = new System.Windows.Forms.Button();
            this.buttonCarteiras = new System.Windows.Forms.Button();
            this.buttonGerenciarMercado = new System.Windows.Forms.Button();
            this.buttonMercado = new System.Windows.Forms.Button();
            this.panelMercado = new System.Windows.Forms.Panel();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoeda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCalcularFracao = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMercado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMercado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 131);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.buttonLitecoin);
            this.panel1.Controls.Add(this.buttonEtherum);
            this.panel1.Controls.Add(this.buttonBitcoin);
            this.panel1.Controls.Add(this.buttonMercadoGeral);
            this.panel1.Controls.Add(this.labelMercado);
            this.panel1.Location = new System.Drawing.Point(-1, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 265);
            this.panel1.TabIndex = 9;
            // 
            // buttonLitecoin
            // 
            this.buttonLitecoin.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonLitecoin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLitecoin.Location = new System.Drawing.Point(17, 185);
            this.buttonLitecoin.Name = "buttonLitecoin";
            this.buttonLitecoin.Size = new System.Drawing.Size(83, 23);
            this.buttonLitecoin.TabIndex = 1;
            this.buttonLitecoin.Text = "LITECOIN";
            this.buttonLitecoin.UseVisualStyleBackColor = true;
            this.buttonLitecoin.Click += new System.EventHandler(this.buttonEOS_Click);
            // 
            // buttonEtherum
            // 
            this.buttonEtherum.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonEtherum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEtherum.Location = new System.Drawing.Point(17, 145);
            this.buttonEtherum.Name = "buttonEtherum";
            this.buttonEtherum.Size = new System.Drawing.Size(83, 23);
            this.buttonEtherum.TabIndex = 1;
            this.buttonEtherum.Text = "ETHERUM";
            this.buttonEtherum.UseVisualStyleBackColor = true;
            this.buttonEtherum.Click += new System.EventHandler(this.buttonEtherum_Click);
            // 
            // buttonBitcoin
            // 
            this.buttonBitcoin.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonBitcoin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBitcoin.Location = new System.Drawing.Point(17, 105);
            this.buttonBitcoin.Name = "buttonBitcoin";
            this.buttonBitcoin.Size = new System.Drawing.Size(83, 23);
            this.buttonBitcoin.TabIndex = 1;
            this.buttonBitcoin.Text = "BITCOIN";
            this.buttonBitcoin.UseVisualStyleBackColor = true;
            this.buttonBitcoin.Click += new System.EventHandler(this.buttonBitcoin_Click);
            // 
            // buttonMercadoGeral
            // 
            this.buttonMercadoGeral.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonMercadoGeral.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMercadoGeral.Location = new System.Drawing.Point(17, 64);
            this.buttonMercadoGeral.Name = "buttonMercadoGeral";
            this.buttonMercadoGeral.Size = new System.Drawing.Size(83, 23);
            this.buttonMercadoGeral.TabIndex = 1;
            this.buttonMercadoGeral.Text = "Mercado Geral";
            this.buttonMercadoGeral.UseVisualStyleBackColor = true;
            this.buttonMercadoGeral.Click += new System.EventHandler(this.buttonMercadoGeral_Click);
            // 
            // labelMercado
            // 
            this.labelMercado.AutoSize = true;
            this.labelMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelMercado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMercado.Location = new System.Drawing.Point(20, 26);
            this.labelMercado.Name = "labelMercado";
            this.labelMercado.Size = new System.Drawing.Size(66, 23);
            this.labelMercado.TabIndex = 0;
            this.labelMercado.Text = "Mercado";
            // 
            // buttonCompraVenda
            // 
            this.buttonCompraVenda.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompraVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCompraVenda.Location = new System.Drawing.Point(401, 124);
            this.buttonCompraVenda.Name = "buttonCompraVenda";
            this.buttonCompraVenda.Size = new System.Drawing.Size(137, 29);
            this.buttonCompraVenda.TabIndex = 27;
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
            this.buttonTransacoes.TabIndex = 28;
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
            this.buttonRelatorios.TabIndex = 29;
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
            this.buttonCarteiras.TabIndex = 30;
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
            this.buttonGerenciarMercado.TabIndex = 31;
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
            this.buttonMercado.TabIndex = 32;
            this.buttonMercado.Text = "MERCADO";
            this.buttonMercado.UseVisualStyleBackColor = true;
            this.buttonMercado.Click += new System.EventHandler(this.buttonMercado_Click);
            // 
            // panelMercado
            // 
            this.panelMercado.BackColor = System.Drawing.Color.White;
            this.panelMercado.Controls.Add(this.buttonCalcular);
            this.panelMercado.Controls.Add(this.textBoxValor);
            this.panelMercado.Controls.Add(this.label2);
            this.panelMercado.Controls.Add(this.textBoxMoeda);
            this.panelMercado.Controls.Add(this.label1);
            this.panelMercado.Controls.Add(this.labelCalcularFracao);
            this.panelMercado.Controls.Add(this.pictureBox2);
            this.panelMercado.Controls.Add(this.lblMercado);
            this.panelMercado.Location = new System.Drawing.Point(150, 166);
            this.panelMercado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMercado.Name = "panelMercado";
            this.panelMercado.Size = new System.Drawing.Size(595, 323);
            this.panelMercado.TabIndex = 33;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Red;
            this.buttonCalcular.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonCalcular.ForeColor = System.Drawing.Color.White;
            this.buttonCalcular.Location = new System.Drawing.Point(504, 206);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 29);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(412, 169);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(115, 20);
            this.textBoxValor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(409, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entre com o valor em reais";
            // 
            // textBoxMoeda
            // 
            this.textBoxMoeda.Location = new System.Drawing.Point(412, 123);
            this.textBoxMoeda.Name = "textBoxMoeda";
            this.textBoxMoeda.Size = new System.Drawing.Size(115, 20);
            this.textBoxMoeda.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entre com o valor do criptoativo";
            // 
            // labelCalcularFracao
            // 
            this.labelCalcularFracao.AutoSize = true;
            this.labelCalcularFracao.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalcularFracao.Location = new System.Drawing.Point(408, 66);
            this.labelCalcularFracao.Name = "labelCalcularFracao";
            this.labelCalcularFracao.Size = new System.Drawing.Size(177, 19);
            this.labelCalcularFracao.TabIndex = 2;
            this.labelCalcularFracao.Text = "Calcule a fração da Criptomoeda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(399, 232);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblMercado
            // 
            this.lblMercado.AutoSize = true;
            this.lblMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.lblMercado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMercado.Location = new System.Drawing.Point(10, 7);
            this.lblMercado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMercado.Name = "lblMercado";
            this.lblMercado.Size = new System.Drawing.Size(66, 23);
            this.lblMercado.TabIndex = 0;
            this.lblMercado.Text = "Mercado";
            // 
            // TelaMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.panelMercado);
            this.Controls.Add(this.buttonCompraVenda);
            this.Controls.Add(this.buttonTransacoes);
            this.Controls.Add(this.buttonRelatorios);
            this.Controls.Add(this.buttonCarteiras);
            this.Controls.Add(this.buttonGerenciarMercado);
            this.Controls.Add(this.buttonMercado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaMercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEMBANK-Mercado";
            this.Load += new System.EventHandler(this.TelaMercado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMercado.ResumeLayout(false);
            this.panelMercado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLitecoin;
        private System.Windows.Forms.Button buttonEtherum;
        private System.Windows.Forms.Button buttonBitcoin;
        private System.Windows.Forms.Button buttonMercadoGeral;
        private System.Windows.Forms.Label labelMercado;
        private System.Windows.Forms.Button buttonCompraVenda;
        private System.Windows.Forms.Button buttonTransacoes;
        private System.Windows.Forms.Button buttonRelatorios;
        private System.Windows.Forms.Button buttonCarteiras;
        private System.Windows.Forms.Button buttonGerenciarMercado;
        private System.Windows.Forms.Button buttonMercado;
        private System.Windows.Forms.Panel panelMercado;
        private System.Windows.Forms.Label lblMercado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMoeda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCalcularFracao;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}