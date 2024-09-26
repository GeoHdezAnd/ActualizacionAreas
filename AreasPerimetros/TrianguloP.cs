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
    public partial class TrianguloP : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public TrianguloP()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, btnCerrar_Click);

            pantalla = new PantallaManager(this);
        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Areas nuevaPantalla = new Areas();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            float l1, l2, l3, res;
            l1 = float.Parse(ladoUno.Text);
            l2 = float.Parse(ladoDos.Text);
            l3 = float.Parse(ladoTres.Text);
            res = l1 + l2 + l3;
            resultadoTxt.Text = res.ToString();
        }
    }
}
