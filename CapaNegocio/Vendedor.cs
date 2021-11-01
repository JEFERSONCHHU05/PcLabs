using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vendedor : Persona
    {
        //Atributos de la clase
        private string lugar;
        private string cargo;
        private string tiempo;
        //Propiedades de la clase
        public string Lugar { get => lugar; set => lugar = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Tiempo { get => tiempo; set => tiempo = value; }
        //Metodos de la clase
        public string Caminar()
        {
            return "El metodo caminar no ha sido implementado";
        }
        public string Ofrecer()
        {
            return "El metodo ofrecer no ha sido implementado";
        }
        public string Repartir()
        {
            return "El metodo repartir no ha sido implementado";
        }
        public string Vender()
        {
            return "El metodo vender no ha sido implementado";
        }
    }
}
