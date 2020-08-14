using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngolaUnida
{
    public class BLL
    {
        DAL Bdal = null;
        Metodo m = null;

        public bool verificaConexaoBLL()
        {
            Bdal = new DAL();
            return Bdal.verificaConexao();
        }
        public void enviarMensagem_SmsParticular(string corpo, int idPessoa, int idReceptor, string data, string hora)
        {
            Bdal = new DAL();
            Bdal.enviarMensagem_MP(corpo, idPessoa, idReceptor);
        }
          public modeloPessoa obterDadosBLL(int idpessoa)
        {
            Bdal = new DAL();
            return Bdal.obterDados(idpessoa);
        }

          public void enviarMensagem_P(string corpo, int idPessoa, byte[] arquivo)
          {

              Bdal = new DAL();
              Bdal.enviarMensagem_P(corpo, idPessoa,arquivo);

          }

          public void cadastrarPessoaBLL(modeloPessoa model, byte[] foto)
          {
              try
              {
                  Bdal = new DAL();
                  Bdal.cadastrarPessoa(model, foto);
              }
              catch (Exception ex)
              {
                  m.Dadoincorreto(ex);

              }
          }

          public modeloPessoa obterDadosBLL(string login, string senha)
          {
              try
              {
                  Bdal = new DAL();

              }
              catch (Exception ex)
              {
                  m.Desconetado(ex);
              }
              return Bdal.obterDados(login, senha);
          }

          public modeloPessoa obterDadosBLL(string cmdConcat)
          {
              try
              {
                  Bdal = new DAL();

              }
              catch (Exception ex)
              {
                  m.Desconetado(ex);
              }
              return Bdal.obterDados(cmdConcat);
          }

          public char verificadorBLL(string comando)
          {
              try
              {
                  Bdal = new DAL();

              }
              catch (Exception ex)
              {
                  m.Desconetado(ex);
              }
              return Bdal.validar(comando);
          }

       
    }
    
}
