using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngolaUnida
{
    public partial class frmCadastro : Form
    {
        OpenFileDialog arquivo= new OpenFileDialog();
        bool state = false;
        Metodo metodos = new Metodo();

        int who;
        public frmCadastro(int whom)
        {
            who = whom;
            InitializeComponent();
        }

        void limpar()
        {
            txtemail.Text = null;
            txtLogin.Text = null;
            txtmorada.Text = null;
            //txtNacionalidade.Text = null;
            //txtNaturalidade.Text = null;
            txtNome.Text = null;
            txtSenha.Text = null;
            txtSobrenome.Text = null;
            txtTelefone.Text = null;
        }

        private void Cadastrar()
        {
            BLL verificador = new BLL();
            state = verificador.verificaConexaoBLL();
            if (state == true)
            {
                if (txtemail.Text == "" | txtLogin.Text == "" | txtmorada.Text == "" | txtNome.Text == "" | txtSenha.Text == "" | txtSobrenome.Text == "" | txtTelefone.Text == "")
                {
                    if (who == 2)
                    {

                    }
                    else{
                        MessageBox.Show("Não pode haver campos vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (txtSenha.Text.Length < 6)
                {
                    MessageBox.Show("A senha de ter pelo menos 6 letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtLogin.Text.ToLower() == "admin")
                {
                    MessageBox.Show("Erro ao cadastrar\nInforme outro Login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                }
                else
                {
                    BLL banco = null;
                    modeloPessoa model = null;

                    char ver;
                    Metodo metodos = new Metodo();
                    metodos.retificar(txtNome);
                    metodos.retificar(txtemail);
                    metodos.retificar(txtLogin);
                    metodos.retificar(txtmorada);
                    metodos.retificar(txtSenha);
                    metodos.retificar(txtSobrenome);

                    try
                    {
                        banco = new BLL();
                        model = new modeloPessoa();

                        ver = banco.verificadorBLL("select * from pessoa where login='" + txtLogin.Text + "'");

                        if (ver == 'T')
                        {
                            MessageBox.Show("Existe um usuário cadastrado com este login.\nPor razões de segurança, por favor informe outro login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ver == 'F')
                        {
                            model.Who = who;

                            model.Login = txtLogin.Text;
                            model.Senha = txtSenha.Text;
                            model.Email = txtemail.Text.Trim();
                            model.Morada = txtmorada.Text.Trim();
                            //  model.Nascimento = dataNascimentoU.Value.Year + "/" + dataNascimentoU.Value.Month + "/" + dataNascimentoU.Value.Day;
                            //model.Nascimento = ano.Value + "/" + mes.Value + "/" + dia.Value;
                           // model.Nacionalidade = txtProvincia.Text.Trim();
                            //model.Naturalidade = txtProvincia.Text.Trim();
                            model.Nome = txtNome.Text.Trim() + " ";
                            model.Sobrenome = txtSobrenome.Text.Trim();
                            model.Telefone = txtTelefone.Text;

                            if (rdbFem.Checked)
                            {
                                model.Sexo = 'F';
                            }
                            else
                            {
                                model.Sexo = 'M';
                            }

                            byte[] img = null;

                            if (arquivo.FileName == "")
                            {
                                img = null;
                            }
                            else
                            {
                                FileStream fstream = new FileStream(arquivo.FileName, FileMode.Open, FileAccess.Read);
                                BinaryReader breader = new BinaryReader(fstream);
                                img = breader.ReadBytes((int)fstream.Length);
                            }

                            banco.cadastrarPessoaBLL(model, img);

                        }

                    }
                    catch (Exception ex)
                    {
                        Metodo m = new Metodo();
                        m.Desconetado(ex);
                    }


                }
            }
            else
            {
                frmConexao frm = new frmConexao();
                frm.ShowDialog();
            }
        }

        string id()
        {
            string p=null;

            if (who == 1)
            {
                p = "Carente";
            } else if (who == 2)
            {
                p = "Doador";
            } else if (who == 3)
            {
                p = "Instituição";
            }
            return p;
        }

        private void lblcontanova_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin(who);
            frm.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Cadastrar(); 
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmWhom frm = new frmWhom();
            frm.Show();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            limpar();
        }

        private void fotoUser_Click(object sender, EventArgs e)
        {
          //  label1.Visible = false;

            arquivo.Filter = "All Pictures( BMP (*.BMP),JPEG (*.JPG;*.JPEG;*.JPE), GIF(*.GIF),PNG(*.PNG;*.PNS))|*.BMP;*.JPG;*.JPEG;*.JPE;*.GIF;*.PNG;*.PNS";
            arquivo.FileName = "";
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                foto.BackgroundImage = Image.FromFile(arquivo.FileName);
            }
            txtSenha.Focus();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cadastrar();
                txtNome.Focus();
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSobrenome.Focus();
            }
        }

        private void txtSobrenome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmorada.Focus();
            }
        }

        private void txtmorada_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefone.Focus();
            }
        }

        private void txtTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogin.Focus();
            }
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }
    }
}
