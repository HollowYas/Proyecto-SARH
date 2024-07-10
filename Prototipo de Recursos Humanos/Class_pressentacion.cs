using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Prototipo_de_Recursos_Humanos
{
    class Class_pressentacion
    {

        string[] imagenes = new string[5];
        int i;

        public void cargar_imagenes(PictureBox img)
        {
            //fijarse bien en la ruta y hacer un cambio si fuese necesario a lahora de presentar en la universidad
            imagenes[0] = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngadmin.PNG";
            imagenes[1] = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngproduccion.PNG";
            imagenes[2] = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngrrhh.PNG";
            imagenes[3] = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngsistemas.PNG";
            imagenes[4] = @"C:\Users\admin\Desktop\isaac\año 2024\Geometria Computarizada\trabajo de SARH\Prototipo de Recursos Humanos\Prototipo de Recursos Humanos\Resources\pngventas.PNG";

        }

        public void cambio_adelante(PictureBox img)
        {
            i++;
            if (i > 4)
            {
                i = 0;
            }

            img.ImageLocation = imagenes[i];

        }

        public void cambio_atras(PictureBox img)
        {
            i--;
            if (i == 0)
            {
                i = 4;
            }

            img.ImageLocation = imagenes[i];

        }

    }
}
