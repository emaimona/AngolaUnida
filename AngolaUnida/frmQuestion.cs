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
    public partial class frmQuestion : Form
    {
        Form frm;

        string titulo, conteudo;

        public void frmInfo(Form frm, string titulo, string conteudo,int answer)
        {
            this.frm = frm;
            this.titulo = titulo;
            this.conteudo = conteudo;

            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
