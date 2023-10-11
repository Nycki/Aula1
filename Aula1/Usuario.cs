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
        public Usuario(int id,
                string nome,
                string cpf,
                string telefone,
                string sala,
                DateTime data,
                string horarioentrada,
                string horariosaida,
                string senha)
        {
            Id = Id;
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
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO NOME");
                
                
                
                _nome = value; }
            get { return _nome; }

        }
        public string Cpf
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO CPF");

                _cpf = value; }
            get { return _cpf; }

        }
        public string Telefone
        {
            set {_telefone = value; }
            get { return _telefone; }

        }
        public string Sala
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO SALA");

                _sala = value; }
            get { return _sala; }

        }
        public DateTime Data
        {
            set {
                if (string.IsNullOrEmpty(value.ToShortDateString()))
                    throw new Exception("PREENCHA O CAMPO DATA");


                _data = value; }
            get { return _data; }

        }
        public string Horarioentrada
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO HORARIO DE ENTRADA");

                _horarioentrada = value; }
            get { return _horarioentrada; }

        }
        public string Horariosaida
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO HORARIO DE SAIDA");

                _horariosaida = value; }
            get { return _horariosaida; }

        }
        public string Senha
        {
            set { _senha = value; }
            get { return _senha; }

        }

    }
}
