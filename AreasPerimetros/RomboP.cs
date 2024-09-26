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
    public partial class RomboP : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public RomboP()
        {
            InitializeComponent();
            boton = new BotonBorrar(this, BtnCerrar_Click);
            pantalla = new PantallaManager(this);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Perimetros nuevaPantalla = new Perimetros();
            pantalla.CargarPantalla(nuevaPantalla);
        }
        private void calcularBtn_Click(object sender, EventArgs e)
        {
            double lado, res;
            lado = double.Parse(ladoTxt.Text);
            res = lado * 4;
            resultadoTxt.Text = res.ToString();
        }
    }
}
