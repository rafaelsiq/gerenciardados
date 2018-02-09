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
        string login, senha;
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
            verificarCadastro(login, senha);
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUNCIONARIO.CadastroFuncionario novo = new FUNCIONARIO.CadastroFuncionario();
            novo.Show();
            
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
            //teste
        }
    }
}
