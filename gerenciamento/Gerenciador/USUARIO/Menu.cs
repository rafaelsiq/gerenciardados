using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.USUARIO
{
    public partial class menu : Form
    {
        public menu()
        {
           
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            InitializeComponent();
            pictureBox_faixa.Width = Screen.PrimaryScreen.Bounds.Width;
            label_razaosocial.Width = pictureBox_faixa.Width / 2;
            label_razaosocial.Height = pictureBox_faixa.Height / 2;
            

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
