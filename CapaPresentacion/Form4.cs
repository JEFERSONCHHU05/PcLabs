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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        // Declarar un objeto a partir de la clase
        private Distribuidor distribuidor = new Distribuidor();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string nroClientes = txtNroClientes.Text.Trim();
            string tipoCarro = txtTipoCarro.Text.Trim();
            string repartosDia = txtRepartosDia.Text.Trim();
            // Escribir los datos del distribuidor en el objeto
            distribuidor.Apellidos = apellidos;
            distribuidor.Nombres = nombres;
            distribuidor.FechaNac = fechaNac;
            distribuidor.Celular = celular;
            distribuidor.Correo = correo;
            distribuidor.NroClientes = nroClientes;
            distribuidor.TipoCarro = tipoCarro;
            distribuidor.RepartosDia = repartosDia;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtFechaNac.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtNroClientes.Clear();
            txtTipoCarro.Clear();
            txtRepartosDia.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = distribuidor.Apellidos;
            string nombres = distribuidor.Nombres;
            string fechaNac = distribuidor.FechaNac;
            string celular = distribuidor.Celular;
            string correo = distribuidor.Correo;
            string nroClientes = distribuidor.NroClientes;
            string tipoCarro = distribuidor.TipoCarro;
            string repartosDia = distribuidor.RepartosDia;
            MessageBox.Show("Datos del distribuidor:" + "\n" + "Apellidos:" + apellidos + "\n" +
                            "Nombres:" + nombres + "\n" + "FechaNacimiento:" + fechaNac + "\n" +
                            "Celular:" + celular + "\n" + "Correo:" + correo + "\n" + "NumeroClientes:" + nroClientes + "\n" +
                            "TipoCarro:" + tipoCarro + "\n" + "RepartosDia:" + repartosDia);
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(distribuidor.Trabajar());
        }
        private void btnComer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Comer());
        }
        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Aprender());
        }
        private void btnAyudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Ayudar());
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Registrar());
        }
        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Distribuir());
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Ordenar());
        }
        private void btnPrevenir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Prevenir());
        }
    }
}
