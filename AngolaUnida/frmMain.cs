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
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Microsoft.VisualBasic.PowerPacks;
using System.IO;

namespace AngolaUnida
{
    public partial class frmMain : Form
    {
        int who;
        char id='d';
        OpenFileDialog arquivo = new OpenFileDialog();

        frmAnuncio frm = new frmAnuncio();

        frmFoto fot = new frmFoto();

        public Label nome, txtContent;
        public PictureBox fotoSms;
        public Label[] n;
        public bool state;

        public string login, senha, nomeCompleto, receive, hora, data, perfilName;

        public string strcon = new DAL().strcon;

        public MySqlConnection con = null;
        public MySqlCommand sql = null;
        public MySqlDataReader leitor = null;
        public BLL banco = null;
        Metodo metodo = new Metodo();
        modeloPessoa mpessoa;

        modeloPessoa mainUser= new modeloPessoa();
        modeloPessoa receiverUser= new modeloPessoa();

        int lastSmsID, idsms,p=16,newSms,w=10,cont=1,inc=20;

        string Id()
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

        public void perfil()
        {
           // btnAlterarFoto.Visible = true;
            try
            {
                banco = new BLL();
                modeloPessoa m = new modeloPessoa();
                m = banco.obterDadosBLL(login, senha);
                mainUser = m;
                
                m.Nascimento = metodo.modificarMes(m.Nascimento.ToLower());
                mpessoa = m;
                perfilName= m.Nome + m.Sobrenome;
                lblNome.Text = perfilName;
                /*
                
                lblMorada.Text = "Morada: " + m.Morada;
                lblEmail.Text = "Email: " + m.Email;
                lblNacionalidade.Text = "Nacionalidade: " + m.Nacionalidade;
                lblNaturalidade.Text = "Naturalidade: " + m.Naturalidade;
                lblNascimento.Text = "Nascimento: " + m.Nascimento;
                lblSexo.Text = "Sexo: " + (m.Sexo == 'M' ? "Masculino" : "Feminino");

                if (m.Sexo == 'M')
                {
                    iconSexo.BackgroundImage = Properties.Resources._013_076_male_man_sign_symbol_256;
                }
                else
                {
                    iconSexo.BackgroundImage = Properties.Resources._013_077_female_woman_sign_symbol_256;
                }

                lblSeccao.Text = "Secção: " + m.Cargo;
                lblTelefone.Text = "Telefone: " + m.Telefone;

                //lblPerfil.Location = new Point((painelPerfil.Size.Width - lblPerfil.Size.Width) / 2, ((painelPerfil.Size.Height - lblPerfil.Size.Height) / 2)+35);
                nomeCompleto = m.Nome + m.Sobrenome;
                idPessoa = m.Idpessoa;

                txtNome.Text = m.Nome.Trim();
                txtSobrenome.Text = m.Sobrenome.Trim();
                txtemail.Text = m.Email.Trim();
                txtmorada.Text = m.Morada.Trim();
                txtTelefone.Text = m.Telefone;
                */
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
        public void perfil(string nome)
        {
           // btnAlterarFoto.Visible = false;
            try
            {
                banco = new BLL();
                modeloPessoa m = new modeloPessoa();
                m = banco.obterDadosBLL(nome);
                m.Nascimento = metodo.modificarMes(m.Nascimento.ToLower());
                receiverUser = m;    
         
                lblNome.Text = nome;
                /*
                lblMorada.Text = "Morada: " + m.Morada;
                lblEmail.Text = "Email: " + m.Email;
                lblNacionalidade.Text = "Nacionalidade: " + m.Nacionalidade;
                lblNaturalidade.Text = "Naturalidade: " + m.Naturalidade;
                lblNascimento.Text = "Nascimento: " + m.Nascimento;
                lblSexo.Text = "Sexo: " + (m.Sexo == 'M' ? "Masculino" : "Feminino");

                if (m.Sexo == 'M')
                {
                    iconSexo.BackgroundImage = Properties.Resources._013_076_male_man_sign_symbol_256;
                }
                else
                {
                    iconSexo.BackgroundImage = Properties.Resources._013_077_female_woman_sign_symbol_256;
                }

                lblSeccao.Text = "Secção: " + m.Cargo;
                lblTelefone.Text = "Telefone: " + m.Telefone;
                */

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


        public frmMain(string login, string senha, int who)
        {   
            frm.Show();

            this.who=who;
            this.login = login;
            this.senha=senha;
                       
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pnlChatContainer.Location = new Point(Size.Width-pnlChatContainer.Width, 0);
            pnlChatContainer.BringToFront();

            pnlSectionRigth.Visible = false;
           
            lerPublicacao();
            lerChat();
            pnlPublicacao.BackColor = pnlSectionMiddle.BackColor;
            perfil();

            frm.Hide();
            panel1.Visible = true;

        }

        public void instaSms(string caption, string owner, string time, int py, char ide)
        {

            py = w;
            id = ide;

            BunifuElipse border = new BunifuElipse();
            Panel ContentSms = new Panel();
            ContentSms.AutoSize = true;

            //Para ter scroll
            Label scrollActive = new Label();
            scrollActive.Location = new Point(0, 526);

            Label txtTop = new Label();
            txtTop.Dock = DockStyle.Top;
            txtTop.AutoSize = false;

            txtTop.TextAlign = ContentAlignment.MiddleRight;
            txtTop.Text = "~" + owner;
            txtTop.Size = new Size(txtTop.Width, 22);
            //txtTop.Padding = new System.Windows.Forms.Padding(2);

            Label txtBottom = new Label();
            txtBottom.Dock = DockStyle.Bottom;
            txtBottom.AutoSize = false;

            txtBottom.TextAlign = ContentAlignment.MiddleRight;
            txtBottom.Text = time;
          //  txtBottom.Padding = new System.Windows.Forms.Padding(0, 0, 5, 2);
            txtBottom.Size = new Size(txtBottom.Width, 18);

            Label txtContent = new Label();
            txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            txtContent.AutoSize = true;

            txtContent.MinimumSize = new Size(310, 66);
            txtContent.MaximumSize = new Size(310, 0);

            txtContent.Text = caption;

            txtContent.TextAlign = ContentAlignment.TopLeft;
            txtContent.Padding = new System.Windows.Forms.Padding(5);
            txtContent.UseCompatibleTextRendering = true;


            if (id == 'd')
            {

                txtTop.BackColor = System.Drawing.Color.FromArgb(175, 0, 0, 0);
                txtTop.ForeColor = System.Drawing.Color.White;

                txtContent.BackColor = System.Drawing.Color.FromArgb(200, Color.White);

                // ContentSms.BackColor = System.Drawing.Color.FromArgb(230, Color.White);

                txtBottom.BackColor = System.Drawing.Color.FromArgb(175, 0, 0, 0);
                txtBottom.ForeColor = System.Drawing.Color.White;

                ContentSms.Location = new Point(65, py);

            }
            else if (id == 'e')
            {
                txtTop.BackColor = System.Drawing.Color.FromArgb(150, 1, 45, 80);
                txtTop.ForeColor = System.Drawing.Color.White;

                txtContent.BackColor = System.Drawing.Color.FromArgb(230, Color.White);

                //ContentSms.BackColor = System.Drawing.Color.FromArgb(230, Color.White);

                txtBottom.BackColor = System.Drawing.Color.FromArgb(150, 1, 45, 80);
                txtBottom.ForeColor = System.Drawing.Color.White;

                ContentSms.Location = new Point(10, py);

            }

            Control[] controles = new Control[5];

            controles[0] = txtContent;
            controles[1] = txtTop;
            controles[2] = txtBottom;

            ContentSms.Controls.AddRange(controles);

            pnlSms.Controls.Add(ContentSms);

            //Adiing scrooll
            pnlSms.Controls.Add(scrollActive);

            border.TargetControl = ContentSms;

            cont++;
            w = ContentSms.Location.Y + ContentSms.Size.Height + inc;

        }
    
        public void instaPublication(string caption, string owner, string time, int py, byte[] fotoPessoa, byte[] fotoSms)
        {           
            py = w;

            BunifuElipse borderPnlContentSms = new BunifuElipse();
            BunifuElipse borderPicture = new BunifuElipse();
            BunifuToolTip bTooltip = new BunifuToolTip();

            Panel pnlContentSms = new Panel();
            Panel pnlGeneralContent = new Panel();

            pnlGeneralContent.BackColor = Color.FromArgb(20, Color.Black);

            PictureBox picture = new PictureBox();

            picture.Size = new Size(57, 50);
            picture.BackgroundImageLayout = ImageLayout.Stretch;
          //  picture.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            picture.Location = new Point(0, 0);
             if (fotoPessoa == null)
                {
                    picture.BackgroundImage = AngolaUnida.Properties.Resources.photo;
                }
                else
                {
                    MemoryStream fstream = new MemoryStream(fotoPessoa);
                    picture.BackgroundImage = Image.FromStream(fstream);
                }

            System.Drawing.Color.FromArgb(20, Color.Black);

            pnlContentSms.BackColor = System.Drawing.Color.FromArgb(200, Color.Black);
            pnlContentSms.Size = new Size(635, 10);
            pnlContentSms.AutoSize = true;
            pnlContentSms.Location = new Point(57, 0);
            pnlContentSms.Visible = true;

            pnlGeneralContent.Size = new Size(498, 10);
            pnlGeneralContent.AutoSize = true;
            pnlGeneralContent.Location = new Point(128,py);
            pnlGeneralContent.Visible = true;

            PictureBox icon1 = new PictureBox();
            icon1.BackgroundImage = Properties.Resources.Handshake_96px;
            icon1.BackgroundImageLayout = ImageLayout.Stretch;
            icon1.Size = new Size(27, 26);
            icon1.Location = new Point(645, 0);
            icon1.BackColor = Color.FromArgb(200, Color.Black);
            icon1.MouseHover += new EventHandler((object sender, EventArgs e) =>
            {
                icon1.BackgroundImage = Properties.Resources.Handshake_1;
            });
            icon1.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                icon1.BackgroundImage = Properties.Resources.Handshake_96px;
            });
            icon1.Click += new EventHandler((object sender, EventArgs e) =>
            {
                if(owner != (mainUser.Nome+mainUser.Sobrenome)){
                pnlSectionRigth.Visible = true;
                perfil(owner);
                lerMensagem();

                }
            });

            bool state = false;

            PictureBox icon2 = new PictureBox();
            icon2.BackgroundImage = Properties.Resources.heart_1;
            icon2.BackgroundImageLayout = ImageLayout.Stretch;
            icon2.Size = new Size(25, 26);
            icon2.Location = new Point(610, 0);
            icon2.BackColor = Color.FromArgb(200, Color.Black);
            icon2.MouseHover += new EventHandler((object sender, EventArgs e) =>
            {
                icon2.BackgroundImage = Properties.Resources.heart_2;
            });
            icon2.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                if (!state)
                {
                    icon2.BackgroundImage = Properties.Resources.heart_1;
                }
            });
            icon2.Click += new EventHandler((object sender, EventArgs e) =>
            {
                state = true;
                icon2.BackgroundImage = Properties.Resources.heart_2;
            });

            Label txtTop = new Label();
            txtTop.Dock = DockStyle.Top;
            txtTop.AutoSize = false;
            txtTop.BackColor = Color.FromArgb(10, Color.LightGray);
            txtTop.TextAlign = ContentAlignment.MiddleCenter;
            txtTop.Text = "~"+owner;
            txtTop.Size = new Size(txtTop.Width, 25);
            txtTop.Padding = new System.Windows.Forms.Padding(0,5,0,5);
            txtTop.ForeColor = Color.White;

            Label txtBottom = new Label();
            txtBottom.Dock = DockStyle.Bottom;
            txtBottom.AutoSize = false;
            txtBottom.BackColor = Color.FromArgb(80, Color.LightGray);
            txtBottom.ForeColor = Color.White;
            txtBottom.TextAlign = ContentAlignment.MiddleRight;
            txtBottom.Text = time;
            txtBottom.Padding = new System.Windows.Forms.Padding(0, 0, 5, 2);
            txtBottom.Size = new Size(txtTop.Width, 23);

            txtContent = new Label();
            txtContent.Dock = DockStyle.Fill;
            txtContent.AutoSize = true;
            txtContent.ForeColor = Color.White;

            txtContent.MaximumSize = new Size(pnlContentSms.Width, 0);
            txtContent.MinimumSize = new Size(pnlContentSms.Width, 0);

            txtContent.BackColor = Color.FromArgb(20, Color.White);
            txtContent.TextAlign = ContentAlignment.TopLeft;
            txtContent.Padding = new System.Windows.Forms.Padding(5);
            txtContent.UseCompatibleTextRendering = true;
            

            txtContent.Text = caption;
            PictureBox picSms = new PictureBox();           
  
            if (fotoSms == null)
            {
               // picSms.BackgroundImage = AngolaUnida.Properties.Resources.photo;
            }
            else
            {
                MemoryStream fstream = new MemoryStream(fotoSms);
                picSms.BackgroundImage = Image.FromStream(fstream);
            }
            txtContent.MouseHover += new EventHandler((object sender, EventArgs e) =>
            {
                fot.panel1.BackgroundImage = picSms.BackgroundImage;
                fot.bunifuElipse1.ElipseRadius = 20;
                fot.Show();
            });
            txtContent.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                fot.Hide();
            });
            txtContent.Cursor = Cursors.Hand;

