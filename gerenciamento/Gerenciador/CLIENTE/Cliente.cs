using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;
using System.Threading.Tasks;

namespace Gerenciador.CLIENTE
{
    class Cliente
    {
        string Nome, Tipo;
        int Cpf;
        DateTime Nascimento;
        Contato contato;
        //construtor
        public Cliente(string nome, string tipo, int cpf, DateTime data, Contato contato) {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Cpf = cpf;
            this.Nascimento = data;
            this.contato = contato;
        }
        public Cliente() { }
        //set
        private void setNome(string Nome) {
            this.Nome = Nome;
        }
        private void setTipo(string Tipo)
        {
            this.Tipo = Tipo;
        }
        private void setCPF(int cpf)
        {
            this.Cpf = cpf;
        }
        private void setData(DateTime nascimento) {
            Nascimento = nascimento;
        }
        private void setContato(Contato contato) {
            this.contato = contato;
        }

        //get
        private string getNome()
        {
            return this.Nome;
        }
        private string getTipo()
        {
            return this.Tipo;
        }
        private int setCpf()
        {
            return this.Cpf;
        }
        private DateTime getData()
        {
            return this.Nascimento;
        }
        private Contato getContato()
        {
           return this.contato;
        }
    }
}
