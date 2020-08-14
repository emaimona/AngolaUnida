using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngolaUnida
{
    public class Metodo
    {
         public void Unload()
        {
           Form.ActiveForm.Dispose();
        }
        
        public void help()
        {
          // System.Diagnostics.Process.Start("www.uniface.com/hlp23");
           // FrmHelp f = new FrmHelp();
           // f.Show();
        }
        public void retificar(TextBox text)
        {
            if (text.Text.Contains("'"))
            {
                text.Text = text.Text.Replace("'", "\"");
            }
        }
        public string modificarMes(string modifiquendo)
        {

            if (modifiquendo.ToLower().Contains("january"))
            {
                modifiquendo = modifiquendo.Replace("january", "Janeiro");
            }
            else if (modifiquendo.ToLower().Contains("february"))
            {
                modifiquendo = modifiquendo.Replace("february", "Fevereiro");
            }
            else if (modifiquendo.ToLower().Contains("march"))
            {
                modifiquendo = modifiquendo.Replace("march", "Março");
            }
            else if (modifiquendo.ToLower().Contains("april"))
            {
                modifiquendo = modifiquendo.Replace("april", "Abril");
            }
            else if (modifiquendo.ToLower().Contains("may"))
            {
                modifiquendo = modifiquendo.Replace("may", "Maio");
            }
            else if (modifiquendo.ToLower().Contains("june"))
            {
                modifiquendo = modifiquendo.Replace("june", "Junho");
            }
            else if (modifiquendo.ToLower().Contains("july"))
            {
                modifiquendo = modifiquendo.Replace("july", "Julho");
            }
            else if (modifiquendo.ToLower().Contains("august"))
            {
                modifiquendo = modifiquendo.Replace("august", "Agosto");
            }
            else if (modifiquendo.ToLower().Contains("september"))
            {
                modifiquendo = modifiquendo.Replace("september", "Setembro");
            }
            else if (modifiquendo.ToLower().Contains("october"))
            {
                modifiquendo = modifiquendo.Replace("october", "Outubro");
            }
            else if (modifiquendo.ToLower().Contains("november"))
            {
                modifiquendo = modifiquendo.Replace("november", "Novembro");
            }
            else if (modifiquendo.ToLower().Contains("december"))
            {
                modifiquendo = modifiquendo.Replace("december", "Dezembro");
            }

            return modifiquendo;
        }
        public void sair(){
            if (MessageBox.Show("Deseja realmente sair do Aplicativo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Obrigado pelo uso do Aplicativo!", "Agradecimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                Application.Exit();
            }
        }

        
        public void Desconetado(Exception ex)
        {
            frmConexao fm = new frmConexao();
            fm.ShowDialog();
           
        }
     
        public void Dadoincorreto(Exception ex)
        {
            MessageBox.Show("Dados introduzidos incorrectamente!\n"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Dadoincorreto()
        {
            MessageBox.Show("Dados introduzidos incorrectamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
    
}
