namespace SystemBankUnipim
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAdm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AccessibleName = "labelLogin";
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(200, 319);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(59, 29);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelAdm
            // 
            this.labelAdm.AutoSize = true;
            this.labelAdm.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAdm.Location = new System.Drawing.Point(354, 259);
            this.labelAdm.Name = "labelAdm";
            this.labelAdm.Size = new System.Drawing.Size(193, 35);
            this.labelAdm.TabIndex = 2;
            this.labelAdm.Text = "ADMINISTRADOR";
            // 
            // label1
            // 
            this.label1.AccessibleName = "labelSenha";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(197, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(100, 33);
            this.TextBoxLogin.TabIndex = 9;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.AcceptsTab = true;
            this.textBoxSenha.Location = new System.Drawing.Point(291, 369);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(285, 33);
            this.textBoxSenha.TabIndex = 6;
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
            // ButtonEntrar
            // 
            this.ButtonEntrar.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonEntrar.Location = new System.Drawing.Point(394, 425);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(85, 29);
            this.ButtonEntrar.TabIndex = 8;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = true;
            this.ButtonEntrar.Click += new System.EventHandler(this.ButtonEntrar_Click_1);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.AcceptsTab = true;
            this.textBoxUsuario.Location = new System.Drawing.Point(291, 325);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(285, 33);
            this.textBoxUsuario.TabIndex = 10;
            // 
            // TelaLogin
            // 
            this.AcceptButton = this.ButtonEntrar;
            this.AccessibleName = "Login";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(796, 521);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAdm);
            this.Controls.Add(this.labelLogin);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "TelaLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEMBANK";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelAdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonEntrar;
        private System.Windows.Forms.TextBox textBoxUsuario;
    }
}