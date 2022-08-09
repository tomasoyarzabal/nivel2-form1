using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2
{
    public partial class pantalla : Form
    {
        public pantalla()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellido = textBox2.Text;
            listnombres.Items.Add(nombres);
            listnombres.Items.Add(apellido);
                

        }

        private void pantalla_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ronjo");
            comboBox1.Items.Add("negro");
            comboBox1.Items.Add("amarillo");
            comboBox1.Items.Add("blanco");
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellido = textBox2.Text;
            DateTime fecha = fechadenacimiento.Value;
            //operador ternario.
            string chocolate = botonchocolate.Checked == true ? "le gusta el chocolate" : "no le gusta el chocolate";
            string sexo;
            if (botonfemenino.Checked)
                sexo = "femenino";
            else if (botonmasculino.Checked)
                sexo = "masculino";
            else
                sexo = "otro";
            string colorfavorito = comboBox1.SelectedItem.ToString();
            string mensaje = chocolate + " su sexo es  " + sexo + " su color favorito es " + colorfavorito;
            MessageBox.Show(" su nombre es " + nombres + " "+ apellido + " su fecha de nacimiento es " + fecha + mensaje );
            
            
        }
    }
}
