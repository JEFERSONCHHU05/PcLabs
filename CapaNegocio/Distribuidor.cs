using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Distribuidor : Persona 
    {
        //Atributos de la clase
        private string nroClientes;
        private string tipoCarro;
        private string repartosDia;
        //Propiedades de la clase
        public string NroClientes { get => nroClientes; set => nroClientes = value; }
        public string TipoCarro { get => tipoCarro; set => tipoCarro = value; }
        public string RepartosDia { get => repartosDia; set => repartosDia = value; }
        //Metodos de la clase
        public string Registrar()
        {
            return "El metodo registrar no ha sido implementado";
        }
        public string Distribuir()
        {
            return "El metodo distribuir no ha sido implementado";
        }
        public string Ordenar()
        {
            return "El metodo ordenar no ha sido implementado";
        }
        public string Prevenir()
        {
            return "El metodo prevenir no ha sido implementado";
        }
    }
}
