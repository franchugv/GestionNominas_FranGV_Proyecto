namespace GNomina_V3_FranGV
{
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

            nominaEmpleado.salarioHora = Interfaz.LeerSalarioHoras("salario hora");
            nominaEmpleado.horasTrabajadas = Interfaz.LeerHorasTrabajadas("horas trabajadas");

            
            Interfaz.MostrarNomina(nominaEmpleado);



            // PROCESO


            // SALIDA

        }
    }
}