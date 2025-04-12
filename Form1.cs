
using miformulario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miformulario
{
    public partial class Form1 : Form
    {
        Crud MiCrud = new Crud();
        public Form1()
        {
            InitializeComponent();
        }
          private void buttonSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOla te saludo desde el formulario 👊👊👊");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxEstudiante.Text = MiCrud.MostrarInformacion(textBoxCarnet.Text);  
            textBoxNotas.Text = MiCrud.MostrarTareas(textBoxCarnet.Text);
            textBoxSeccion.Text = MiCrud.MostrarInformacionSeccion(textBoxCarnet.Text);
            textBoxEmail.Text = MiCrud.MostrarInformacionCorreo(textBoxCarnet.Text);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxEmail.Text;
            string seccion = textBoxSeccion.Text;
            string respuesta = MiCrud.AgregarAlumno(carnet,nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            textBoxEstudiante.Text = MiCrud.MostrarInformacion(textBoxCarnet.Text);
            textBoxNotas.Text = MiCrud.MostrarTareas(textBoxCarnet.Text);
            textBoxSeccion.Text = MiCrud.MostrarInformacionSeccion(textBoxCarnet.Text);
            textBoxEmail.Text = MiCrud.MostrarInformacionCorreo(textBoxCarnet.Text);
        }

        private void buttonCrear_Click_1(object sender, EventArgs e)
        {

            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxEmail.Text;
            string seccion = textBoxSeccion.Text;
            string respuesta = MiCrud.AgregarAlumno(carnet, nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        private void buttonSaludar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("HOla te saludo desde el formulario 👊👊👊");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

