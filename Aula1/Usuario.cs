using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Aula1
{
    public class Usuario
    {

        private int _id;
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _sala;
        private DateTime _data;
        private string _horarioentrada;
        private string _horariosaida;
        private string _senha;
        
        public Usuario(string nome,
                string cpf, 
                string telefone, 
                string sala, 
                DateTime data, 
                string horarioentrada, 
                string horariosaida, 
                string senha)
        {
            _nome = nome;
            _cpf = cpf;
            _telefone = telefone;
            _sala = sala;
            _horarioentrada = horarioentrada;
            _horariosaida = horariosaida;
            _senha = senha;
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }

        }
        public string Nome
        {
            set { _nome = value; }
            get { return _nome; }

        }
        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }

        }
        public string Telefone
        {
            set { _telefone = value; }
            get { return _telefone; }

        }
        public string Sala
        {
            set { _sala = value; }
            get { return _sala; }

        }
        public DateTime Data
        {
            set { _data = value; }
            get { return _data; }

        }
        public string Horarioentrada
        {
            set { _horarioentrada = value; }
            get { return _horarioentrada; }

        }
        public string Horariosaida
        {
            set { _horariosaida = value; }
            get { return _horariosaida; }

        }
        public string Senha
        {
            set { _senha = value; }
            get { return _senha; }

        }

    }
}
