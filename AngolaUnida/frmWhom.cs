using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngolaUnida
{
    public partial class frmWhom : Form
    {
        public frmWhom()
        {
            InitializeComponent();
            int who;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b1.BorderColor = btnCarente.BackColor;
            b2.BorderColor = btnDoador.BackColor;
            b3.BorderColor = btnInstituicao.BackColor;
        }

        private void btnCarente_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin(1);
            frm.Show();
        }

        private void btnDoador_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin(2);
            frm.Show();
        }

        private void btnInstituicao_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin(3);
            frm.Show();
        }
    }
}
