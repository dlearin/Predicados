using System;
using System.Collections.Generic;

namespace Predicados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listaNumeros = new List<int>();

            //añadimos a la listanumeros el string 
            /*AddRange: In C#, AddRange adds an entire collection of elements. 
             * It can replace tedious foreach-loops that repeatedly call Add on List. Notes, argument. 
             * We can pass any IEnumerable collection to AddRange, not just an array or another List.
             * */

            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //declaramos delegado predicado

            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            /*el metodo List requiere de usar FindAll para encontrar a todos los num
             * del metodo que cumplan la condicion dada. Ahora bien, nos devolverá
             * estos numeros en formato lista. Por ello, requerimos crear otra lista 
             * que almacene los valores pares.
             */

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);

            /*ahora necesitaremos usar un foreach para leer todos los valores(pares) 
             * que le hemos pasado a la lista
             */

          
            foreach(int pares in numPares)
                {

                Console.WriteLine(pares);

                }

        }
      

    static bool DamePares(int num) //num 0 al valor que le pasamos por parametro para ver si es cierto o falso
    {

        if (num % 2 == 0) return true;
        else return false;

    }
 }
