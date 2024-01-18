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

        private const int HORAS_SEMANALES = 35;

        private const float INCR_EXTRA = 1.5f;




        private const float SALARIO_MAX = 22.5f;

        private const float SALARIO_MIN = 1.0f;


        // MIEMBROS - CAMPOS - ATRIBUTOS

        public string? nombre;
        public string? apellidos;
        public string? puesto;

        private int _horasTrabajadas;
        private float _salarioHora;
     
        // Datos Calculados
        private int _horasExtra;    // Protección: No permitir establecer nigún valor externo
        private float _salarioExtra;
        private float _salarioBase;
        private float _salarioBruto;
        public float impuestos;
        public float salarioNeto;

        // PROPIEDADES (Las propiededas siempren empiezan por mayuscula, sin parentesis)

        /// <summary>
        /// Horas trabajadas
        /// </summary>
        public int HorasTrabajadas
        {
            get // Se activa cuando se consulta e valor del miembro |Devolver el valor del miembro privado
                // Resultado = ----.HorasTrabajadas - 10;
            {

                if (_horasExtra == null) throw new Exception($"No se a establecido las horas trabajadas");

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

        /// <summary>
        /// Salario que percibe el trabajador por hora trabajada
        /// </summary>
        public float SalarioHora
        {
            get 
            {
                // Comprobacipnes
                if (_salarioHora == 0) throw new Exception("Salario no establecido");
                // Devolución del valor del miembro asociado
                return _salarioHora;
            }
            set
            {
                //Validación del dato proporcionado SOLO EL DATO PROPORCIONADO
                // Comprobación 1: Horas no superiores al límite
                if (value > SALARIO_MAX) throw new Exception($"Horas {value} son superiores al {SALARIO_MAX}");
                // Comprobación 2: Horas inferiores o iguales a 1
                if (value <= SALARIO_MIN) throw new Exception($"Horas inferiores o iguales a {MINIMO_HORAS}");

                // Establecer el valor al miembro asociado

                _salarioHora = value;
            } 
        }

        /// <summary>
        /// Horas extra
        /// </summary>
        public int HorasExtra
        {

            get     // Lectura
            {
                CalcularHorasExtra();
                return _horasExtra;
            }

        }


        public float SalarioExtra
        {
            get
            {
                CalcularSalarioExtra();
                return _salarioExtra;
            }

        }


        public float SalarioBase
        {
            get
            {
                CalculaarSalarioBase();
                return _salarioBase;
            }
        }

        public float SalarioBruto
        {
            get
            {
                CalcularSalarioBruto();
                return _salarioBruto;
            }



        }

        // MÉTODOS PRIVADOS
        /// <summary>
        /// Cálculo de las horas Extra del Trabajajdor
        /// </summary>s
        private void CalcularHorasExtra()
        {
            // RECURSOS LOCALES

            // PROCESO

            //// V1 SIN PROTECCIÓON
            //if (_horasTrabajadas > HORAS_SEMANALES) _horasExtra = _horasTrabajadas - HORAS_SEMANALES;
            //else _horasExtra = 0;

            // V2 CON PROTECCIÓN Si no tenemos las horas extra y las horas trabajadas no se hará el calculo

            if (HorasTrabajadas > HORAS_SEMANALES) _horasExtra = HorasTrabajadas - HORAS_SEMANALES;
            else _horasExtra = 0;
        }


        /// <summary>
        /// Cálculo del Salario Extra del trabajador
        /// </summary>
        private void CalcularSalarioExtra()
        {
            _salarioExtra = HorasExtra * SalarioHora * INCR_EXTRA;
        }

        /// <summary>
        /// Calcuulo del salario base del trabajador
        /// </summary>
        private void CalculaarSalarioBase()
        {

            if (HorasTrabajadas > HORAS_SEMANALES) _salarioBase = HORAS_SEMANALES * SalarioHora;
            else _salarioBase = HorasTrabajadas * SalarioHora;

        }

        private void CalcularSalarioBruto()
        {
            _salarioBruto = SalarioBase + SalarioExtra;

        }


    }
}
// 18:04