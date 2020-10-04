using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
  public class Numero
    {
        private double numero;


        //VALIDACION

        /// <summary>
        /// Comprueba que el valor recibido sea numerico
        /// </summary>
        /// <param name="strNumero">Es el numero en forma de string sobre el que se realiza la validacion</param>
        /// <returns>Devuelve el numero validado, si no es valido, se devuelve un 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double validNumber;

            if (double.TryParse(strNumero, out validNumber))
            {
                return validNumber;

            }else
            {
                return 0;
            }
            
        }

        //PROPIEDAD

        /// <summary>
        /// Propiedad que setea un numero valido
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }


        //CONSTRUCTORES

        /// <summary>
        /// Constructor que recibe un string
        /// </summary>
        /// <param name="strNumero">String para asignar en Numero </param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }


        /// <summary>
        /// Constructor que recibe un double
        /// </summary>
        /// <param name="numero"> Double para asignar en numero </param>
        public Numero(double numero) : this(numero.ToString())
        {

        }


        /// <summary>
        /// Constructor por defecto, inicializa en 0
        /// </summary>
        public Numero() : this(0)
        {

        }


        //METODOS BINARIOS/DECIMAL

        /// <summary>
        /// Comprueba que el valor recibido sea binario
        /// </summary>
        /// <param name="binario">Es el numero en forma de string sobre el que se realiza la validacion</param>
        /// <returns> Devuelve true si es binario o false si no lo es </returns>
        private static bool EsBinario(string binario)
        {
            if (Regex.IsMatch(binario, "[^01]"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Metodo para conversión de binario a decimal.
        /// </summary>
        /// <param name="binario">Numero a convertir. </param>
        /// <returns>Devuelve el numero convertido en decimal</returns>
        public static string BinarioDecimal(string binario)
        {
            string salida = "ERROR! Numero no Binario";
            
            if (EsBinario(binario))
            {
                char[] arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario); //ordeno el array
                double numero = 0;
                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        if (i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += Math.Pow(2, i);
                        }
                    }
                }
                return numero.ToString();
            }
            else
            {
                return salida;

            }


        }


        /// <summary>
        /// Metodo para conversión de decimal a binario.
        /// </summary>
        /// <param name="numero">Numero a convertir en formato string </param>
        /// <returns> Devuelve el numero convertido en binario </returns>
        public static string DecimalBinario(string numero)
        {
            double dbNumeroAux; 
            double.TryParse(numero,out dbNumeroAux);

            dbNumeroAux = Math.Abs(Math.Floor(dbNumeroAux));
            string binario = "";
            for (int i = 0; dbNumeroAux > 0; i++)
            {
                binario += (dbNumeroAux % 2).ToString();
                dbNumeroAux = Math.Floor(dbNumeroAux / 2);
            }
            if (binario.Equals(""))
            { 
            
            binario = "0";
            }
            char[] arrayBinario = binario.ToCharArray();
            Array.Reverse(arrayBinario);
            return new string(arrayBinario);
        }

        /// <summary>
        /// Metodo para conversión de decimal a binario.
        /// </summary>
        /// <param name="numero">Numero a convertir en formato string </param>
        /// <returns> Devuelve el numero convertido en binario </returns>
        public static string DecimalBinario(double numero) 
        {
            return DecimalBinario(numero.ToString());
        }


        //OPERADORES

        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="n1">Dividendo</param>
        /// <param name="n2">Divisor</param>
        /// <returns>Devuelve el resultado de la division o double.MinValue si el divisor es 0 <returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Multiplica dos numeros
        /// </summary>
        /// <param name="n1">numero 1r</param>
        /// <param name="n2">numero 2</param>
        /// <returns>Devuelve el resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }


        /// <summary>
        /// Resta dos numeros
        /// </summary>
        /// <param name="n1">numero 1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>Devuelve el resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }


        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1">numero 1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>Devuelve el resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }


    }
}
