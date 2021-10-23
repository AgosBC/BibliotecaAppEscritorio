using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services.libreria
{
    public class UploadImg
    {
        private OpenFileDialog fileDialog = new OpenFileDialog(); //ventana que podra usarse para buscar archivos en la pc

        public void cargarImagen(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true; // establece la propiedad WaitOnLoad que significa que la img se carga de manera sincronica
            fileDialog.Filter = "Imagenes|* .jpg;* .gif;* .png;* .bmp"; //elementos que vamos a filtrar para poder seleccionar en la picture box (imagenes en esos fomatos
            fileDialog.ShowDialog();

            if(fileDialog.FileName != String.Empty)
            {
                pictureBox.ImageLocation = fileDialog.FileName; //llamamos al objeto de tipo Picture box ImagLocation le pasa la localizacion de la img y la info file dialog
            }

        }
    }
}
