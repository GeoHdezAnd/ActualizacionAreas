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
    public partial class CirculoP : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public CirculoP()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, BtnCerrar_Click);
            pantalla = new PantallaManager(this);
        }
        public void BtnCerrar_Click(object sender, EventArgs e)
        {
            Perimetros nuevaPantalla = new Perimetros();
            pantalla.CargarPantalla(nuevaPantalla);
        }
        private void calcularBtn_Click(object sender, EventArgs e)
        {
            double radio, res;
            radio = double.Parse(radioTxt.Text);
            res = (Math.PI * 2) + radio;
            resultadoTxt.Text = res.ToString();
        }
    }
}
