using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoTelas
{
    public partial class CadastrarVeiculo : Form
    {
        public CadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar o veículo?", "Confirmação de Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                MessageBox.Show("Veículo cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Cancelado com sucesso");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
