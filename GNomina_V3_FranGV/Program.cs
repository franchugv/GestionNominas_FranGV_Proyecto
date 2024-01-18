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

            

            // Calculo del Salario Base
            nominaEmpleado.salarioBase = CalculosNomina.SalarioBase(nominaEmpleado.HorasTrabajadas, nominaEmpleado.SalarioHora);

            // Calculo salario extra
            nominaEmpleado.SalarioExtra = CalculosNomina.SalarioExtra(nominaEmpleado.HorasExtra, nominaEmpleado.SalarioHora);

            // Cálculo del Salario Bruto
            nominaEmpleado.salarioBruto = CalculosNomina.SalarioBruto(nominaEmpleado.salarioBase, nominaEmpleado.salarioExtra);

            // Cálculo de los Impuestos
            nominaEmpleado.impuestos = CalculosNomina.Impuestos(nominaEmpleado.salarioBruto);

            // Cálculo del Salario Neto
            nominaEmpleado.salarioNeto = CalculosNomina.SalarioNeto(nominaEmpleado.salarioBruto, nominaEmpleado.impuestos);



            // SALIDA

            Interfaz.MostrarNomina(nominaEmpleado);


        }
    }
}