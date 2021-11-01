using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Lamar a la capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Trabajador trabajador = new Trabajador();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string puestoTrabajo = txtPuestoTrabajo.Text.Trim();
            string experienciaLab = txtExperienciaLab.Text.Trim();
            string nroCardex = txtNroCardex.Text.Trim();
            // Escribir los datos del trabajador en el objeto
            trabajador.Apellidos = apellidos;
            trabajador.Nombres = nombres;
            trabajador.FechaNac = fechaNac;
            trabajador.Celular = celular;
            trabajador.Correo = correo;
            trabajador.PuestoTrabajo = puestoTrabajo;
            trabajador.ExperienciaLab = experienciaLab;
            trabajador.NroCardex = nroCardex;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtFechaNac.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtPuestoTrabajo.Clear();
            txtExperienciaLab.Clear();
            txtNroCardex.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = trabajador.Apellidos;
            string nombres = trabajador.Nombres;
            string fechaNac = trabajador.FechaNac;
            string celular = trabajador.Celular;
            string correo = trabajador.Correo;
            string puestoTrabajo = trabajador.PuestoTrabajo;
            string experienciaLab = trabajador.ExperienciaLab;
            string nrocardex = trabajador.NroCardex;
            MessageBox.Show("Datos del trabajador:" + "\n" + "Apellidos:" + apellidos + "\n" +
                            "Nombres:" + nombres + "\n" + "FechaNacimiento:" + fechaNac + "\n" +
                            "Celular:" + celular + "\n" + "Correo:" + correo + "\n" + "PuestoTrabajo:" + puestoTrabajo + "\n" +
                            "ExperienciaLaboral:" + experienciaLab + "\n" + "NumeroCardex:" + nrocardex);
        }
        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(trabajador.Trabajar());
        }
        private void btnComer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Comer());
        }
        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Aprender());
        }
        private void btnAyudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Ayudar());
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Ordenar());
        }
        private void btnCoordinar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Coordinar());
        }
        private void btnIndagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Indagar());
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trabajador.Cargar());
        }
    }
}
