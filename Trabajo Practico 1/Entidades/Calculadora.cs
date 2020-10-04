using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Valida que el operador sea (+ - * /) 
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Devuelve el operador. si no es valido devuelve + </returns>
        private static string ValidarOperador(string operador)
        {

            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }


        /// <summary>
        /// valida y realiza la operación pedida entre dos numeros
        /// </summary>
        /// <param name="num1"> Primer numero de la operacion </param>
        /// <param name="num2"> Segundo numero de la operacion </param>
        /// <param name="operador"> Operacion a realizar </param>
        /// <returns> Resultado de la operacion </returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador);  //Se valida que el operador sea correcto
            double aux = double.MinValue;
            switch (operador)
            {
                case "+":                       //SUMA
                    aux = num1 + num2;
                    break;

                case "-":                       // RESTA
                    aux = num1 - num2;
                    break;

                case "*":                       //MULTIPLICACION         
                    aux = num1 * num2;
                    break;

                case "/":                       //DIVISION
                    aux = num1 / num2;
                    break;
            }

            return aux;
        }




    }
}
