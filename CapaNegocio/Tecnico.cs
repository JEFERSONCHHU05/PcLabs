using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tecnico : Persona 
    {
        //Atributos de la clase
        private string profesion;
        private string nroRegistro;
        private string funcion;
        //Propiedades de la clase
        public string Profesion { get => profesion; set => profesion = value; }
        public string NroRegistro { get => nroRegistro; set => nroRegistro = value; }
        public string Funcion { get => funcion; set => funcion = value; }
        //Metodos de la clase
        public string Arreglar()
        {
            return "El metodo arreglar no ha sido implementado";
        }
        public string Inspeccionar()
        {
            return "El metodo inspeccionar no ha sido implementado";
        }
        public string Indagar()
        {
            return "El metodo indagar no ha sido implementado";
        }
        public string Planear()
        {
            return "El metodo planear no ha sido implementado";
        }
    }
}
