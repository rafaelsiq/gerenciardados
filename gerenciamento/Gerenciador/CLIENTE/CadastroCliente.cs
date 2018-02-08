using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.CLIENTE
{
    public partial class CadastroCliente : Form
    {
        StreamReader ler;
        FileStream arquivo;
        StreamWriter escrever;
        Contato contato;
        Cliente cliente;

        public CadastroCliente()
        {
            InitializeComponent(); 
            CadastrarTipos(comboBox_Tipos);

        }
        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }
        private void comboBox_Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CadastrarTipos(ComboBox comboBox) {
            try
            {
                int cont = 0;
                try { arquivo = new FileStream("TYPES.txt", FileMode.Open); }
                catch (NullReferenceException) { MessageBox.Show("SEM NENHUM TIPO CADASTRADO!\nINFORME AO ADMINISTRADOR", "ATENÇÃO"); return false; }
                catch (FileNotFoundException) { MessageBox.Show("SEM NENHUM TIPO CADASTRADO!\nINFORME AO ADMINISTRADOR", "ATENÇÃO"); return false; }
                ler = new StreamReader(arquivo);
                string[] Completo = ler.ReadToEnd().Split('=');
                do { comboBox.Items.Add(Completo[cont]); cont++; } while (cont < Completo.Length);
                return true;
            }
            finally {
                arquivo.Close();
                ler.Close();
                
            }
        }
        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Tipos.Text == "" || comboBox_Tipos.Text == null)
                    throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ESCOLHA UM TIPO!", "ATENÇÃO");
            } // tipos
            try
            {
                if (dateTimePicker1.Text.Contains("2018") || dateTimePicker1 == null)
                    throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ESCOLHA UMA DATA VALIDA", "ATENÇÃO");
            } // data
            try {
                if (Valida(textBox_cpf.Text) == false || ValidaCnpj(textBox_cpf.Text))
                    throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("CPF OU CNPJ NÃO É VALIDO", "ATENÇÃO");
            } // cpf
            try
            {
                if (textBox_nome.Text == "" || textBox_cpf.Text==null)
                    throw new NullReferenceException();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("DIGITE UM NOME POR FAVOR", "ATENÇÃO");
            } // nome
            try
            {
                if (textBox_email.Text == "" || textBox_email.Text == null)
                    throw new NullReferenceException();
                else if (!textBox_email.Text.Contains("@") || !textBox_email.Text.Contains("."))
                    throw new FileLoadException();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("DIGITE UM EMAIL POR FAVOR", "ATENÇÃO");
            }
            catch (FileLoadException)
            {
                MessageBox.Show("DIGITE UM EMAIL VALIDO!", "ATENÇÃO");

            }// email



            Cliente cliente = new Cliente();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public bool Valida(string cpf)

        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
        public bool ValidaCnpj(string cnpj)

        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;

            int resto;

            string digito;

            string tempCnpj;

            cnpj = cnpj.Trim();

            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)

                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);

        }
        private void button_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
