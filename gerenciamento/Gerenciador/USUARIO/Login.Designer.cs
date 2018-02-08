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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entrar_botao
            // 
            this.entrar_botao.Location = new System.Drawing.Point(228, 366);
            this.entrar_botao.Name = "entrar_botao";
            this.entrar_botao.Size = new System.Drawing.Size(75, 23);
            this.entrar_botao.TabIndex = 0;
            this.entrar_botao.Text = "ENTRAR";
            this.entrar_botao.UseVisualStyleBackColor = true;
            this.entrar_botao.Click += new System.EventHandler(this.entrar_botao_Click);
            // 
            // botao_sair
            // 
            this.botao_sair.Location = new System.Drawing.Point(119, 395);
            this.botao_sair.Name = "botao_sair";
            this.botao_sair.Size = new System.Drawing.Size(75, 23);
            this.botao_sair.TabIndex = 1;
            this.botao_sair.Text = "SAIR";
            this.botao_sair.UseVisualStyleBackColor = true;
            this.botao_sair.Click += new System.EventHandler(this.botao_sair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(444, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botao_sair);
            this.Controls.Add(this.entrar_botao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entrar_botao;
        private System.Windows.Forms.Button botao_sair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

