using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasPerimetros
{
    public partial class Rombo : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Rombo()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, BtnCerrar_Click);
            pantalla = new PantallaManager(this);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Areas nuevaPantalla = new Areas();
            pantalla.CargarPantalla(nuevaPantalla);
        }
        private void calcularBtn_Click(object sender, EventArgs e)
        {
            double D, d, res;
            D = double.Parse(dMayorTxt.Text);
            d = double.Parse(dMenorTxt.Text);
            res = (D * d) / 2;
            resultadoTxt.Text = res.ToString();
        }
    }
}
