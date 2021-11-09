using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services.libreria
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs evento)
        {
           
            // condicional que nos permita ingresar dato de tipo texto

            if (char.IsLetter(evento.KeyChar))
            {
                evento.Handled = false;
            }
            //condicion que permite no dar salto de linea cuando se oprima enter
            else if(evento.KeyChar == Convert.ToChar(Keys.Enter))
            { evento.Handled = true; } // Niega el acceso a la tecla enter
            // condicion para usar la tecla backspace
            else if (char.IsControl(evento.KeyChar)) { evento.Handled = false; }
            //tecla espacio. permitir
            else if (char.IsSeparator(evento.KeyChar)) { evento.Handled = false; }
            //si no es ninguna de las anteriores que no permita ingresar el dato
            else { evento.Handled = true;}

            
        }

        public void numberKeyPress(KeyPressEventArgs evento)
        {

            // condicional que nos permita ingresar dato de tipo texto

            if (char.IsDigit(evento.KeyChar)){evento.Handled = false;}
            //condicion que permite no dar salto de linea cuando se oprima enter
            else if (evento.KeyChar == Convert.ToChar(Keys.Enter))
            { evento.Handled = true; } // Niega el acceso a la tecla enter
            else if (char.IsLetter(evento.KeyChar)) { evento.Handled = true;}
            // condicion para usar la tecla backspace
            else if (char.IsControl(evento.KeyChar)) { evento.Handled = false; }
            //tecla espacio. permitir
            else if (char.IsSeparator(evento.KeyChar)) { evento.Handled = false; }
            //si no es ninguna de las anteriores que no permita ingresar el dato
            else { evento.Handled = true; }


        }
    }
}
