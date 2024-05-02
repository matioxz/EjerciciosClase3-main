using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
        public abstract class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }

            public Vehiculo(string marca, string modelo)
            {
                Marca = marca;
                Modelo = modelo;
            }
        }
   

}