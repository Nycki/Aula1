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

        private int Id;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {

            tabela.Items.Clear();

            tabela.Items.Clear();


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

                    string ID = (string)dr["ID"];

                    string nome = (string)dr["nome"];

                    string CPF = (string)dr["CPF"];

                    string telefone = (string)dr["telefone"];

                    string horarioentrada = (string)dr["horarioentrada"];

                    string horariosaida = (string)dr["horariosaida"];

                    string senha = (string)dr["senha"];

                    string data = (string)dr["data"];


                    ListViewItem lv = new ListViewItem(ID.ToString());


                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(CPF);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(horariosaida);
                    lv.SubItems.Add(senha);
                    lv.SubItems.Add(data);
                    tabela.Items.Add(lv);

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
                    tabela.Items.Add(lv);


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


        

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();





        }

       


        private void EDITAR_Click(object sender, EventArgs e)
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

            sqlCommand.Parameters.AddWithValue("@nome", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", mtbTelefone.Text);
            sqlCommand.Parameters.AddWithValue("@sala", mtbSala.Text);
            sqlCommand.Parameters.AddWithValue("@horarioentrada", mtbHE.Text);
            sqlCommand.Parameters.AddWithValue("@horariosaida", mtbHS.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbSenha.Text);
            sqlCommand.Parameters.AddWithValue("@data", mtbData.Text);
            sqlCommand.Parameters.AddWithValue("@id", mtbData.Text);



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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void tabela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = tabela.FocusedItem.Index;
            Id = int.Parse(tabela.Items[index].SubItems[0].Text);
            txbNome.Text = tabela.Items[index].SubItems[1].Text;
            mtbCPF.Text = tabela.Items[index].SubItems[2].Text;
            mtbTelefone.Text = tabela.Items[index].SubItems[3].Text;
            mtbSala.Text = tabela.Items[index].SubItems[4].Text;
            mtbHE.Text = tabela.Items[index].SubItems[5].Text;
            mtbHS.Text = tabela.Items[index].SubItems[6].Text;
            txbSenha.Text = tabela.Items[index].SubItems[7].Text;
            mtbData.Text = tabela.Items[index].SubItems[8].Text;
            

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
    }
}
