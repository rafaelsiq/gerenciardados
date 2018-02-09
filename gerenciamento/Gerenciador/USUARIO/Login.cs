using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Web;
using Gerenciador.USUARIO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class Login : Form
    {
        StreamReader ler;
        FileStream arquivo;
        StreamWriter escrever;



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
            if (verificarCadastro(textBox_login.Text, textBox_senha.Text) == true)
            {
                this.Hide();
                menu inicial = new menu();
                inicial.Show();
            }else
            {
                MessageBox.Show("Senha ou Login\nInvalidos!", "ALERTA");
            }
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

        private bool verificarCadastro(string login, string senha) {
            arquivo = new FileStream("funcionarios.txt", FileMode.Open);
            ler = new StreamReader(arquivo);
            string linha;
            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                    if (linha.Contains(login) && linha.Contains(senha))
                    return true;

            } while (linha != null);
            arquivo.Close();
            ler.Close();

            return false;
        }
    }
}
