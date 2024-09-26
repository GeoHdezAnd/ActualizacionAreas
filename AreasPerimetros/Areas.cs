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
    public partial class Areas : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Areas()
        {
            InitializeComponent();

            boton = new BotonBorrar(this, btnCerrar_Click);
            pantalla = new PantallaManager(this);
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado nuevaPantalla = new Cuadrado();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 nuevaPantalla = new Form1();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Tiangulo nuevaPantalla = new Tiangulo();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo nuevaPantalla = new Rectangulo();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void circuloBtn_Click(object sender, EventArgs e)
        {
            Circulo nuevaPantalla = new Circulo();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void romboBtn_Click(object sender, EventArgs e)
        {
            Rombo nuevaPantalla = new Rombo();
            pantalla.CargarPantalla(nuevaPantalla);
        }
    }
}
