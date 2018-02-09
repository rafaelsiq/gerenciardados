using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.CLIENTE
{
    class Endereco
    {
        //variaveis
        string rua,bairro, uf, cidade, complemento, referencia;
        int numero;
        //construtores
        public Endereco() {

        }
        public Endereco(string rua, string bairro, string uf, string cidade, string complemento, string referencia, int numero) {
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.complemento = complemento;
            this.referencia = referencia;
            this.numero = numero;
        }
        //acessos
        //set
        private void setRua(string rua)
        {
            this.rua = rua;
        }
        private void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        private void setUF(string uf)
        {
            this.uf = uf;
        }
        private void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        private void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        private void setReferencia(string referencia)
        {
            this.referencia = referencia;
        }
        private void setNumero (int numero)
        {
            this.numero = numero;
        }

        //get
        private string getRua()
        {
            return this.rua;

        }
        private string getBairro()
        {
            return this.bairro;

        }
        private string getUF()
        {
            return this.uf;

        }
        private string getCidade()
        {
            return this.cidade;

        }
        private string getComplemento()
        {
            return this.complemento;

        }
        private string getReferencia()
        {
            return this.referencia;

        }
        private int getNumero()
        {
            return this.numero;

        }

    }
}
