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
    public partial class frmInfo : Form
    {
        string title, corpo;
        public frmInfo(string title, string corpo)
        {
            this.title = title;
            this.corpo = corpo;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            lblInfo.Text = corpo;
            lblTitle.Text = title;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
