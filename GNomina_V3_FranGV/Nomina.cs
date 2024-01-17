using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNomina_V3_FranGV
{
    public class Nomina
    {
        // CONSTANTES INTERNAS DE LA CLASE

        private const int LIMITE_HORAS = 60;

        private const int MINIMO_HORAS = 0;



        private const float SALARIO_MAX = 22.5f;

        private const float SALARIO_MIN = 1.0f;


        // MIEMBROS - CAMPOS - ATRIBUTOS

        public string? nombre;
        public string? apellidos;
        public string? puesto;

        private int _horasTrabajadas;
        private float _salarioHora;
     
        public int horasExtra;

        public float salarioExtra;
        public float salarioBase;
        public float salarioBruto;
        public float salarioNeto;

        public float impuestos;

        // PROPIEDADES (Las propiededas siempren empiezan por mayuscula, sin parentesis)

        public int HorasTrabajadas
        {
            get // Se activa cuando se consulta e valor del miembro |Devolver el valor del miembro privado
                // Resultado = ----.HorasTrabajadas - 10;
            {   
                return _horasTrabajadas;
            }
            set // Se activa cuando se le asigna a la Propiedad un valor
                // Ejemplo: -----.HorasTrabajadas = 34;
            {
                // Comprobación 1: Horas no superiores al límite
                if (value > LIMITE_HORAS) throw new Exception($"Horas {value} son superores al {LIMITE_HORAS}");
                // Comprobación 2: Horas inferiores o iguales a 0
                if (value <= MINIMO_HORAS) throw new Exception($"Horas inferiores o iguales a {MINIMO_HORAS}");



                _horasTrabajadas = value;
            }
        }

        public float SalarioHora
        {
            get 
            {
                if (_salarioHora == 0) throw new Exception("Salario no establecido");

                return _salarioHora;
            }
            set
            {
                // Comprobación 1: Horas no superiores al límite
                if (value > SALARIO_MAX) throw new Exception($"Horas {value} son superiores al {SALARIO_MAX}");
                // Comprobación 2: Horas inferiores o iguales a 1
                if (value <= SALARIO_MIN) throw new Exception($"Horas inferiores o iguales a {MINIMO_HORAS}");

            }
        }
        





    }
}
