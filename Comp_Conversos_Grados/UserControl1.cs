using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Conv_Grados;


namespace Comp_Conversos_Grados
{
    public partial class ConversorGrados : UserControl
    {
        double numero;
     
        public ConversorGrados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(pantalla.Text);
            double centigrados = grados.gradosc(numero);
            label1.Text = centigrados.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(pantalla.Text);
            double centigrados = grados.gradosf(numero);
            label1.Text = centigrados.ToString();
        }
    }
    }

