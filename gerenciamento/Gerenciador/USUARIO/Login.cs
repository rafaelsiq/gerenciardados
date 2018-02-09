using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox_senha.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void entrar_botao_Click(object sender, EventArgs e)
        {
            verificarCadastro(textBox_login.Text, textBox_senha.Text);
        }

        private void botao_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void verificarCadastro(string login, string senha) {
            

        }
    }
}
