using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BuenasPracticas2
{
    /// <summary>
    /// Clase estática para trabajar con fechas
    /// </summary>
    public static class Fechas
    {
        /// <summary>
        /// Método estático el cual devuelve eldia de la semana de la fecha pasada por parámetro, en caso de que no haya nada devolverá la cadena "Error"
        /// </summary>
        /// <param name="fecha">Fecha a consultar</param>
        /// <returns>STRING</returns>
        
        #region Métodos
        public static string diaSemana(DateTime? fecha)
        {
            if (fecha.HasValue)
            {
                return fecha.Value.DayOfWeek.ToString();
            }
            else
            {
                return "Error";
            }
        }

        /// <summary>
        /// Calcula los dias que faltan entre la fecha actual y la fecha dada por parámetro
        /// </summary>
        /// <param name="fecha">Fecha a consultar</param>
        /// <returns>DOUBLE (REDONDEADO)</returns>
        public static double cuantoFalta(DateTime fecha)
        {
            DateTime fecha2 = DateTime.Now;
            return Math.Round((fecha - fecha2).TotalDays);
        }
    }
}
