using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace AngolaUnida
{
    public partial class frmText : Form
    {
        public frmText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BunifuElipse borda = new BunifuElipse();
            Panel p = new Panel();
            System.Drawing.Color.FromArgb(20, Color.Black);

            p.BackColor = System.Drawing.Color.FromArgb(200, Color.Black);
            p.Size = new Size(204, 110);
            p.AutoSize = true;
            p.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(txtTexto.Text));

            Label txtTop = new Label();
            txtTop.Dock = DockStyle.Top;
            txtTop.AutoSize = false;
            txtTop.BackColor = Color.FromArgb(10, Color.LightGray);
            txtTop.TextAlign = ContentAlignment.MiddleRight;
            txtTop.Text = "~Mingota Pacheco";
            txtTop.Size = new Size(txtTop.Width, 19);
            txtTop.Padding = new System.Windows.Forms.Padding(5);
            txtTop.ForeColor = Color.White;

            Label txtBottom = new Label();
            txtBottom.Dock = DockStyle.Bottom;
            txtBottom.AutoSize = false;
            txtBottom.BackColor = Color.FromArgb(10, Color.LightGray);
            txtBottom.ForeColor = Color.White;
            txtBottom.TextAlign = ContentAlignment.MiddleRight;
            txtBottom.Text = "Sexta-Feira, 12:40";
            txtBottom.Padding = new System.Windows.Forms.Padding(0, 2, 5, 2);
            txtBottom.Size = new Size(txtTop.Width, 17);

            /*
            txtContent = new Label();
            txtContent.Dock = DockStyle.Fill;
            txtContent.AutoSize = true;
            txtContent.MaximumSize = new System.Drawing.Size(250, 0);
            txtContent.BackColor = Color.FromArgb(230, Color.White);
            txtContent.TextAlign = ContentAlignment.TopLeft;
            txtContent.Padding = new System.Windows.Forms.Padding(5);

            txtContent.Text = "Olá, como vai daqui fala o Emanuel... Este é o meu site www.facebook.com\nOlá, como vai daqui fala o Emanuel... Este é o meu site www.facebook.com Este é o meu site www.facebook.com\nOlá, como vai daqui fala o Emanuel... Este é o meu site www.facebook.com";
            */

            Control[] con = new Control[5];

            //con[0] = txtContent;
            con[1] = txtTop;
            con[2] = txtBottom;


            p.Controls.AddRange(con);

            //panel1.Controls.Add(p);
            borda.TargetControl = p;
        }
    }
}
