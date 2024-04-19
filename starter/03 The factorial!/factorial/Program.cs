//crea una función que devuelva el factorial de un número entero no negativo. El factorial de un número entero no negativo n se define como el producto de todos los enteros positivos menores o iguales a n. Por ejemplo, el factorial de 5 (escrito como 5!) es 5 * 4 * 3 * 2 * 1 = 120. El factorial de 0 es 1.

// Aquí está la firma del método:
// public static long Factorial(int n)

// La función debe devolver el factorial de n. Si n es menor que 0, la función debe devolver -1.*/

// using System;

// namespace factorial
// {
//     class Program
//     {
        //  static void Main(string[] args)
        //  {

            int n = 0;

//crea código que permita preguntar al usuario un número entero no negativo y muestre el factorial de ese número. Si el número es negativo, muestra un mensaje de error.*/

           Console.WriteLine("Escribe un número positivo:");
           string _respuesta = Console.ReadLine();
       //    crea una funcion para validar que es un número entero
            bool _esnumero = int.TryParse(_respuesta, out n);
           if (! (_esnumero))
            {
                Console.WriteLine("El dato debe ser un número entero.");
               return;
            }
            if (n < 0)
            {
                Console.WriteLine("El número debe ser positivo.");
               return;
            }
                Console.WriteLine(Factorial(n));

         

         static long Factorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
//     }
// }
