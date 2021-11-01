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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Tecnico tecnico = new Tecnico();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string profesion = txtProfesion.Text.Trim();
            string nroRegistro = txtNroRegistro.Text.Trim();
            string funcion = txtFuncion.Text.Trim();
            // Escribir los datos del tecnico en el objeto
            tecnico.Apellidos = apellidos;
            tecnico.Nombres = nombres;
            tecnico.FechaNac = fechaNac;
            tecnico.Celular = celular;
            tecnico.Correo = correo;
            tecnico.Profesion = profesion;
            tecnico.NroRegistro = nroRegistro;
            tecnico.Funcion = funcion;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtFechaNac.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtProfesion.Clear();
            txtNroRegistro.Clear();
            txtFuncion.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = tecnico.Apellidos;
            string nombres = tecnico.Nombres;
            string fechaNac = tecnico.FechaNac;
            string celular = tecnico.Celular;
            string correo = tecnico.Correo;
            string profesion = tecnico.Profesion;
            string nroRegistro = tecnico.NroRegistro;
            string funcion = tecnico.Funcion;
            MessageBox.Show("Datos del Tecnico:" + "\n" + "Apellidos:" + apellidos + "\n" +
                            "Nombres:" + nombres + "\n" + "FechaNacimiento:" + fechaNac + "\n" +
                            "Celular:" + celular + "\n" + "Correo:" + correo + "\n" + "Profession:" + profesion + "\n" +
                            "NumeroRegistro:" + nroRegistro + "\n" + "Funcion:" + funcion);
        }
        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(tecnico.Trabajar());
        }
        private void btnComer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Comer());
        }
        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Aprender());
        }
        private void btnAyudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Ayudar());
        }
        private void btnArreglar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Arreglar());
        }
        private void btnInspeccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Inspeccionar());
        }
        private void btnIndagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Indagar());
        }
        private void btnPlanear_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tecnico.Planear());
        }
    }
}
