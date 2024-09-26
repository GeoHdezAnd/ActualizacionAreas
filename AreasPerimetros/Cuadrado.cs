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
    public partial class Cuadrado : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Cuadrado()
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

        private void btnCuadradoA_Click(object sender, EventArgs e)
        {
            float dat1 = 0, resultado;
            dat1 = float.Parse(agregarL.Text);
            resultado = dat1 * dat1;
            resultadoTxt.Text = resultado.ToString();
        }

    }
}
