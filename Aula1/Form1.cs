using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            string CPF = mtbCPF.Text;
            string telefone= mtbTelefone.Text;
            string sala = mtbSala.Text;
            string data= mtbData.Text;
            string HE= mtbHE.Text;
            string HS= mtbHS.Text;


            string mensagem = "NOME: " + nome +
                "\nSALA: " + sala +
                "\nDATA: " + data +
                "\nHORARIO DE ENTRADA: " + HE +
                "\nHORARIO DE SAIDA: " + HS +
                "\nSUA SALA FOI ALOCADA ";


            MessageBox.Show(
                mensagem,
                "ATENÇÃO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
               "OU TA SEDO AINDA",
               "????",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
