namespace Gerenciador
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.entrar_botao = new System.Windows.Forms.Button();
            this.botao_sair = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // entrar_botao
            // 
            this.entrar_botao.Location = new System.Drawing.Point(141, 321);
            this.entrar_botao.Name = "entrar_botao";
            this.entrar_botao.Size = new System.Drawing.Size(75, 23);
            this.entrar_botao.TabIndex = 0;
            this.entrar_botao.Text = "ENTRAR";
            this.entrar_botao.UseVisualStyleBackColor = true;
            this.entrar_botao.Click += new System.EventHandler(this.entrar_botao_Click);
            // 
            // botao_sair
            // 
            this.botao_sair.Location = new System.Drawing.Point(231, 321);
            this.botao_sair.Name = "botao_sair";
            this.botao_sair.Size = new System.Drawing.Size(75, 23);
            this.botao_sair.TabIndex = 1;
            this.botao_sair.Text = "SAIR";
            this.botao_sair.UseVisualStyleBackColor = true;
            this.botao_sair.Click += new System.EventHandler(this.botao_sair_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(192, 248);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(192, 274);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(100, 20);
            this.textBox_senha.TabIndex = 5;
            this.textBox_senha.TextChanged += new System.EventHandler(this.textBox_senha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(108, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 149);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(444, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.botao_sair);
            this.Controls.Add(this.entrar_botao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar_botao;
        private System.Windows.Forms.Button botao_sair;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

