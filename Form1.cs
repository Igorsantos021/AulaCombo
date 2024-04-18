using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmdEscolha.SelectedItem))
            {
                case 1:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " voce Nasceu em Janeiro";
                    break;
                case 2:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " voce Nasceu em Fevereiro";
                    break;
                case 3:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " voce Nasceu em Março";
                    break;
                case 4:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Abril";
                    break;
                case 5:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Maio";
                    break;

                case 6:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Junho";
                    break;
                case 7:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Julho";
                    break;
                case 8:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Agosto";
                    break;
                case 9:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Outubro";
                    break;
                case 10:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " Voce Nasceu em Novembro";
                    break;
                case 11:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Voce Nasceu em Dezembo";
                    break;
                default:
                    lblMensagem.Text = "Por favor escolha uma opçao de numero ; MES não encontrado";
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
