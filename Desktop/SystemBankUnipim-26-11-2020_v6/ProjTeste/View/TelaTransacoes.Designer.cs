namespace ProjTeste.View
{
    partial class TelaTransacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTransacoes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCompraVenda = new System.Windows.Forms.Button();
            this.buttonTransacoes = new System.Windows.Forms.Button();
            this.buttonRelatorios = new System.Windows.Forms.Button();
            this.buttonCarteiras = new System.Windows.Forms.Button();
            this.buttonGerenciarMercado = new System.Windows.Forms.Button();
            this.buttonMercado = new System.Windows.Forms.Button();
            this.panelMercado = new System.Windows.Forms.Panel();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.labelIdCarteira = new System.Windows.Forms.Label();
            this.textBoxNrCarteira = new System.Windows.Forms.TextBox();
            this.dataGridViewTransacoes = new System.Windows.Forms.DataGridView();
            this.lbLitecoin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMercado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 131);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCompraVenda
            // 
            this.buttonCompraVenda.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCompraVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCompraVenda.Location = new System.Drawing.Point(400, 124);
            this.buttonCompraVenda.Name = "buttonCompraVenda";
            this.buttonCompraVenda.Size = new System.Drawing.Size(137, 29);
            this.buttonCompraVenda.TabIndex = 57;
            this.buttonCompraVenda.Text = "COMPRA/VENDA";
            this.buttonCompraVenda.UseVisualStyleBackColor = true;
            this.buttonCompraVenda.Click += new System.EventHandler(this.buttonCompraVenda_Click);
            // 
            // buttonTransacoes
            // 
            this.buttonTransacoes.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTransacoes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTransacoes.Location = new System.Drawing.Point(529, 124);
            this.buttonTransacoes.Name = "buttonTransacoes";
            this.buttonTransacoes.Size = new System.Drawing.Size(137, 29);
            this.buttonTransacoes.TabIndex = 58;
            this.buttonTransacoes.Text = "TRANSAÇÕES";
            this.buttonTransacoes.UseVisualStyleBackColor = true;
            this.buttonTransacoes.Click += new System.EventHandler(this.buttonTransacoes_Click);
            // 
            // buttonRelatorios
            // 
            this.buttonRelatorios.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRelatorios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRelatorios.Location = new System.Drawing.Point(659, 124);
            this.buttonRelatorios.Name = "buttonRelatorios";
            this.buttonRelatorios.Size = new System.Drawing.Size(137, 29);
            this.buttonRelatorios.TabIndex = 59;
            this.buttonRelatorios.Text = "RELATÓRIOS";
            this.buttonRelatorios.UseVisualStyleBackColor = true;
            this.buttonRelatorios.Click += new System.EventHandler(this.buttonRelatorios_Click);
            // 
            // buttonCarteiras
            // 
            this.buttonCarteiras.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCarteiras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCarteiras.Location = new System.Drawing.Point(266, 124);
            this.buttonCarteiras.Name = "buttonCarteiras";
            this.buttonCarteiras.Size = new System.Drawing.Size(137, 29);
            this.buttonCarteiras.TabIndex = 60;
            this.buttonCarteiras.Text = "CARTEIRAS";
            this.buttonCarteiras.UseVisualStyleBackColor = true;
            this.buttonCarteiras.Click += new System.EventHandler(this.buttonCarteiras_Click);
            // 
            // buttonGerenciarMercado
            // 
            this.buttonGerenciarMercado.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGerenciarMercado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGerenciarMercado.Location = new System.Drawing.Point(132, 124);
            this.buttonGerenciarMercado.Name = "buttonGerenciarMercado";
            this.buttonGerenciarMercado.Size = new System.Drawing.Size(137, 29);
            this.buttonGerenciarMercado.TabIndex = 61;
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
            this.buttonMercado.TabIndex = 62;
            this.buttonMercado.Text = "MERCADO";
            this.buttonMercado.UseVisualStyleBackColor = true;
            this.buttonMercado.Click += new System.EventHandler(this.buttonMercado_Click);
            // 
            // panelMercado
            // 
            this.panelMercado.BackColor = System.Drawing.Color.White;
            this.panelMercado.Controls.Add(this.buttonConsultar);
            this.panelMercado.Controls.Add(this.labelIdCarteira);
            this.panelMercado.Controls.Add(this.textBoxNrCarteira);
            this.panelMercado.Controls.Add(this.dataGridViewTransacoes);
            this.panelMercado.Controls.Add(this.lbLitecoin);
            this.panelMercado.Location = new System.Drawing.Point(100, 165);
            this.panelMercado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMercado.Name = "panelMercado";
            this.panelMercado.Size = new System.Drawing.Size(595, 323);
            this.panelMercado.TabIndex = 63;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.Coral;
            this.buttonConsultar.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.buttonConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConsultar.Location = new System.Drawing.Point(371, 267);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 26);
            this.buttonConsultar.TabIndex = 4;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // labelIdCarteira
            // 
            this.labelIdCarteira.AutoSize = true;
            this.labelIdCarteira.BackColor = System.Drawing.Color.Transparent;
            this.labelIdCarteira.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCarteira.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIdCarteira.Location = new System.Drawing.Point(118, 245);
            this.labelIdCarteira.Name = "labelIdCarteira";
            this.labelIdCarteira.Size = new System.Drawing.Size(179, 19);
            this.labelIdCarteira.TabIndex = 3;
            this.labelIdCarteira.Text = "Entre com o Número da Carteira";
            // 
            // textBoxNrCarteira
            // 
            this.textBoxNrCarteira.Location = new System.Drawing.Point(200, 267);
            this.textBoxNrCarteira.Name = "textBoxNrCarteira";
            this.textBoxNrCarteira.Size = new System.Drawing.Size(139, 20);
            this.textBoxNrCarteira.TabIndex = 2;
            // 
            // dataGridViewTransacoes
            // 
            this.dataGridViewTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransacoes.Location = new System.Drawing.Point(92, 33);
            this.dataGridViewTransacoes.Name = "dataGridViewTransacoes";
            this.dataGridViewTransacoes.Size = new System.Drawing.Size(421, 197);
            this.dataGridViewTransacoes.TabIndex = 1;
            // 
            // lbLitecoin
            // 
            this.lbLitecoin.AutoSize = true;
            this.lbLitecoin.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.lbLitecoin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLitecoin.Location = new System.Drawing.Point(10, 7);
            this.lbLitecoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLitecoin.Name = "lbLitecoin";
            this.lbLitecoin.Size = new System.Drawing.Size(84, 23);
            this.lbLitecoin.TabIndex = 0;
            this.lbLitecoin.Text = "Transações";
            // 
            // TelaTransacoes
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaTransacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaTransacoes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMercado.ResumeLayout(false);
            this.panelMercado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransacoes)).EndInit();
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
        private System.Windows.Forms.Panel panelMercado;
        private System.Windows.Forms.Label lbLitecoin;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label labelIdCarteira;
        private System.Windows.Forms.TextBox textBoxNrCarteira;
        private System.Windows.Forms.DataGridView dataGridViewTransacoes;
    }
}