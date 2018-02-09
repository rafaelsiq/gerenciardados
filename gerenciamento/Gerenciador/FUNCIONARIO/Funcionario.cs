using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gerenciador.CLIENTE;
using System.Threading.Tasks;

namespace Gerenciador.FUNCIONARIO
{
    class Funcionario
    {
        string login, senha, nome, cpf;
        Endereco endereco;
        Contato contato;

        public Funcionario() { }
        public Funcionario(string cpf, string nome, string login, string senha, Endereco endereco, Contato contato) {
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.contato = contato;
        }
    }
}
