using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaAppEscritorio
{
    public partial class Form1 : Form
    {
        private BibliotecaService biblioService = new BibliotecaService(); //declaro bibloteca service
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            biblioService.uploadImg.cargarImagen(PBImagen);//llamo al metodo cargarImagen de biblioservice y el parametro es el nombre que indique en el diseño
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LAñadirL_Click(object sender, EventArgs e)
        {

        }

        private void GBAñadirL_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TBTitulo_TextChanged(object sender, EventArgs e)//verificar los cambios del campo de texto
        {
            if (TBTitulo.Text.Equals(""))//.Text obtiene datos del campo de texto
            {
                LTitulo.ForeColor = Color.Black; // defino un color para la label LTitulo CUANDO ESTE VACIO

            }else
            {
                LTitulo.ForeColor = Color.Green;//cuando empiezo a escribir, el label de titulo se pondra en verde
                LTitulo.Text = "Titulo"; 
            }
        }

        private void TBTitulo_KeyPress(object sender, KeyPressEventArgs e)//obtiene la info del teclado
        {
            
        }

        private void TBAutor_TextChanged(object sender, EventArgs e)
        {
            if (TBAutor.Text.Equals(""))
            {
                LAutor.ForeColor = Color.Black; 

            }
            else
            {
                LAutor.ForeColor = Color.Green;
                LAutor.Text = "Autor";
                TBAutor.ForeColor = Color.Black;
                TBAutor.Font = new Font("Corbel", 11.0f, FontStyle.Regular);
            }

        }

        private void TBAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            biblioService.textBoxEvent.textKeyPress(e);
        }

        private void TBSerie_TextChanged(object sender, EventArgs e)
        {
            if (TBSerie.Text.Equals(""))
            {
                LSerie.ForeColor = Color.Black;

            }
            else
            {
                LSerie.ForeColor = Color.Green;
                LSerie.Text = "Serie";
            }

        }

        private void TBSerie_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBNum_TextChanged(object sender, EventArgs e)
        {
            if (TBNum.Text.Equals(""))
            {
                LNum.ForeColor = Color.Black;

            }
            else
            {
                LNum.ForeColor = Color.Green;
                LNum.Text = "#";
            }

        }

        private void TBNum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {

            if (TBApellido.Text.Equals(""))
            {
                TBApellido.ForeColor = Color.LightGray;

            }
            else
            {
                TBApellido.ForeColor = Color.Black;
                TBApellido.Font = new Font("Corbel", 11.0f, FontStyle.Regular);
                

            }

        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            biblioService.textBoxEvent.textKeyPress(e);

        }

        private void TBAutor_StyleChanged(object sender, EventArgs e)
        {
        }

        
    }
}