            Control[] con = new Control[5];

            con[0] = txtContent;
            con[1] = txtTop;
            con[2] = txtBottom;
            pnlContentSms.Controls.AddRange(con);

            Control[] con1 = new Control[5];

            con1[0] = picture;
            con1[1] = pnlContentSms;
            con1[2] = icon1;
            con1[3] = icon2;

            pnlGeneralContent.Controls.AddRange(con1);

            icon1.BringToFront();
            icon2.BringToFront();

            pnlPublicacao.Controls.Add(pnlGeneralContent);

            borderPicture.TargetControl = picture;
            borderPnlContentSms.TargetControl = pnlContentSms;

            BunifuElipse b = new BunifuElipse();
            b.TargetControl=pnlGeneralContent;
            b.ElipseRadius = 20;

            cont++;
            w = pnlGeneralContent.Location.Y + pnlGeneralContent.Size.Height + inc;

            /*
            //py = w;
            //id = ide;

            BunifuElipse border = new BunifuElipse();
            Panel ContentSms = new Panel();
            ContentSms.AutoSize = true;

            Label txtTop = new Label();
            txtTop.Dock = DockStyle.Top;
            txtTop.AutoSize = false;

            txtTop.TextAlign = ContentAlignment.MiddleRight;
            txtTop.Text = "~" + owner;
            txtTop.Size = new Size(txtTop.Width, 19);
            txtTop.Padding = new System.Windows.Forms.Padding(5);

            Label txtBottom = new Label();
            txtBottom.Dock = DockStyle.Bottom;
            txtBottom.AutoSize = false;

            txtBottom.TextAlign = ContentAlignment.MiddleRight;
            txtBottom.Text = time;
            txtBottom.Padding = new System.Windows.Forms.Padding(0, 0, 5, 2);
            txtBottom.Size = new Size(txtBottom.Width, 17);

            Label txtContent = new Label();
            txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            txtContent.AutoSize = true;

            txtContent.MinimumSize = new Size(250, 66);
            txtContent.MaximumSize = new Size(310, 0);

            txtContent.Text = caption;

            txtContent.TextAlign = ContentAlignment.TopLeft;
            txtContent.Padding = new System.Windows.Forms.Padding(5);
            txtContent.UseCompatibleTextRendering = true;


            //if (id == 'd')
            //{

                txtTop.BackColor = System.Drawing.Color.FromArgb(175, 0, 0, 0);
                txtTop.ForeColor = System.Drawing.Color.White;

                txtContent.BackColor = System.Drawing.Color.FromArgb(200, Color.White);

                // ContentSms.BackColor = System.Drawing.Color.FromArgb(230, Color.White);

                txtBottom.BackColor = System.Drawing.Color.FromArgb(175, 0, 0, 0);
                txtBottom.ForeColor = System.Drawing.Color.White;

                ContentSms.Location = new Point(28, py);

           // }
           // else if (id == 'e')
            //{
        /*
                txtTop.BackColor = System.Drawing.Color.FromArgb(150, 1, 45, 80);
                txtTop.ForeColor = System.Drawing.Color.White;

                txtContent.BackColor = System.Drawing.Color.FromArgb(230, Color.White);

                //ContentSms.BackColor = System.Drawing.Color.FromArgb(230, Color.White);

                txtBottom.BackColor = System.Drawing.Color.FromArgb(150, 1, 45, 80);
                txtBottom.ForeColor = System.Drawing.Color.White;

                ContentSms.Location = new Point(312, py);

            }

            Control[] controles = new Control[5];

            controles[0] = txtContent;
            controles[1] = txtTop;
            controles[2] = txtBottom;

            ContentSms.Controls.AddRange(controles);

            pnlsms.Controls.Add(ContentSms);

            border.TargetControl = ContentSms;


            cont++;
            w = ContentSms.Location.Y + ContentSms.Size.Height + inc;
            */

        }

        public void lerMensagem()
        {
            pnlSms.Controls.Clear();

            w = 10;

            receive= receiverUser.Nome + receiverUser.Sobrenome;
            nomeCompleto = mainUser.Nome + mainUser.Sobrenome;

            try
            {
                string texto, owner, time;

                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("select e.idenvio,e.idsms,e.data_envio,time_format(e.hora_envio,'%H:%i') 'hora',m.corpo 'corpo',m.arquivo,m.tipo,m.idsms, concat(p.nome,p.sobrenome) 'Emissor',concat(r.nome,r.sobrenome) 'Receptor' from enviar as e join mensagem as m on m.idsms=e.idsms join pessoa as p on p.idpessoa= e.idpessoa join pessoa as r on r.idpessoa=e.idreceptor where m.tipo='MP' and (concat(p.nome,p.sobrenome)='" + nomeCompleto + "' and concat(r.nome,r.sobrenome)='" + receive + "') or (concat(p.nome,p.sobrenome)='" + receive + "' and concat(r.nome,r.sobrenome)='" + nomeCompleto + "') order by data_envio asc,hora_envio asc;", con);
                con.Open();
                leitor = sql.ExecuteReader();

                while (leitor.Read())
                {
                    texto = leitor["corpo"].ToString();
                    owner = leitor["emissor"].ToString();
                    time = " Enviada às " + leitor["hora"];


                    if (leitor["emissor"].ToString() == nomeCompleto)
                    {
                        instaSms(texto, owner, time, w, 'd');
                    }
                    if (leitor["emissor"].ToString() == receive)
                    {
                        instaSms(texto, owner, time, w, 'e');
                    }

                    idsms = Convert.ToInt32(leitor["idsms"]);
                }

                lastSmsID = idsms;

                leitor.Close();
                pnlSms.VerticalScroll.Value = pnlSms.VerticalScroll.Maximum;
                pnlSms.AutoScrollPosition = new Point(0, pnlSms.VerticalScroll.Maximum);

            }
            catch (Exception ex)
            {
                metodo.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void lerPublicacao()
        {
            pnlPublicacao.Visible = false;
            pnlPublicacao.Controls.Clear();
           
            w = 10;

            try
            {
                string texto, owner, time;

                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("select m.idpub 'idsms', m.corpo,m.foto,m.idpessoa,m.data_envio,time_format(m.hora_envio,'%H:%i')'hora',concat(p.nome,p.sobrenome) 'nome' from publicacao as m join pessoa as p on m.idpessoa=p.idpessoa order by data_envio desc, hora_envio desc;", con);
                con.Open();
                leitor = sql.ExecuteReader();

                while (leitor.Read())
                {
                    texto = leitor["corpo"].ToString();
                    owner = leitor["nome"].ToString();
                    time = " Publicada às " + leitor["hora"];

                    banco = new BLL();
                    modeloPessoa m = new modeloPessoa();
                    m = banco.obterDadosBLL(owner);

                    try
                    {
                        instaPublication(texto, owner, time, w, m.Foto, (byte[])leitor["foto"]);
                    }
                    catch (Exception)
                    {
                        instaPublication(texto, owner, time, w, m.Foto, null);
                    }
                    /*
                    if (leitor["emissor"].ToString() == nomeCompleto)
                    {
                        insta(texto, owner, time, w, 'e');
                    }
                    if (leitor["emissor"].ToString() == receive)
                    {
                        insta(texto, owner, time, w, 'd');
                    }
                    */
                    idsms = Convert.ToInt32(leitor["idsms"]);
                }

                lastSmsID = idsms;
                leitor.Close();
               // pnlsms.VerticalScroll.Value = pnlsms.VerticalScroll.Maximum;
               // pnlsms.AutoScrollPosition = new Point(0, pnlsms.VerticalScroll.Maximum);

            }
            catch (Exception ex)
            {
                metodo.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
            pnlPublicacao.Visible = true;
        }
                
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

        private void pnlSectionLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fotomax_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtTextoP.Text = "";
        }

        private void btnEnviarP_Click(object sender, EventArgs e)
        {
            BLL verificador = new BLL();
            state = banco.verificaConexaoBLL();
            if (state == true)
            {
                if (txtTextoP.Text != "")
                {
                    if (txtTextoP.Text.Contains("'"))
                    {
                        txtTextoP.Text = txtTextoP.Text.Replace("'", "\"");
                    }
                    try
                    {
                        banco = new BLL();
                       
                        //if (idSms == 'M')
                       // {
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


                            modeloPessoa emissor = new modeloPessoa();
                            emissor = banco.obterDadosBLL(login, senha);
                                                                                
                           banco.enviarMensagem_P(txtTextoP.Text,mainUser.Idpessoa, img);
                            lerPublicacao();
                       /* }
                        else if (idSms == 'G')
                        {
                            modeloGrupo Receptor = new modeloGrupo();
                            if (receive == "Todos")
                            {
                                Receptor.IdGrupo = 0;
                            }
                            else
                            {

                                Receptor = banco.obterDadosGrupo(receive);
                            }


                            banco.enviarMensagem_GrupoPrivado(txtTextoSms.Text, mpessoa.Idpessoa, Receptor.IdGrupo);
                            lerMensagemGrupo(receive);
                        }*/

                        txtTextoP.Text = "";
                        btnInserirImg.BackgroundImage = Properties.Resources.insta2;

                    }
                    catch (Exception ex)
                    {
                        metodo.Desconetado(ex);
                    }
                }
                else
                {
                    txtTextoP.Focus();
                }

            }
            else
            {
                frmConexao fm = new frmConexao();
                fm.ShowDialog();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin(who);
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            arquivo.Filter = "All Pictures( BMP (*.BMP),JPEG (*.JPG;*.JPEG;*.JPE), GIF(*.GIF),PNG(*.PNG;*.PNS))|*.BMP;*.JPG;*.JPEG;*.JPE;*.GIF;*.PNG;*.PNS";
            arquivo.FileName = "";
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
               btnInserirImg.BackgroundImage = Image.FromFile(arquivo.FileName);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //pnlSectionMiddle2.SendToBack();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            instaSms(txtTextoSms.Text,"Emanuel Maimona","12:40",10,'e');
           
        }
           
               
        public void actualizar()
        {
            BLL verificador = new BLL();
            state = banco.verificaConexaoBLL();
            if (state == true)
            {               
                lerPublicacao();
               
                //pnlsms.VerticalScroll.Value = pnlsms.VerticalScroll.Maximum;
              //  pnlsms.AutoScrollPosition = new Point(0, pnlsms.VerticalScroll.Maximum);
            }
            else
            {
                frmConexao fm = new frmConexao();
                fm.ShowDialog();
            }
        }

        private void ovalShape5_Click(object sender, EventArgs e)
        {
            pnlPublicacao.VerticalScroll.Value = pnlPublicacao.VerticalScroll.Minimum;
            pnlPublicacao.AutoScrollPosition = new Point(0, pnlPublicacao.VerticalScroll.Minimum);
            pnlPublicacao.Visible = false;
        }

       
        private void pnlsms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSectionMiddle_Scroll(object sender, ScrollEventArgs e)
        {            
           
        }

        private void pnlsms_Scroll(object sender, ScrollEventArgs e)
        {
            if (pnlPublicacao.VerticalScroll.Value >= 2100)
            {
                btnTopo.Visible = true;
            }
            else
            {
                btnTopo.Visible = false;
            }
        }

        void lerChat()
        {
            
            pnlChat.Visible = false;
            pnlSectionRigth.Visible = false;
            pnlChat.Controls.Clear();

            //Posicionador da localização
            w = 0;

            try
            {
                string name;
                
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("SELECT concat(p.nome,p.sobrenome) 'nome', p.foto  FROM angolaunida.pessoa as p where (who=1 or who=2) and login!='"+login+"'  order by rand();", con);
                con.Open();
                leitor = sql.ExecuteReader();

                while (leitor.Read())
                {
                    name = leitor["nome"].ToString();

                    try
                    {
                        instaChat(name, (byte[])leitor["foto"], w);
                    }
                    catch (Exception)
                    {
                        instaChat(name, null, w);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                metodo.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
            pnlChat.Visible = true;
        }

        void SetHOverBackColor(Control c)
        {
            c.BackColor = Color.FromArgb(30, Color.Black);
        }

        void instaChat(string name, byte[] fotoPerson, int py)
        {
            Panel pnlPerson = new Panel();
            pnlPerson.Size = new Size(392, 63);
            pnlPerson.Location = new Point(0, py);
            pnlPerson.BackColor = Color.White;
            pnlPerson.MouseHover += new EventHandler((object sender, EventArgs e) =>
            {
                SetHOverBackColor(pnlPerson);
            });
            pnlPerson.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                pnlPerson.BackColor = Color.White;
            });
            pnlPerson.Click += new EventHandler((object sender, EventArgs e) =>
            {
                pnlSectionRigth.Visible = true;
                perfil(name);
                lerMensagem();
            });
            
                       
            PictureBox picPerson = new PictureBox();
            picPerson.BackgroundImage = Properties.Resources.photo;
            picPerson.BackgroundImageLayout = ImageLayout.Stretch;
            picPerson.Cursor = Cursors.Hand;
            picPerson.Size = new Size(46, 46);
            picPerson.Location = new Point(13, 8);
            picPerson.Click += new EventHandler((object sender, EventArgs e) =>
            {
                pnlSectionRigth.Visible = true;
                perfil(name);
                lerMensagem();
            });
            if (fotoPerson == null)
            {
                picPerson.BackgroundImage = AngolaUnida.Properties.Resources.photo;
            }
            else
            {
                MemoryStream fstream = new MemoryStream(fotoPerson);
                picPerson.BackgroundImage = Image.FromStream(fstream);
            }
            picPerson.MouseHover += new EventHandler((object sender, EventArgs e) =>
            {
                SetHOverBackColor(pnlPerson);
            });
            picPerson.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                pnlPerson.BackColor = Color.White;
            });

            Label lblName = new Label();
            lblName.Text = name;
            lblName.BackColor = Color.Transparent;
          //  lblName.ForeColor = Color.Teal;
            lblName.Cursor = Cursors.Hand;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            lblName.Location = new Point(64, 0);
            lblName.Size = new Size(342, pnlPerson.Height);
            lblName.Click += new EventHandler((object sender, EventArgs e) =>
            {
                pnlSectionRigth.Visible = true;
                perfil(name);
                lerMensagem();
            });
            lblName.MouseHover += new EventHandler((object sender, EventArgs e) =>
            {
                SetHOverBackColor(pnlPerson);
            });
            lblName.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                pnlPerson.BackColor = Color.White;
            });

            BunifuElipse borderPic = new BunifuElipse();
            borderPic.ElipseRadius = 45;
            borderPic.TargetControl = picPerson;
           

            Control[] c = { picPerson, lblName };
            pnlPerson.Controls.AddRange(c);

            pnlChat.Controls.Add(pnlPerson);

            w = pnlPerson.Size.Height + pnlPerson.Location.Y+1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin(who);
            frm.Show();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil(lblNome.Text);
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblHome_MouseHover(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Silver;

        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblHome_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).ForeColor = Color.Turquoise;

        }

        private void lblHome_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            metodo.sair();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil(perfilName);
            frm.Show();
        }

        private void lblHome_Click_1(object sender, EventArgs e)
        {
            actualizar();
            lerChat();
        }

        private void lblChat_Click(object sender, EventArgs e)
        {
            lerChat();
        }

        private void btnSentSms_Click(object sender, EventArgs e)
        {
            BLL verificador = new BLL();
            state = banco.verificaConexaoBLL();
            if (state == true)
            {
                if (txtTextoSms.Text != "")
                {
                    if (txtTextoSms.Text.Contains("'"))
                    {
                        txtTextoSms.Text = txtTextoSms.Text.Replace("'", "\"");
                    }
                    try
                    {
                            banco.enviarMensagem_SmsParticular(txtTextoSms.Text,mainUser.Idpessoa , receiverUser.Idpessoa, data, hora);
                            lerMensagem();
                      
                            txtTextoSms.Text = "";

                    }
                    catch (Exception ex)
                    {
                        metodo.Desconetado(ex);
                    }
                }
                else
                {
                    txtTextoSms.Focus();
                }

            }
            else
            {
                frmConexao fm = new frmConexao();
                fm.ShowDialog();
            }

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            BLL verificador = new BLL();
            state = banco.verificaConexaoBLL();
            if (state == true)
            {
                lerMensagem();
               
                pnlSms.VerticalScroll.Value = pnlSms.VerticalScroll.Maximum;
                pnlSms.AutoScrollPosition = new Point(0, pnlSms.VerticalScroll.Maximum);
            }
            else
            {
                frmConexao fm = new frmConexao();
                fm.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmQuestionair frm = new frmQuestionair();
            frm.Show();
        }

                               
        }
    }

