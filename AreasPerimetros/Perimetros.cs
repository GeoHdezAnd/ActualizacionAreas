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
    public partial class Perimetros : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Perimetros()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, btnCerrar_Click);
            pantalla = new PantallaManager(this);
        }

        private void btnCuadradoP_Click(object sender, EventArgs e)
        {
            CuadradoP nuevaPantalla = new CuadradoP();
            pantalla.CargarPantalla(nuevaPantalla);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 nuevaPantalla = new Form1();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void btnTrianguloP_Click(object sender, EventArgs e)
        {
            TrianguloP nuevaPantalla = new TrianguloP();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            RectanguloP nuevaPantalla = new RectanguloP();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void circuloBtn_Click(object sender, EventArgs e)
        {
            RectanguloP nuevaPantalla = new RectanguloP();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void romboBtn_Click(object sender, EventArgs e)
        {
            RomboP nuevaPantalla = new RomboP();
            pantalla.CargarPantalla(nuevaPantalla);
        }
    }
}
