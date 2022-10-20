using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoContribuyentes
{
    public  class Contribuyente
    {
        //Atributos
        string numeroDeCuenta;
        string nombre;
        string deuda;
        string mesPago;
        string planDePago;

        //Constructor Vacio
        public Contribuyente()
        {

        }

        //Getters y Setters
        public string NumeroDeCuenta { get; set; }
        public string Nombre { get; set; }
        public string Deuda { get; set; }
        public string MesPago { get; set; }
        public string PlanDePago { get; set; }
    }
}
