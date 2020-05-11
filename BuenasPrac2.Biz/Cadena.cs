using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenasPracticas2
{
    /// <summary>
    /// Clase que permite trabajar con cadenas
    /// </summary>
    public class Cadena
    {
        #region Atributos
        /// <summary>
        /// Atributo string con el que vamos a trabajar
        /// </summary>
        public string cadena;

        #region Constructor
        /// <summary>
        /// Constructor de la clase, recibe un string y lo asigna al atruibuto cadena
        /// </summary>
        /// <param name="cad">STRING</param>
        public Cadena(string cad)
        {
            cadena = cad;
        }

        #region Métodos
        /// <summary>
        /// Devuelve el primer caracter de la cadena usada como atributo
        /// </summary>
        /// <returns>CHAR</returns>
        public char extraerPrimerCaracter()
        {
            return cadena[0];
        }

        /// <summary>
        /// Devuelve el caracter de la posición dada por parámetro
        /// </summary>
        /// <param name="i">INT</param>
        /// <returns>CHAR</returns>
        public char extraerCaracterPos(int i)
        {
            return cadena[i - 1];
        }

        /// <summary>
        /// Devuelve el último carácter de la cadena
        /// </summary>
        /// <returns>CHAR</returns>
        public char extraerUltimoCaracter()
        {
            return cadena[cadena.Length-1];
        }
    }
}
