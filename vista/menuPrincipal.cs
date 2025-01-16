using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaIMax.vista
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Para crear un controlador de formularios primero creamos el objeto del controlador(llamamos controlador  a una foma de controlar los formularios como vistas
             controles.Dock quiere decir o funciona para que el formulario se centre y expanada
            para usar el controlador de formularios hacemo uso de un elemento panel para dibujarlo 
            para ello usamos en el ejemplo panel2.control.add
            usando la funcioncion control y accediendo a la funcion add que lo que recibe e un objeto 
             
             */
            //controlForm controles=new controlForm();
            //controles.Dock = DockStyle.Fill;
            //panel2.Controls.Clear();
            //panel2.Controls.Add(controles);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {

        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            Personal controlPersonal = new Personal();
            controlPersonal.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(controlPersonal);
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
           paneldeBienvenida.Dock=DockStyle.Fill;
        }
    }
}
