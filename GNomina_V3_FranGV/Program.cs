using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GNomina_V3_FranGV
{
    /// <summary>
    /// Objetivo V3: Dotaar de Proteción y Seguiridad a la Clase
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            // CONSTANTES


            // RECURSOS
            Nomina nominaEmpleado;  


            // INICIALIZACIÓN
            nominaEmpleado = new Nomina();

            // ENTRADA 

            // SOLICITAR CADENAS (NOMBRBE, APELLIDOS Y PUESTO)

            nominaEmpleado.nombre = Interfaz.LeerCadena("nombre");
            nominaEmpleado.apellidos = Interfaz.LeerCadena("apellidos");
            nominaEmpleado.puesto = Interfaz.LeerCadena("puesto");
            // SOLICITAR HORAS
            // Horas trabajadas
            nominaEmpleado.HorasTrabajadas = Interfaz.LeerHorasTrabajadas("horas trabajadas", nominaEmpleado);

            // Captación salario hora
            nominaEmpleado.SalarioHora = Interfaz.LeerSalarioHoras("salario hora", nominaEmpleado);









            // PROCESO
            // Calculo de las Horas

           

            // Cálculo del Salario Bruto
            nominaEmpleado.salarioBruto = CalculosNomina.SalarioBruto(nominaEmpleado.SalarioBase, nominaEmpleado.SalarioExtra);

            // Cálculo de los Impuestos
            nominaEmpleado.impuestos = CalculosNomina.Impuestos(nominaEmpleado.salarioBruto);

            // Cálculo del Salario Neto
            nominaEmpleado.salarioNeto = CalculosNomina.SalarioNeto(nominaEmpleado.salarioBruto, nominaEmpleado.impuestos);



            // SALIDA


            // SALIDA
            // Se ha determinado subdividir la salida en varios métodos para facilitar la 
            // Legibilidad del código y simplificar el número de parámetros por método
            Interfaz.MostrarEmpleado(nominaEmpleado.nombre, nominaEmpleado.apellidos, nominaEmpleado.puesto);
            Interfaz.MostrarLinea();
            Interfaz.MostrarDatosSemana(nominaEmpleado.HorasTrabajadas, nominaEmpleado.HorasExtra, nominaEmpleado.SalarioHora);
            Interfaz.MostrarLinea();
            Interfaz.MostrarHonorarios(nominaEmpleado.SalarioBase, nominaEmpleado.SalarioExtra);
            Interfaz.MostrarLinea();
            Interfaz.MostrarNomina(nominaEmpleado.salarioBruto, nominaEmpleado.impuestos, nominaEmpleado.salarioNeto);

        }
    }
}