﻿using System;
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
    public partial class Tiangulo : Form
    {
        private PantallaManager pantalla;
        private BotonBorrar boton;
        public Tiangulo()
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
            float bas, alt, res = 0;
            alt = float.Parse(alturaTxt.Text);
            bas = float.Parse(baseTxt.Text);
            res = (bas * alt) / 2;
            resultadoTxt.Text = res.ToString();
        }
    }
}
