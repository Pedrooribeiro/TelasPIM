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
    public partial class Crud : Form
    {
        bool isMenuOpen = false;
        public Crud()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Crud_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                panel2.Width -= 488;
                if (panel2.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen = false;
                }
            }
            else if (!isMenuOpen)
            {
                panel2.Width += 488;
                if (panel2.Width == 488)
                {
                    timer1.Stop();
                    isMenuOpen = true;
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo cadastrarVeiculo2 = new CadastrarVeiculo();
            cadastrarVeiculo2.ShowDialog();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo consultarVeiculo2= new ConsultarVeiculo();
            consultarVeiculo2.ShowDialog();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que desejar cadastrar o veículo ?","Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Veículo cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Cancelado com sucesso");
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            ModificarVeiculo ModificarVeiculo2 = new ModificarVeiculo();
            ModificarVeiculo2.ShowDialog();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            ExcluirVeiculo ExcluirVeiculo2 = new ExcluirVeiculo();
            ExcluirVeiculo2.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                panel3.Width -= 370;
                if (panel3.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen = false;
                }
            }
            else if (!isMenuOpen)
            {
                panel3.Width += 370;
                if (panel3.Width == 370)
                {
                    timer1.Stop();
                    isMenuOpen = true;
                }
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            CadastrarSeguro CadastrarSeguro2 = new CadastrarSeguro();
            CadastrarSeguro2.ShowDialog();
        }

        private void Button22_Click_1(object sender, EventArgs e)
        {
            ModificarSeguro ModificarSeguro2 = new ModificarSeguro();
            ModificarSeguro2.ShowDialog();
        }

        private void Button21_Click_1(object sender, EventArgs e)
        {
            ExcluirSeguro ExcluirSeguro2 = new ExcluirSeguro();
            ExcluirSeguro2.ShowDialog();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            CadastrarMotorista CadastrarMotorista2 = new CadastrarMotorista();
            CadastrarMotorista2.ShowDialog();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            ConsultarMotorista ConsultarMotorista2 = new ConsultarMotorista();
            ConsultarMotorista2.ShowDialog();
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            ModificarMotorista ModificarMotorista2 = new ModificarMotorista();
            ModificarMotorista2.ShowDialog();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            ExcluirMotorista ExcluirMotorista2 = new ExcluirMotorista();
            ExcluirMotorista2.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                panel4.Width -= 490;
                if (panel4.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen = false;
                }
            }
            else if (!isMenuOpen)
            {
                panel4.Width += 490;
                if (panel4.Width == 490)
                {
                    timer1.Stop();
                    isMenuOpen = true;
                }
            }
        }
    }
}
