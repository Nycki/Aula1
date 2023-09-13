using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            TABELA.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM SITE";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string nome = (string)dr["nome"];
                    string sala = (string)dr["sala"];
                    DateTime data = (DateTime)dr["data"];
                    string hora_entrada = (string)dr["horarioentrada"];
                    string hora_saida = (string)dr["horariosaida"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(sala);
                    lv.SubItems.Add(data.ToShortDateString());
                    lv.SubItems.Add(hora_entrada);
                    lv.SubItems.Add(hora_saida);
                    TABELA.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {


            Connection connection= new Connection();
            SqlCommand  sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO SITE VALUES 
            (@nome, @cpf, @telefone, @sala, @horarioentrada, @horariosaida, @senha, @data)";

            sqlCommand.Parameters.AddWithValue("@nome",txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@cpf",mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@telefone",mtbTelefone.Text);
            sqlCommand.Parameters.AddWithValue("@sala",mtbSala.Text);
            sqlCommand.Parameters.AddWithValue("@horarioentrada",mtbHE.Text);
            sqlCommand.Parameters.AddWithValue("@horariosaida",mtbHS.Text);
            sqlCommand.Parameters.AddWithValue("@senha",txbSenha.Text);
            sqlCommand.Parameters.AddWithValue("@data",mtbData.Text);


            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("ALOCADA COM SUCESSO",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            mtbCPF.Clear();
            mtbTelefone.Clear();
            mtbSala.Clear();
            mtbHE.Clear();
            mtbHS.Clear();
            txbSenha.Clear();
            mtbData.Clear();


            UpdateListView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();



        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPront_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}
