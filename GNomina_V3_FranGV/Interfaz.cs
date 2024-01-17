using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GNomina_V3_FranGV
{
    public static class Interfaz
    {
        public static string? LeerCadena(string dato)
        {
            // RECURSOS
            string? cadena = null;
            bool esValido;
            

            // ENTRADA
        



            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca su {dato}: ");
                cadena = Console.ReadLine();


                try
                {
                    Comprobaciones.ValidarCadena(cadena);
                }
                catch(Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();


                }

            } while (!esValido);

            Console.WriteLine("Pulse ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();



            // SALIDA

            return cadena;
        }

        public static int LeerHorasTrabajadas(string dato)
        {


            // VARIABLES
            int horas = 0;
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {dato}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    horas = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception Error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Pulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (!esValido);

            // SALIDA - Método
            return horas;
        }

        public static void LeerHorasTrabajadas(string dato, Nomina objeto)
        {
            // VARIABLES
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {dato}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    objeto.HorasTrabajadas = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception Error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Pulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (!esValido);

        }


        public static float LeerSalarioHoras(string dato)
        {
            // VARIABLES
            float horas = 0;
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {dato}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    horas = Comprobaciones.ValidarSalarioHora(aux);
                }
                catch (Exception Error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Pulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (!esValido);

            // SALIDA - Método
            return horas;
        }

        public static float LeerSalarioHoras(string dato, Nomina objeto)
        {
            // VARIABLES
            float horas = 0;
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {dato}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    objeto.ho = Comprobaciones.ValidarSalarioHora(aux);
                }
                catch (Exception Error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Pulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (!esValido);

            // SALIDA - Método
            return horas;
        }




        public static void MostrarNomina(Nomina OBJ)
        {
            Console.WriteLine($"\tNombre: {OBJ.nombre}");
            Console.WriteLine($"\tApellidos: {OBJ.apellidos}");
            Console.WriteLine($"\tPuesto: {OBJ.puesto}");
            Console.WriteLine($"\tHoras trabajadas: {OBJ.HorasTrabajadas}");
            Console.WriteLine($"\tSalario Hora: {OBJ.SalarioHora}");


        }






    }
}

