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
    public partial class Form1 : Form
    {
        private PantallaManager pantalla; // Ponemos el valor de la clase en un privado para que sea usado en todo el codigo de aqui
        public Form1()
        {
            InitializeComponent();
             pantalla = new PantallaManager(this);
        }
        // Funcion para cambiar de pantalla a Areas
        private void btnAreas_Click(object sender, EventArgs e)
        {
            Areas nuevaPantalla = new Areas();
            pantalla.CargarPantalla(nuevaPantalla);
        }

        private void btnPerimeteros_Click(object sender, EventArgs e)
        {
            Perimetros nuevaPantalla = new Perimetros();
            pantalla.CargarPantalla(nuevaPantalla);
        }
    
    }
}
