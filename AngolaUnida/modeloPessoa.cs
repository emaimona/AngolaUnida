using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngolaUnida
{
    public class modeloPessoa
    {
        int idpessoa, who;
        string login, nome, sobrenome, morada, nacionalidade, naturalidade, email, senha, nascimento, telefone;
        char sexo;
        byte[] foto;

        public int Idpessoa
        {
            get
            {
                return idpessoa;
            }

            set
            {
                idpessoa = value;
            }
        }

        public int Who
        {
            get
            {
                return who;
            }

            set
            {
                who = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string Morada
        {
            get
            {
                return morada;
            }

            set
            {
                morada = value;
            }
        }

        public string Nacionalidade
        {
            get
            {
                return nacionalidade;
            }

            set
            {
                nacionalidade = value;
            }
        }

        public string Naturalidade
        {
            get
            {
                return naturalidade;
            }

            set
            {
                naturalidade = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }

       
        public byte[] Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }
    }
}
