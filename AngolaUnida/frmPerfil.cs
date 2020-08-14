using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AngolaUnida
{
    public partial class frmPerfil : Form
    {

        string nome;
        public frmPerfil(string nome)
        {
            this.nome = nome;
            InitializeComponent();
        }

        public string strcon = new DAL().strcon;

        public MySqlConnection con = null;
        public MySqlCommand sql = null;
        public MySqlDataReader leitor = null;
        public BLL banco = null;
        Metodo metodo = new Metodo();
        modeloPessoa mpessoa;
        frmFoto fot = new frmFoto();

        private void foto_MouseHover(object sender, EventArgs e)
        {

            fot.panel1.BackgroundImage = foto.BackgroundImage;
            fot.bunifuElipse1.ElipseRadius = 400;
            fot.Show();
        }

        private void foto_MouseLeave(object sender, EventArgs e)
        {
            fot.Hide();
        }

        public void perfil(string nome)
        {
            // btnAlterarFoto.Visible = false;
            try
            {
                banco = new BLL();
                modeloPessoa m = new modeloPessoa();
                m = banco.obterDadosBLL(nome);
                m.Nascimento = metodo.modificarMes(m.Nascimento.ToLower());

                
                lblNome.Text = m.Nome + m.Sobrenome;

                
                lblMorada.Text = "Morada: " + m.Morada;
                lblEmail.Text = "Email: " + m.Email;
                lblSexo.Text = "Sexo: " + (m.Sexo == 'M' ? "Masculino" : "Feminino");
                lblTelefone.Text = "Telefone: " + m.Telefone;
                
                /*
                lblNacionalidade.Text = "Nacionalidade: " + m.Nacionalidade;
                lblNaturalidade.Text = "Naturalidade: " + m.Naturalidade;
                lblNascimento.Text = "Nascimento: " + m.Nascimento;

                
                if (m.Sexo == 'M')
                {
                    iconSexo.BackgroundImage = Properties.Resources._013_076_male_man_sign_symbol_256;
                }
                else
                {
                    iconSexo.BackgroundImage = Properties.Resources._013_077_female_woman_sign_symbol_256;
                }
                */
               // lblSeccao.Text = "Secção: " + m.Cargo;
                

                if (m.Foto == null)
                {
                    foto.BackgroundImage = AngolaUnida.Properties.Resources.photo;
                }
                else
                {
                    MemoryStream fstream = new MemoryStream(m.Foto);
                    foto.BackgroundImage = Image.FromStream(fstream);
                }

            }
            catch (Exception ex)
            {
                metodo.Desconetado(ex);
            }
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            perfil(this.nome);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
