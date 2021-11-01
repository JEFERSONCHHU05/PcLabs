using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void jefeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario jefeAlmacen
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario trabajador
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario vendedor
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void distribuidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario distribuidor
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void tecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario tecnico
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
