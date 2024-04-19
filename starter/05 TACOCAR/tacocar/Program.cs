//Modifica el código para que pida un número en lugar de una palabra y valide si es un palíndromo o no (pista: puedes convertir el número a cadena de texto para validar si es un palíndromo).

using System;
using System.Linq;

Console.WriteLine("Escribe un número:");
string palabra = Console.ReadLine();

int num = 0;
bool _esnumero = int.TryParse(palabra, out num);
if (!_esnumero)
{
    Console.WriteLine("No es un número");
    return;
}

//escribe una funcion que recibe el numero y utiliza la funcion "validaPalindromo" dentro de un ciclo while hasta que el resultado sea true

while (!validaPalindromo(num.ToString()))
{
    num++;
}


Console.WriteLine("Siguiente palindromo " + num.ToString() ) ; 

static bool validaPalindromo(string palabra)
{
    string reversed = new string(palabra.Reverse().ToArray());
    return QuitaEspacios( palabra).Equals(QuitaEspacios( reversed),  StringComparison.OrdinalIgnoreCase  );
}

//escribe el código que quite espacios a una cadena de texto

static string QuitaEspacios(string frase)
{
    return frase.Replace(" ", "");
}
