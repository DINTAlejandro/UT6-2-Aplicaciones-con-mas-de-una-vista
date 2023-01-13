using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UT6_2_Aplicaciones_con_más_de_una_vista.Controles;
using UT6_2_Aplicaciones_con_más_de_una_vista.Modelos;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.Servicios
{
    class CargarControlServicio
    {
        public UserControl CargarNuevaPersona()
        {
            return new NuevaPersona();
        }

        public UserControl CargarListaPersonas(Persona personaSeleccionada)
        {
            if (personaSeleccionada == null)
                return new ListadoPersonas();
            else
                return new ListadoPersonas(personaSeleccionada);
        }
    }
}
