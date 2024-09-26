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
    public partial class Circulo : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Circulo()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, btnCerrar_Click);
            pantalla = new PantallaManager(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Areas nuevaPantalla = new Areas();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            double r, res;
            r = double.Parse(radioTxt.Text);
            res = Math.PI * (Math.Pow(r  , 2));
            resultadoTxt.Text = res.ToString();
        }
    }
}
