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
    public partial class FUNCIONARIO : Form
    {
        public FUNCIONARIO()
        {
            InitializeComponent();
        }

        private void FUNCIONARIO_Load(object sender, EventArgs e)
        {

        }
        private void SalvarFuncionario(string nome, string estadoCivil)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\funcionario.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine();
            arquivo.WriteLine("cadastro de Funcionários");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("---------------------------------");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Funcionario salvo com sucesso!!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void LimparFuncionario()
        {
            txtNome.Clear();
            rbdCasado.Checked = false;
            rbdSolteiro.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, estadoCivil;
            nome = txtNome.Text;
            if (rbdCasado.Checked == true)
            {
                estadoCivil = "Casado(a)";
            }else if(rbdSolteiro.Checked == true)
            {
                estadoCivil = "Solteiro(a)";
            }
            else
            {
                MessageBox.Show("Escolha um estado Civil");
                return;
            }
            SalvarFuncionario(nome, estadoCivil);
            LimparFuncionario();
        }
    }
}
