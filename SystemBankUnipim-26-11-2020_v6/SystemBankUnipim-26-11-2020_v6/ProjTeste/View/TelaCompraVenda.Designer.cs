namespace ProjTeste.View
{
    partial class TelaCompraVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompraVenda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCompraVenda = new System.Windows.Forms.Button();
            this.buttonTransacoes = new System.Windows.Forms.Button();
            this.buttonRelatorios = new System.Windows.Forms.Button();
            this.buttonCarteiras = new System.Windows.Forms.Button();
            this.buttonGerenciarMercado = new System.Windows.Forms.Button();
            this.buttonMercado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompraVenda = new System.Windows.Forms.Button();
            this.labelCompraVenda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridCompraVenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompraVenda)).BeginInit();
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
            this.buttonCompraVenda.Location = new System.Drawing.Point(402, 124);
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
            this.buttonTransacoes.Location = new System.Drawing.Point(531, 124);
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
            this.buttonRelatorios.Location = new System.Drawing.Point(661, 124);
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
            this.buttonCarteiras.Location = new System.Drawing.Point(268, 124);
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
            this.buttonGerenciarMercado.Location = new System.Drawing.Point(134, 124);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.btnCompraVenda);
            this.panel1.Controls.Add(this.labelCompraVenda);
            this.panel1.Location = new System.Drawing.Point(-1, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 265);
            this.panel1.TabIndex = 63;
            // 
            // btnCompraVenda
            // 
            this.btnCompraVenda.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnCompraVenda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCompraVenda.Location = new System.Drawing.Point(17, 64);
            this.btnCompraVenda.Name = "btnCompraVenda";
            this.btnCompraVenda.Size = new System.Drawing.Size(83, 23);
            this.btnCompraVenda.TabIndex = 1;
            this.btnCompraVenda.Text = "Consultar";
            this.btnCompraVenda.UseVisualStyleBackColor = true;
            this.btnCompraVenda.Click += new System.EventHandler(this.btnCompraVenda_Click);
            // 
            // labelCompraVenda
            // 
            this.labelCompraVenda.AutoSize = true;
            this.labelCompraVenda.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelCompraVenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCompraVenda.Location = new System.Drawing.Point(13, 25);
            this.labelCompraVenda.Name = "labelCompraVenda";
            this.labelCompraVenda.Size = new System.Drawing.Size(107, 23);
            this.labelCompraVenda.TabIndex = 0;
            this.labelCompraVenda.Text = "Compra/Venda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dataGridCompraVenda);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(150, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 323);
            this.panel2.TabIndex = 64;
            // 
            // dataGridCompraVenda
            // 
            this.dataGridCompraVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompraVenda.Location = new System.Drawing.Point(27, 44);
            this.dataGridCompraVenda.Name = "dataGridCompraVenda";
            this.dataGridCompraVenda.Size = new System.Drawing.Size(542, 245);
            this.dataGridCompraVenda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra e Venda";
            // 
            // TelaCompraVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCompraVenda);
            this.Controls.Add(this.buttonTransacoes);
            this.Controls.Add(this.buttonRelatorios);
            this.Controls.Add(this.buttonCarteiras);
            this.Controls.Add(this.buttonGerenciarMercado);
            this.Controls.Add(this.buttonMercado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaCompraVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCompraVenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompraVenda)).EndInit();
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
        private System.Windows.Forms.Button btnCompraVenda;
        private System.Windows.Forms.Label labelCompraVenda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridCompraVenda;
        private System.Windows.Forms.Label label1;
    }
}