using System;
using System.Collections.Generic;
using Clase3.Ejercicio_1;
using Clase3.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            Moto moto = new Moto("Honda", "CBR");
            Auto auto = new Auto("Toyota", "Corolla");
            ImprimirDatosVehiculo(moto);
            ImprimirDatosVehiculo(auto);
            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca

            Biblioteca biblioteca = new Biblioteca();
            List<string> libros = biblioteca.ObtenerLibros();

            Console.WriteLine("Lista de libros en la biblioteca:");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
            Console.ReadLine();
            #endregion
        }
        
        static void ImprimirDatosVehiculo(Vehiculo vehiculo)
        {
            Console.WriteLine($"Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}");

        }
       
     }
}
