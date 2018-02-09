using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using Gerenciador.CLIENTE;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.FUNCIONARIO
{
    public partial class CadastroFuncionario : Form
    {

        StreamReader ler;
        FileStream arquivo;
        StreamWriter escrever;
        Contato contato;
        Cliente cliente;


        public CadastroFuncionario()
        {
            InitializeComponent();
            textBox_senha.PasswordChar = '*';
        }
        delegate bool Validador(string cpf);
        private void Button_cadastrar(object sender, EventArgs e)
        {
            bool validador = true;
                try
                {
                Validador validaCpf = CadastroCliente.Valida;

                    if (validaCpf(textBox_cpf.Text) == false)
                        throw new NullReferenceException();
                }
                catch (NullReferenceException)
                {
                validador = false;
                MessageBox.Show("CPF NÃO É VALIDO", "ATENÇÃO");
                }// cpf
                try
                {
                    if (textBox_nome.Text == "" || textBox_cpf.Text == null)
                        throw new NullReferenceException();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("DIGITE UM NOME POR FAVOR", "ATENÇÃO");
                validador = false;

            }// nome
            try
                {
                    if (textBox_email.Text == "" || textBox_email.Text == null)
                        throw new NullReferenceException();
                    else if (!textBox_email.Text.Contains("@") || !textBox_email.Text.Contains("."))
                        throw new FileLoadException();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("DIGITE UM EMAIL POR FAVOR", "ATENÇÃO"); validador = false;

            }
            catch (FileLoadException)
                {
                    MessageBox.Show("DIGITE UM EMAIL VALIDO!", "ATENÇÃO"); validador = false;


            }// email
            try
                {

                    var cep = new CorreiosService.AtendeClienteClient();
                    var respostaCorreios = cep.consultaCEP(textBox_cep.Text);
                    if (textBox_numero.Text == "" || textBox_numero == null || textBox_rua.Text == "" || textBox_rua == null)
                        throw new NullReferenceException();

                }
                catch (System.ServiceModel.FaultException erro)
                {
                    MessageBox.Show("NÃO É POSSIVEL CADASTRAR COM ENDEREÇO INCOMPLETO\n" + erro.Message, "ATENCAO");
                validador = false;

            }
            catch (NullReferenceException)
                {
                    MessageBox.Show("NÃO É POSSIVEL CADASTRAR SEM UM NUMERO!\nDIGITE UM NUMERO VALIDO!");
                validador = false;

            }// endereco
             // verificar se há cadastro no arquivo


            try
            {
                arquivo = new FileStream("funcionarios.txt", FileMode.Open);
                ler = new StreamReader(arquivo);
                string tudo = ler.ReadToEnd();
                if (tudo.Contains(textBox_cpf.Text))
                {
                    MessageBox.Show("FUNCIONARIO JA CADASTRADO!");
                    validador = false;

                }
            }
            catch (FileNotFoundException)
            {
                arquivo = new FileStream("funcionarios.txt", FileMode.Create);
            }
            finally {
                arquivo.Close();
            }

            //update
            if (validador == true)
            {
                arquivo = new FileStream("funcionarios.txt", FileMode.Append);
                escrever = new StreamWriter(arquivo);
                escrever.WriteLine("#" + textBox_nome.Text + "#" + textBox_cpf.Text + "#" + textBox_email.Text + "#" + textBox_telefone.Text + "#" + textBox_cpf.Text + "#" + textBox_bairro.Text + "#"
                + textBox_uf.Text + "#" + textBox_rua.Text + "#" + textBox_numero.Text + "#" + textBox_complemento.Text + "#" + textBox_cidade.Text + "#" + textBox_referencia.Text);
                escrever.Close();

                Endereco endereco = new Endereco(textBox_rua.Text, textBox_bairro.Text, textBox_uf.Text, textBox_cidade.Text, textBox_complemento.Text, textBox_referencia.Text, Convert.ToInt32(textBox_numero.Text));
                Contato contato = new Contato(textBox_telefone.Text, textBox_email.Text, endereco);
                Funcionario funcionario = new Funcionario(textBox_cpf.Text, textBox_nome.Text, textBox_login.Text, textBox_senha.Text, endereco, contato);
                arquivo.Close();
                MessageBox.Show("CADASTRO EFETUADO!");
            }
            

            Close();
            

        }

        private void linkLabel_cep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://www.buscacep.correios.com.br/sistemas/buscacep/";
            string navegador = "chrome";
            System.Diagnostics.Process.Start(navegador, @url);
        }
        private void button_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
        private void textBox_rua_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var cep = new CorreiosService.AtendeClienteClient();
                var respostaCorreios = cep.consultaCEP(textBox_cep.Text);
                textBox_bairro.Text = respostaCorreios.bairro;
                textBox_complemento.Text = respostaCorreios.complemento;
                textBox_rua.Text = respostaCorreios.end;
                textBox_cidade.Text = respostaCorreios.cidade;
                textBox_referencia.Text = respostaCorreios.complemento2;
                textBox_uf.Text = respostaCorreios.uf;
            }
            catch (System.ServiceModel.FaultException erro)
            {
                MessageBox.Show("DIGITE UM CEP VALIDO\n" + erro.Message, "ATENCAO");

            }


        }
    }
}
