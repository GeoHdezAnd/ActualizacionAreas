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
    public partial class CuadradoP : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public CuadradoP()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, btnCerrar_Click);
            pantalla = new PantallaManager(this);
        }
        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Perimetros nuevaPantalla = new Perimetros();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            float l, res;
            l = float.Parse(ladoTxt.Text);
            res = l * 4;
            resultadoTxt.Text = res.ToString();
        }
    }
}
