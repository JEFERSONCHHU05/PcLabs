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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private JefeAlmacen jefeAlamacen = new JefeAlmacen();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string sector = txtSector.Text.Trim();
            string cargo = txtCargo.Text.Trim();
            string profession = txtProfession.Text.Trim();
            // Escribir los datos del jefeAlmacen en el objeto
            jefeAlamacen.Apellidos = apellidos;
            jefeAlamacen.Nombres = nombres;
            jefeAlamacen.FechaNac = fechaNac;
            jefeAlamacen.Celular = celular;
            jefeAlamacen.Correo = correo;
            jefeAlamacen.Sector = sector;
            jefeAlamacen.Cargo = cargo;
            jefeAlamacen.Profession = profession;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtFechaNac.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtSector.Clear();
            txtCargo.Clear();
            txtProfession.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = jefeAlamacen.Apellidos;
            string nombres = jefeAlamacen.Nombres;
            string fechaNac = jefeAlamacen.FechaNac;
            string celular = jefeAlamacen.Celular;
            string correo = jefeAlamacen.Correo;
            string sector = jefeAlamacen.Sector;
            string cargo = jefeAlamacen.Cargo;
            string profession = jefeAlamacen.Profession;
            MessageBox.Show("Datos del JefeAlmacen:" + "\n" + "Apellidos:" + apellidos + "\n" +
                            "Nombres:" + nombres + "\n" + "FechaNacimiento:" + fechaNac + "\n" +
                            "Celular:" + celular + "\n" + "Correo:" + correo + "\n" + "Sector:" + sector + "\n" +
                            "Cargo:" + cargo + "\n" + "Profession:" + profession);
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(jefeAlamacen.Trabajar());
        }
        private void btnComer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Comer());
        }
        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Aprender());
        }
        private void btnAyudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Ayudar());
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Pagar());
        }
        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Supervisar());
        }
        private void btnManejar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Manejar());
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefeAlamacen.Operar());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
