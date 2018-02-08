namespace Gerenciador.CLIENTE
{
    partial class CadastroCliente
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
            this.comboBox_Tipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.botao_cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.textBox_rua = new System.Windows.Forms.TextBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_complemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_referencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_Tipos
            // 
            this.comboBox_Tipos.FormattingEnabled = true;
            this.comboBox_Tipos.Location = new System.Drawing.Point(161, 33);
            this.comboBox_Tipos.Name = "comboBox_Tipos";
            this.comboBox_Tipos.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Tipos.TabIndex = 0;
            this.comboBox_Tipos.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME/RAZAO:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(161, 67);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(241, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(161, 99);
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(152, 20);
            this.textBox_cpf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF / CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ANIVERSARIO:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // botao_cadastrar
            // 
            this.botao_cadastrar.Location = new System.Drawing.Point(57, 397);
            this.botao_cadastrar.Name = "botao_cadastrar";
            this.botao_cadastrar.Size = new System.Drawing.Size(94, 23);
            this.botao_cadastrar.TabIndex = 9;
            this.botao_cadastrar.Text = "CADASTRAR";
            this.botao_cadastrar.UseVisualStyleBackColor = true;
            this.botao_cadastrar.Click += new System.EventHandler(this.botao_cadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ENDERECO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TELEFONE";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(161, 190);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(151, 20);
            this.textBox_email.TabIndex = 13;
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Location = new System.Drawing.Point(161, 216);
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(151, 20);
            this.textBox_telefone.TabIndex = 14;
            // 
            // textBox_rua
            // 
            this.textBox_rua.Location = new System.Drawing.Point(161, 268);
            this.textBox_rua.Name = "textBox_rua";
            this.textBox_rua.Size = new System.Drawing.Size(151, 20);
            this.textBox_rua.TabIndex = 15;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.SystemColors.Window;
            this.button_sair.Location = new System.Drawing.Point(296, 397);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 16;
            this.button_sair.Text = "SAIR";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "RUA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "CONTATO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nº";
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(343, 268);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(59, 20);
            this.textBox_numero.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "COMPLEMENTO";
            // 
            // textBox_complemento
            // 
            this.textBox_complemento.Location = new System.Drawing.Point(161, 296);
            this.textBox_complemento.Name = "textBox_complemento";
            this.textBox_complemento.Size = new System.Drawing.Size(151, 20);
            this.textBox_complemento.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "REFERENCIA:";
            // 
            // textBox_referencia
            // 
            this.textBox_referencia.Location = new System.Drawing.Point(162, 322);
            this.textBox_referencia.Multiline = true;
            this.textBox_referencia.Name = "textBox_referencia";
            this.textBox_referencia.Size = new System.Drawing.Size(240, 62);
            this.textBox_referencia.TabIndex = 24;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(444, 444);
            this.Controls.Add(this.textBox_referencia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_complemento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.textBox_rua);
            this.Controls.Add(this.textBox_telefone);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botao_cadastrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Tipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Tipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button botao_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.TextBox textBox_rua;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_complemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_referencia;
    }
}