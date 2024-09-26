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
    public partial class Rectangulo : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Rectangulo()
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
            float b, a, res;
            a = float.Parse(alturaTxt.Text);
            b = float.Parse(baseTxt.Text);
            res = a * b;
            resultadoTxt.Text = res.ToString();
        }
    }
}
