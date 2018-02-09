using System;
using System.Collections.Generic;
using System.Linq;
using Gerenciador.CLIENTE;
using System.Threading.Tasks;
using Gerenciador.FUNCIONARIO;
using System.Windows.Forms;

namespace Gerenciador
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new CadastroCliente());
            //Application.Run(new CadastroFuncionario());
              Application.Run(new Gerenciador.USUARIO.Menu());
        }
    }
}
