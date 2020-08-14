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
    public partial class frmLogin : Form
    {
        int who;

        public string log, senha;
        bool state;
        Metodo metodos = new Metodo();
        int tentativas = 3;

        public frmLogin(int whom)
        {
            this.who = whom;
            InitializeComponent();
        }
        
        private void Verificar()
        {
            BLL banco = new BLL();
            state = banco.verificaConexaoBLL();
            if (state == true)
            {
                metodos.retificar(txtlogin);
                metodos.retificar(txtsenha);
                if (txtlogin.Text.ToLower() == "admin")
                {

                    char ver;
                    try
                    {
                        BLL unibll = new BLL();
                        ver = unibll.verificadorBLL("select * from admin where login='admin' and senha='" + txtsenha.Text + "'");
                        if (ver == 'T')
                        {
                           /* Hide();
                            MessageBox.Show("Senha de Administrador correcta!", "Acesso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            frmAdmin frm = new frmAdmin();
                            frm.Show();
                            this.Dispose();
                            */
                        }
                        else if (ver == 'F')
                        {
                            /*
                            tentativas -= 1;
                            MessageBox.Show("Senha de Administrador Inválida!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                             */ }
                    }
                    catch (Exception ex)
                    {
                        metodos.Desconetado(ex);
                    }


                }
                else if (txtlogin.Text.Equals("") || txtsenha.Text.Equals(""))
                {
                    MessageBox.Show("Os campos devem ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtlogin.Text != "admin")
                    {
                        char ver;
                        try
                        {
                            BLL unibll = new BLL();
                            ver = unibll.verificadorBLL("select * from pessoa where login='" + txtlogin.Text + "' and senha='" + txtsenha.Text + "'");
                  
                            if (ver == 'T')
                            {
                                log = txtlogin.Text;
                                senha = txtsenha.Text;
                                MessageBox.Show("Login e Senha Corretos!", "Acesso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                frmMain frm = new frmMain(txtlogin.Text, txtsenha.Text, who);
                                frm.Show();
                                Dispose();
                            }
                            else if (ver == 'F')
                            {

                                MessageBox.Show("Login ou Senha Inválidos!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                           // metodos.Desconetado(ex);
                        }
                    }

                }
            }
            else
            {
                //frmConexao frm = new frmConexao();
                //frm.ShowDialog();
            }
        }


        string id()
        {
            string p = null;

            if (who == 1)
            {
                p = "Carente";
            }
            else if (who == 2)
            {
                p = "Doador";
            }
            else if (who == 3)
            {
                p = "Instituição";
            }
            return p;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmWhom frm = new frmWhom();
            frm.Show();
        }

        private void lblcontanova_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            frmCadastro frm = new frmCadastro(who);
            frm.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (who == 3)
            {
                lblcontanova.Enabled = false;
            }
            else
            {
                lblcontanova.Enabled = true;
            }
        }

        private void txtlogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsenha.Focus();
            }
        }

        private void txtsenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificar();
                txtlogin.Focus();
            }
            
        }
    }
}
