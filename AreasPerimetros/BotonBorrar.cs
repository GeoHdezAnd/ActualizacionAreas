using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasPerimetros
{
    public class BotonBorrar
    {
        // Creamos la variable para guardar el boton
        private Button btnCerrar;
        private Form _mainform;
        private EventHandler evento;
        public BotonBorrar(Form form, EventHandler evento)
        {
            btnCerrar = new Button();
            _mainform = form;
            ConfigurarBoton(_mainform, evento);
            _mainform.Controls.Add(btnCerrar);
        }

        public void ConfigurarBoton(Form form, EventHandler btnCerrar_Click)
        {
            btnCerrar.Text = "X";
            btnCerrar.Size = new Size(30, 30);   // Tamaño del botón
            btnCerrar.Location = new Point(form.Width - 60, 15); // Posición en la esquina superior derecha
            btnCerrar.BackColor = Color.Red;     // Color de fondo
            btnCerrar.ForeColor = Color.White;   // Color del texto
            btnCerrar.FlatStyle = FlatStyle.Flat; // Estilo plano
            btnCerrar.Font = new Font("Arial", 12, FontStyle.Bold); // Fuente

            btnCerrar.Click += new EventHandler(btnCerrar_Click);

            form.Resize += (sender, e) => {
                btnCerrar.Location = new Point(form.Width - 60, 15);
            };
        }
    }
}
