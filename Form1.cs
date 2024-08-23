using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Concatenar el contenido de los TextBoxs correspondientes al apellido y nombre
            string apellido = LApellido.Text; // Supongamos que el TextBox del apellido se llama "LApellido"
            string nombre = LNombre.Text; // Supongamos que el TextBox del nombre se llama "LNombre"

            // Mostrar el resultado concatenado en el tercer TextBox (multilinea)
            textBoxMultiline.Text = apellido + " " + nombre;


        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBoxMultiline.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
