using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.CLIENTE
{
    class Contato
    {
        string telefone, email;
        Endereco endereco;

        //construtores
        public Contato() { }
        public Contato(string telefone, string email, Endereco endereco) {
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }
        //acesso
        //set
        private void setEmail(string email) {
            this.email = email;
        }
        private void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        private void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }
        //get
        private string setEmail()
        {
           return this.email;
        }
        private string setTelefone()
        {
           return  this.telefone;
        }
        private Endereco getEndereco()
        {
           return this.endereco;
        }
    }
}
