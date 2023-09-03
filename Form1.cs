using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Ejercicio8 : Form
    {
        public Random random = new Random();
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Tirar_Click(object sender, EventArgs e)
        {
            int numero = random.Next(1, 7);

            switch(numero)
            {
                case 1:
                    TX_1.Text = "*";
                    break;
                case 2:
                    TX_1.Text = "**";
                    break;
                case 3:
                    TX_1.Text = "***";
                    break;
                case 4:
                    TX_1.Text = "****";
                    break;
                case 5:
                    TX_1.Text = "*****";
                    break;
                case 6:
                    TX_1.Text = "******";
                    break;
                default:
                    break;
            }
        }
    }
}
