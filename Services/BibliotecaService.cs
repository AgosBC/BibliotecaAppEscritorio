using Services.libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services
{
    public class BibliotecaService : Librery // hereda de la clase que contiene dentro objetos de libreria (textBoxEvent, Upload img etc) 
    {
        private List<TextBox> listTextBox;

        public BibliotecaService(List<TextBox> listTextBox)
        {
            this.listTextBox = listTextBox;
        }
    }
}
