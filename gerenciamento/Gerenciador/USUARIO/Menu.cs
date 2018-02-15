using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;

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
            panel_cliente.Width = pictureBox_faixa.Width;
            label_razaosocial.Width = pictureBox_faixa.Width / 2;
            label_razaosocial.Height = pictureBox_faixa.Height / 2;
            int x = this.label_razaosocial.Text.Length;
            x *= 5;
            this.label_razaosocial.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width/2-x, 9);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel_cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_cliente.Visible = true;
            panel_cliente.Location = new Point(0, 40);
        }
    }
}
