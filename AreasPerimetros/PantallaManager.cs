using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AreasPerimetros
{
    public class PantallaManager
    {

        private Form _mainForm; // Valor para el formulario principal
        // Constructor que recibe el formulario
        public PantallaManager(Form mainForm)
        {
            _mainForm = mainForm;
        }
        // Metodo para cargar los formularios en el cointenedor del formulario
        public void CargarPantalla(Form nuevaPantalla) // Recibe la nueva pantalla
        {
            _mainForm.Controls.Clear(); // limpia los controles de la pantalla actual
            nuevaPantalla.TopLevel = false; // da negatico a que la nueva pantalla este en el top level de los formualrios
            nuevaPantalla.FormBorderStyle = FormBorderStyle.None; // Quita el borde de la pantalla
            nuevaPantalla.Dock = DockStyle.Fill; // Ajusta la pantalla gracias a dock que establece que los bordes del control se ajustaran al control primario
            _mainForm.Controls.Add(nuevaPantalla);// añade los controles de la nueva pantalla
            nuevaPantalla.Show(); // Muestra la nueva pantalla
        }
    }
}