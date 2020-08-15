using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace AngolaUnida
{

    class DAL
    {
        //public string strcon = "server=localhost;port=3306; userid='root'; password=;database=uniface;";
        public string strcon = "server=pcema; user id='UserUniface'; password='uniface947221912';database=angolaunida;port=3306";   
       
       // modeloMensagem mSms = null;
        modeloPessoa mpessoa = null;
      //  modeloGrupo mgrupo = null;

        MySqlConnection con = null;
        MySqlCommand sql = null;
        MySqlDataReader leitor = null;
        Metodo metodo = new Metodo();
        char retorno;
        string ret;
        int retorn;
        bool texte = false;

        public bool verificaConexao()
        {
            try
            {
                con = new MySqlConnection(strcon);
                con.Open();

                texte = true;

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            return texte;

        }

        public void Mensagem(string corpo, string tipo)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("Insert into mensagem (`idsms`, `corpo`,`tipo`) values(" + ultimoregisto("idsms", "mensagem") + ",'" + corpo + "','" + tipo + "')", con);
                con.Open();
                sql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void enviarMensagem_MP(string corpo, int idPessoa, int idReceptor)
        {
            try
            {
                Mensagem(corpo, "MP");
                enviar(idPessoa, idReceptor);

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
        }
        
        public void enviarMensagem_P(string corpo, int idPessoa, byte[] arquivo)
        {
            try
            {
                Mensagem_P(corpo, idPessoa, arquivo);
               // enviarMensagem_P(idPessoa);

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
        }


        public void enviarComentario(int idPessoa)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("Insert into `enviarcomentario` (`idsms`, `idpessoa`, `data_envio`, `hora_envio`) values ('" + (ultimoregisto("idsms", "mensagem") - 1) + "','" + idPessoa + "',current_date(),current_time())", con);
                con.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void enviar(int idPessoa, int idReceptor)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("Insert into enviar (`idenvio`, `idsms`, `idpessoa`, `idreceptor`, `data_envio`, `hora_envio`) values ('" + ultimoregisto("idenvio", "enviar") + "','" + (ultimoregisto("idsms", "mensagem") - 1) + "','" + idPessoa + "','" + idReceptor + "',current_date(),current_time())", con);
                con.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void Arquivo(byte[] arquivo, string nome)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("Insert into mensagem (`idsms`,`arquivo`,`tipo`,`corpo`) values(" + ultimoregisto("idsms", "mensagem") + ",@foto,'BN',@corpo);", con);
                con.Open();
                sql.Parameters.AddWithValue("@corpo", nome);
                sql.Parameters.AddWithValue("@foto", arquivo);
                sql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void enviarArquivo(int idPessoa, int idReceptor, byte[] foto, string nome)
        {
            try
            {
                Arquivo(foto, nome);
                enviar(idPessoa, idReceptor);

                if (MessageBox.Show("Enviado com Sucesso!") == DialogResult.OK)
                {
                    Form.ActiveForm.Dispose();
                }

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
        }

        public void Mensagem_P(string corpo, int idpessoa, byte[] arquivo)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("Insert into publicacao (`corpo`, `idpessoa`, `data_envio`, `hora_envio`, `foto`) values('" + corpo + "','"+idpessoa +"',current_date(),current_time(),@foto)", con);
                con.Open();
                sql.Parameters.AddWithValue("@foto", arquivo);
                sql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public int ultimoregisto(string campo, string tabela)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("select max(" + campo + ") from " + tabela + "", con);
                con.Open();
                leitor = sql.ExecuteReader();
                while (leitor.Read())
                {

                    retorn = Convert.ToInt32(leitor["max(" + campo + ")"]) + 1;

                }
            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);
            }
            finally
            {
                con.Close();
            }
            return retorn;
        }

        public void cadastrarPessoa(modeloPessoa model, byte[] foto)
        {
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("insert into pessoa (`idpessoa`,`login`, `nome`, `sobrenome`, `morada`, `nacionalidade`, `naturalidade`, `email`, `telefone`, `sexo`, `senha`, `who`,`foto`) values (" + ultimoregisto("idpessoa", "pessoa") + ",'" + model.Login + "','" + model.Nome + "','" + model.Sobrenome + "','" + model.Morada + "','" + model.Nacionalidade + "','" + model.Naturalidade + "','" + model.Email + "','" + model.Telefone + "','" + model.Sexo + "','" + model.Senha + "','" + model.Who + "',@foto)", con);
                sql.Parameters.AddWithValue("@foto", foto);
                con.Open();
                sql.ExecuteNonQuery();

                MessageBox.Show("Cadastro Efetuado com Sucesso!\nSeja Benvindo ao AngolaUnida Sr.(a) " + model.Sobrenome + "!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form.ActiveForm.Visible = false;
                frmLogin frml = new frmLogin(model.Who);
                frml.Show();

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Dadoincorreto(ex);

            }
            finally
            {
                con.Close();
            }
        }

        public modeloPessoa obterDados(string cmdConcat)
        {
            mpessoa = new modeloPessoa();
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("select *,date_format(nascimento,'%d de %M de %Y') from pessoa where concat(nome,sobrenome)='" + cmdConcat + "';", con);
                con.Open();
                leitor = sql.ExecuteReader();
                while (leitor.Read())
                {
                    mpessoa.Nome = leitor["nome"].ToString();
                    mpessoa.Sobrenome = leitor["sobrenome"].ToString();
                    mpessoa.Email = leitor["email"].ToString();
                    mpessoa.Morada = leitor["morada"].ToString();
                    mpessoa.Nacionalidade = leitor["nacionalidade"].ToString();
                    mpessoa.Naturalidade = leitor["naturalidade"].ToString();
                    mpessoa.Sexo = Convert.ToChar(leitor["sexo"]);
                    mpessoa.Telefone = leitor["telefone"].ToString();
                    mpessoa.Login = leitor["login"].ToString();
                    mpessoa.Nascimento = leitor["date_format(nascimento,'%d de %M de %Y')"].ToString();
                    mpessoa.Senha = leitor["senha"].ToString();
                    mpessoa.Who = Convert.ToInt32(leitor["who"]);
                    mpessoa.Idpessoa = Convert.ToInt32(leitor["idpessoa"]);
                    try
                    {
                        mpessoa.Foto = (byte[])leitor["foto"];
                    }
                    catch (Exception)
                    {
                        mpessoa.Foto = null;
                    }

                }
                
            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
            return mpessoa;
        }

        public modeloPessoa obterDados(string login, string senha)
        {
            mpessoa = new modeloPessoa();
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("select *,date_format( nascimento,'%d de %M de %Y') from pessoa where login='" + login + "' and senha='" + senha + "';", con);
                con.Open();
                leitor = sql.ExecuteReader();
                while (leitor.Read())
                {
                    mpessoa.Nome = leitor["nome"].ToString();
                    mpessoa.Sobrenome = leitor["sobrenome"].ToString();
                    mpessoa.Email = leitor["email"].ToString();
                    mpessoa.Morada = leitor["morada"].ToString();
                    mpessoa.Nacionalidade = leitor["nacionalidade"].ToString();
                    mpessoa.Naturalidade = leitor["naturalidade"].ToString();
                    mpessoa.Sexo = Convert.ToChar(leitor["sexo"]);
                    mpessoa.Telefone = leitor["telefone"].ToString();
                    mpessoa.Login = leitor["login"].ToString();
                    mpessoa.Nascimento = leitor["date_format( nascimento,'%d de %M de %Y')"].ToString();
                    mpessoa.Senha = leitor["senha"].ToString();
                    mpessoa.Who = Convert.ToInt32(leitor["who"]);
                    mpessoa.Idpessoa = Convert.ToInt32(leitor["idpessoa"]);
                    try
                    {
                        mpessoa.Foto = (byte[])leitor["foto"];
                    }
                    catch (Exception)
                    {
                        mpessoa.Foto = null;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
            return mpessoa;
        }

        public modeloPessoa obterDados(int idpessoa)
        {
            mpessoa = new modeloPessoa();
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand("select *,date_format(nascimento,'%d de %M de %Y') from pessoa where idpessoa='" + idpessoa + "';", con);
                con.Open();
                leitor = sql.ExecuteReader();
                while (leitor.Read())
                {
                    mpessoa.Nome = leitor["nome"].ToString();
                    mpessoa.Sobrenome = leitor["sobrenome"].ToString();
                    mpessoa.Email = leitor["email"].ToString();
                    mpessoa.Morada = leitor["morada"].ToString();
                    mpessoa.Nacionalidade = leitor["nacionalidade"].ToString();
                    mpessoa.Naturalidade = leitor["naturalidade"].ToString();
                    mpessoa.Sexo = Convert.ToChar(leitor["sexo"]);
                    mpessoa.Telefone = leitor["telefone"].ToString();
                    mpessoa.Login = leitor["login"].ToString();
                    mpessoa.Nascimento = leitor["date_format(nascimento,'%d de %M de %Y')"].ToString();
                    mpessoa.Senha = leitor["senha"].ToString();
                    mpessoa.Who = Convert.ToInt32(leitor["who"]);
                    mpessoa.Idpessoa = Convert.ToInt32(leitor["idpessoa"]);
                    try
                    {
                        mpessoa.Foto = (byte[])leitor["foto"];
                    }
                    catch (Exception)
                    {
                        mpessoa.Foto = null;
                    }

                }
               
            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
            return mpessoa;
        }

        public char validar(string comando)
        {
            mpessoa = new modeloPessoa();
            try
            {
                con = new MySqlConnection(strcon);
                sql = new MySqlCommand(comando, con);
                con.Open();
                leitor = sql.ExecuteReader();
                if (leitor.Read())
                {
                    retorno = 'T';
                }
                else
                {
                    retorno = 'F';
                }

            }
            catch (Exception ex)
            {
                Metodo m = new Metodo();
                m.Desconetado(ex);
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }

       
              
           

    }
}
