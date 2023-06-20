using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1projeto_C_
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            fromAtendente1.BringToFront();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuarioLogado.Text = login.usuario;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void fromAtendente1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            login telalogin = new login();
            telalogin.Show();
            this.Hide();
        }

        private void pneMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente011.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            principal1.BringToFront();
        }
    }
}
