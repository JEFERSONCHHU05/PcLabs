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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Vendedor vendedor = new Vendedor();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string lugar = txtLugar.Text.Trim();
            string cargo = txtCargo.Text.Trim();
            string tiempo = txtTiempo.Text.Trim();
            // Escribir los datos del vendedor en el objeto
            vendedor.Apellidos = apellidos;
            vendedor.Nombres = nombres;
            vendedor.FechaNac = fechaNac;
            vendedor.Celular = celular;
            vendedor.Correo = correo;
            vendedor.Lugar = lugar;
            vendedor.Cargo = cargo;
            vendedor.Tiempo = tiempo;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtFechaNac.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtLugar.Clear();
            txtCargo.Clear();
            txtTiempo.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = vendedor.Apellidos;
            string nombres = vendedor.Nombres;
            string fechaNac = vendedor.FechaNac;
            string celular = vendedor.Celular;
            string correo = vendedor.Correo;
            string lugar = vendedor.Lugar;
            string cargo = vendedor.Cargo;
            string tiempo = vendedor.Tiempo;
            MessageBox.Show("Datos del vendedor:" + "\n" + "Apellidos:" + apellidos + "\n" +
                            "Nombres:" + nombres + "\n" + "FechaNacimiento:" + fechaNac + "\n" +
                            "Celular:" + celular + "\n" + "Correo:" + correo + "\n" + "Lugar:" + lugar + "\n" +
                            "Cargo:" + cargo + "\n" + "Tiempo:" + tiempo);
        }
        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(vendedor.Trabajar());
        }
        private void btnComer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Comer());
        }
        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Aprender());
        }
        private void btnAyudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Ayudar());
        }
        private void btnCaminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Caminar());
        }
        private void btnOfrecer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Ofrecer());
        }
        private void btnRepartir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Repartir());
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Vender());
        }
    }
}
