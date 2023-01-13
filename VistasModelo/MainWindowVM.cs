﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UT6_2_Aplicaciones_con_más_de_una_vista.Controles;
using UT6_2_Aplicaciones_con_más_de_una_vista.Modelos;
using UT6_2_Aplicaciones_con_más_de_una_vista.Servicios;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo
{
    class MainWindowVM : ObservableObject
    {
        //Servicios
        private CargarControlServicio cargarControlServicio;
        
        //Comandos
        public RelayCommand NuevaPersonaCommand { get; }
        public RelayCommand ListaPersonasCommand { get; }


        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return  personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }


        public MainWindowVM()
        {
            //Servicios
            cargarControlServicio = new CargarControlServicio();

            //Comandos
            NuevaPersonaCommand = new RelayCommand(CargarNuevaPersona);
            ListaPersonasCommand = new RelayCommand(CargarListadoPersonas);

            //Propiedades
            personaSeleccionada = null;
            ContenidoVista = null;
        }

        private void CargarNuevaPersona()
        {
            ContenidoVista = cargarControlServicio.CargarNuevaPersona();
        }

        private void CargarListadoPersonas()
        {
            ContenidoVista = cargarControlServicio.CargarListaPersonas(personaSeleccionada);
        }

    }
}
