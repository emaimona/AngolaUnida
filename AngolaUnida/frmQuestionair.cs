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
    public partial class frmQuestionair : Form
    {
        public frmQuestionair()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void frmQuestionair_Load(object sender, EventArgs e)
        {
            //frmInfo frm = new frmInfo("Bem-vindo ao Portal","Para melhores resultados, porfavor preencha os seus dados! Obrigado.");
            //frm.Show();
            panel2.Location = new Point(262, 184);
            panel2.BringToFront();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPagina frm = new frmPagina();
            frm.Show();
        }
    }
}
