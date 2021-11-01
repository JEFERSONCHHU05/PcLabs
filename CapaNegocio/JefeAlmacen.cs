using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefeAlmacen : Persona
    {
        //Atributos de la clase
        private string sector;
        private string cargo;
        private string profession;
        public string Profession;

        //Propiedades de la clase
        public string Sector { get => sector; set => sector = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Professioon { get => profession; set => profession = value; }
        //Metodos de la clase
        public string Pagar()
        {
            return "El metodo pagar no ha sido implementado";
        }
        public string Supervisar()
        {
            return "El metodo supervisar no ha sido implementado";
        }
        public string Manejar()
        {
            return "El metodo manejar no ha sido implementado";
        }
        public string Operar()
        {
            return "El metodo operar no ha sido implementado";
        }
    }
}
