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
        bool isMenuOpen1 = false;
        bool isMenuOpen2 = false;
        bool isMenuOpen3 = false;
        bool isMenuOpen4 = false;
        bool isMenuOpen5 = false;
        bool isMenuOpen6 = false;
        bool isMenuOpen7 = false;
        bool isMenuOpen8 = false;
        bool isMenuOpen9 = false;
        bool isMenuOpen10 = false;
        bool isMenuOpen11 = false;
        bool isMenuOpen12 = false;
        bool isMenuOpen13 = false;
        bool isMenuOpen14 = false;
        bool isMenuOpen15 = false;
        public Crud()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (isMenuOpen15)
            {
                panel16.Width -= 116;
                if (panel16.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen15 = false;
                }
            }
            else if (!isMenuOpen15)
            {
                panel16.Width += 116;
                if (panel16.Width == 116)
                {
                    timer1.Stop();
                    isMenuOpen15 = true;
                }
            }
        }

        private void Crud_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (isMenuOpen1)
            {
                panel2.Width -= 488;
                if (panel2.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen1 = false;
                }
            }
            else if (!isMenuOpen1)
            {
                panel2.Width += 488;
                if (panel2.Width == 488)
                {
                    timer1.Stop();
                    isMenuOpen1 = true;
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
            if (isMenuOpen2)
            {
                panel3.Width -= 370;
                if (panel3.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen2 = false;
                }
            }
            else if (!isMenuOpen2)
            {
                panel3.Width += 370;
                if (panel3.Width == 370)
                {
                    timer1.Stop();
                    isMenuOpen2 = true;
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
            if (isMenuOpen3)
            {
                panel4.Width -= 490;
                if (panel4.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen3 = false;
                }
            }
            else if (!isMenuOpen3)
            {
                panel4.Width += 490;
                if (panel4.Width == 490)
                {
                    timer1.Stop();
                    isMenuOpen3 = true;
                }
            }
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            CadastrarRota CadastrarRota2 = new CadastrarRota();
            CadastrarRota2.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (isMenuOpen4)
            {
                panel5.Width -= 126;
                if (panel5.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen4 = false;
                }
            }
            else if (!isMenuOpen4)
            {
                panel5.Width += 126;
                if (panel5.Width == 126)
                {
                    timer1.Stop();
                    isMenuOpen4 = true;
                }
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            CadastrarEntrada CadastrarEntrada2 = new CadastrarEntrada();
            CadastrarEntrada2.ShowDialog();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            CadastrarSaida CadastrarSaida2 = new CadastrarSaida();
            CadastrarSaida2.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (isMenuOpen5)
            {
                panel6.Width -= 245;
                if (panel6.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen5 = false;
                }
            }
            else if (!isMenuOpen5)
            {
                panel6.Width += 245;
                if (panel6.Width == 245)
                {
                    timer1.Stop();
                    isMenuOpen5 = true;
                }
            }
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            CadastrarGasto CadastrarGasto2 = new CadastrarGasto();
            CadastrarGasto2.ShowDialog();
        }

        private void Button32_Click(object sender, EventArgs e)
        {
                ContasPagar ContasPagar2 = new ContasPagar();
                ContasPagar2.ShowDialog();
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            ContasReceber ContasReceber2 = new ContasReceber();
            ContasReceber2.ShowDialog();
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            GastoVeiculo GastoVeiculo2 = new GastoVeiculo();
            GastoVeiculo2.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (isMenuOpen6)
            {
                panel7.Width -= 525;
                if (panel7.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen6 = false;
                }
            }
            else if (!isMenuOpen6)
            {
                panel7.Width += 525;
                if (panel7.Width == 525)
                {
                    timer1.Stop();
                    isMenuOpen6 = true;
                }
            }
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            CadastrarPeca CadastrarPeca2 = new CadastrarPeca();
            CadastrarPeca2.ShowDialog();
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            ExcluirPeca ExcluirPeca2 = new ExcluirPeca();
            ExcluirPeca2.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (isMenuOpen7)
            {
                panel8.Width -= 250;
                if (panel8.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen7 = false;
                }
            }
            else if (!isMenuOpen7)
            {
                panel8.Width += 250;
                if (panel8.Width == 250)
                {
                    timer1.Stop();
                    isMenuOpen7 = true;
                }
            }
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            CadastrarPneu CadastrarPneu2 = new CadastrarPneu();
            CadastrarPneu2.ShowDialog();
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            ExcluirPneu ExcluirPneu2 = new ExcluirPneu();
            ExcluirPneu2.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (isMenuOpen8)
            {
                panel9.Width -= 250;
                if (panel9.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen8 = false;
                }
            }
            else if (!isMenuOpen8)
            {
                panel9.Width += 250;
                if (panel9.Width == 250)
                {
                    timer1.Stop();
                    isMenuOpen8 = true;
                }
            }
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            CadastrarManutencao CadastrarManutencao2 = new CadastrarManutencao();
            CadastrarManutencao2.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ExcluirManutencao ExcluirManutencao2 = new ExcluirManutencao();
            ExcluirManutencao2.ShowDialog();
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            CadastrarAbastecimento CadastrarAbastecimento2 = new CadastrarAbastecimento();
            CadastrarAbastecimento2.ShowDialog();
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            ExcluirAbastecimento ExcluirAbastecimento2 = new ExcluirAbastecimento();
            ExcluirAbastecimento2.ShowDialog();
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            CadastrarQuilometragem CadastrarQuilometragem2 = new CadastrarQuilometragem();
            CadastrarQuilometragem2.ShowDialog();
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            ExcluirQuilometragem ExcluirQuilometragem2 = new ExcluirQuilometragem();
            ExcluirQuilometragem2.ShowDialog();
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            CadastrarMulta CadastrarMulta2 = new CadastrarMulta();
            CadastrarMulta2.ShowDialog();
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            ModificarMulta ModificarMulta2 = new ModificarMulta();
            ModificarMulta2.ShowDialog();
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            ExcluirMulta ExcluirMulta2 = new ExcluirMulta();
            ExcluirMulta2.ShowDialog();
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            CadastrarSinistro CadastrarSinistro2 = new CadastrarSinistro();
            CadastrarSinistro2.ShowDialog();
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            ModificarSinistro ModificarSinistro2 = new ModificarSinistro();
            ModificarSinistro2.ShowDialog();
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            ExcluirSinistro ExcluirSinistro2 = new ExcluirSinistro();
            ExcluirSinistro2.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (isMenuOpen9)
            {
                panel10.Width -= 256;
                if (panel10.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen9 = false;
                }
            }
            else if (!isMenuOpen9)
            {
                panel10.Width += 256;
                if (panel10.Width == 256)
                {
                    timer1.Stop();
                    isMenuOpen9 = true;
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (isMenuOpen10)
            {
                panel11.Width -= 282;
                if (panel11.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen10 = false;
                }
            }
            else if (!isMenuOpen10)
            {
                panel11.Width += 282;
                if (panel11.Width == 282)
                {
                    timer1.Stop();
                    isMenuOpen10 = true;
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (isMenuOpen11)
            {
                panel12.Width -= 282;
                if (panel12.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen11 = false;
                }
            }
            else if (!isMenuOpen11)
            {
                panel12.Width += 282;
                if (panel12.Width == 282)
                {
                    timer1.Stop();
                    isMenuOpen11 = true;
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (isMenuOpen12)
            {
                panel13.Width -= 301;
                if (panel13.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen12 = false;
                }
            }
            else if (!isMenuOpen12)
            {
                panel13.Width += 301;
                if (panel13.Width == 301)
                {
                    timer1.Stop();
                    isMenuOpen12 = true;
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (isMenuOpen13)
            {
                panel14.Width -= 326;
                if (panel14.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen13 = false;
                }
            }
            else if (!isMenuOpen13)
            {
                panel14.Width += 326;
                if (panel14.Width == 326)
                {
                    timer1.Stop();
                    isMenuOpen13 = true;
                }
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (isMenuOpen14)
            {
                panel15.Width -= 116;
                if (panel15.Width == 0)
                {
                    timer1.Stop();
                    isMenuOpen14 = false;
                }
            }
            else if (!isMenuOpen14)
            {
                panel15.Width += 116;
                if (panel15.Width == 116)
                {
                    timer1.Stop();
                    isMenuOpen14 = true;
                }
            }
        }

        private void Button52_Click(object sender, EventArgs e)
        {
            CadastrarAluguel CadastrarAlguel2 = new CadastrarAluguel();
            CadastrarAlguel2.ShowDialog();
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você desejar gerar o relátorio ? ","Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Relatório gerado com sucesso na pasta 'Meus documentos'");
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button51_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
