using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    internal class UsuarioDAO
    {
        public List<Usuario> SelectUsuario()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM SITE";

            List<Usuario> usuarios= new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {

                    Usuario objeto = new Usuario(


                    (int)dr["ID"],

                    (string)dr["nome"],

                    (string)dr["CPF"],

                    (string)dr["telefone"],

                    (string)dr["horarioentrada"],

                    (DateTime)dr["horariosaida"],

                    (string)dr["sala"],

                    (string)dr["senha"],

                    (string)dr["data"]

                    );

                    usuarios.Add(objeto);

                }
                dr.Close();

                return usuarios;   
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;

        }
        public void UpdateUsuario(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE SITE SET 
            nome= @nome,
            CPF= @cpf, 
            telefone= @telefone,
            sala= @sala,
            horarioentrada= @horarioentrada, 
            horariosaida= @horariosaida,
            senha= @senha,
            data= @data
            WHERE ID=@id";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@telefone", usuario.Telefone);
            sqlCommand.Parameters.AddWithValue("@sala", usuario.Sala);
            sqlCommand.Parameters.AddWithValue("@horarioentrada", usuario.Horarioentrada);
            sqlCommand.Parameters.AddWithValue("@horariosaida", usuario.Horariosaida);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@data", usuario.Data);
            sqlCommand.Parameters.AddWithValue("@id", Id); 




            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("EDITADA COM SUCESSO!",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        public void InsertUsuario(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO SITE VALUES 
            (@nome, @cpf, @telefone, @sala, @horarioentrada, @horariosaida, @senha, @data)";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@telefone", usuario.Telefone);
            sqlCommand.Parameters.AddWithValue("@sala", usuario.Sala);
            sqlCommand.Parameters.AddWithValue("@horarioentrada", usuario.Horarioentrada);
            sqlCommand.Parameters.AddWithValue("@horariosaida", usuario.Horariosaida);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);
            sqlCommand.Parameters.AddWithValue("@data", usuario.Data);


            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("ALOCADA COM SUCESSO",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void DeletUsuario(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM SITE WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

    }
}
