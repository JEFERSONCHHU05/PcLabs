using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        //Atributos de la clase
        private string apellidos;
        private string nombres;
        private string fechaNac;
        private string celular;
        private string correo;
        //Propiedades de la clase
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Correo { get => correo; set => correo = value; } 
        //Metodos de la clase
        public string Trabajar()
        {
            return "El metodo trabajar no ha sido implementado";
        }
        public string Comer()
        {
            return "El metodo comer no ha sido implementado";
        }
        public string Aprender()
        {
            return "El metodo aprender no ha sido implementado";
        }
        public string Ayudar()
        {
            return "El metodo ayudar no ha sido implementado";
        }
    }
}
