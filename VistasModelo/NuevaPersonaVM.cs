using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT6_2_Aplicaciones_con_más_de_una_vista.Servicios;

namespace UT6_2_Aplicaciones_con_más_de_una_vista.VistasModelo
{
    class NuevaPersonaVM : ObservableObject
    {
        //Servicios
        private AbrirVentanaServicio abrirVentanaServicio;

        //Comandos
        public RelayCommand AceptarCommand { get; }
        public RelayCommand AddNacionalidadCommand{ get; }

        //Propiedades
        private ObservableCollection<String> listaNacionalidades;

        public ObservableCollection<String> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { listaNacionalidades = value; }
        }


        public NuevaPersonaVM()
        {
            //Servicios
            abrirVentanaServicio = new AbrirVentanaServicio();

            //Comandos
            AceptarCommand = new RelayCommand(Aceptar);
            AddNacionalidadCommand = new RelayCommand(AddNacinalidad);

            //Propiedades
            ListaNacionalidades = RellenarNacionalidades();
        }

        private void Aceptar()
        {

        }

        private void AddNacinalidad()
        {
            abrirVentanaServicio.AbrirAddNacionalidad();
        }

        private ObservableCollection<string> RellenarNacionalidades()
        {
            ObservableCollection<String> listaNacionalidades = new ObservableCollection<string>();
            listaNacionalidades.Add("Española");
            listaNacionalidades.Add("Alemana");
            listaNacionalidades.Add("Portuguesa");
            listaNacionalidades.Add("Italiana");
            listaNacionalidades.Add("China");
            return listaNacionalidades;
        }
    }
}
