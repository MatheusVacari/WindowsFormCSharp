using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, cidade, telefone;
            nome = txtNome.Text;
            cidade = cmbCidade.Items[cmbCidade.SelectedIndex].ToString();
            telefone = maskTelefone.Text;
            SalvarCliente(nome, telefone, cidade);
            LimparCliente();
        }

        private void LimparCliente()
        {
            txtNome.Clear();
            maskTelefone.Clear();
            cmbCidade.SelectedIndex = -1;
        }

        private void SalvarCliente(string nome, string telefone, string cidade)
        {
            StreamWriter arquivo;
                string caminho = "C:\\sistema1\\clientes.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de CLiente");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Cidade: " + cidade);
            arquivo.WriteLine("----------------------------");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Cliente salvo com sucesso!!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
    }
}
