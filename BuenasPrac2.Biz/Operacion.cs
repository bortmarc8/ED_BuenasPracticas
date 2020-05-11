using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenasPracticas2
{
    /// <summary>
    /// Clase Hecha para hacer operaciones con números
    /// </summary>
    public class Operacion
    {
        #region Atributos
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private int num1;
        private int num2;
        private string fecha;

        #region Constructor
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public Operacion(int n1,int n2)
        {
            num1 = n1;
            num2 = n2;
            fecha = Fechas.diaSemana(Convert.ToDateTime(DateTime.Now));
        }

        #region Métodos
        /// <summary>
        /// Se encarga de sumar los dos parámetros
        /// </summary>
        /// <returns>INT</returns>
        public int sumar()
        {
            return num1 + num2;
        }

        /// <summary>
        /// Se encarga de restar los dos números (el menor al mayor para que no quede negativo)
        /// </summary>
        /// <returns>INT</returns>
        public int restar()
        {
            if (cualEsMayor() == num1)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }

        /// <summary>
        /// Se encarga de multiplicar los dos atributos
        /// </summary>
        /// <returns>INT</returns>
        public int multiplicar()
        {
            return num1 * num2;
        }

        /// <summary>
        /// Compara los dos atributos para detectar cual es el mayor
        /// </summary>
        /// <returns>INT</returns>
        public int cualEsMayor()
        {
            if (num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }
    }
}
