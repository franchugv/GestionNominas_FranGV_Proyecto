using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNomina_V3_FranGV
{
    public static class CalculosNomina
    {
      

        /// <summary>
        /// Cálculo de los Impuestos a aplicar
        /// </summary>
        /// <param name="bruto">Salario Bruto</param>
        /// <returns>Impuestos</returns>
        public static float Impuestos(float bruto)
        {
            // CONSTANTES
            const float PORCENTAJE_IMP = 0.16f;

            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return bruto * PORCENTAJE_IMP;
        }


        /// <summary>
        /// Cálculo del Salario Neto del Trabajador
        /// </summary>
        /// <param name="bruto">Salario Bruto</param>
        /// <param name="tasas">Impuestos a aplicar</param>
        /// <returns>Salario Neto</returns>
        public static float SalarioNeto(float bruto, float tasas)
        {
            // CONSTANTES
            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return bruto - tasas;
        }
    }
}
