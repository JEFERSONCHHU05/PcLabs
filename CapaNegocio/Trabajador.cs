using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Trabajador : Persona
    {
        //Atributos de la clase
        private string puestoTrabajo;
        private string experienciaLab;
        private string nroCardex;
        //Propiedades de la clase
        public string PuestoTrabajo { get => puestoTrabajo; set => puestoTrabajo = value; }
        public string ExperienciaLab { get => experienciaLab; set => experienciaLab = value; }
        public string NroCardex { get => nroCardex; set => nroCardex = value; }
        //Metodos de la clase
        public string Ordenar()
        {
            return "El metodo ordenar no ha sido implementado";
        }
        public string Coordinar()
        {
            return "El metodo coordinar no ha sido implementado";
        }
        public string Indagar()
        {
            return "El metodo indagar no ha sido implementado";
        }
        public string Cargar()
        {
            return "El metodo cargar no ha sido implementado";
        }
    }
}
