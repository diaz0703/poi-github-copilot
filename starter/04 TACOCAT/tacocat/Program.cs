//crea una funcion que permita saber si una palabra es igual de derecha a izquierda que de izquierda a derecha

//escribe el código que pregunte la palabra al usuario y muestre si es un palíndromo o no.

Console.WriteLine("Escribe una palabra:");
string palabra = Console.ReadLine();

Console.WriteLine( validaPalindromo(palabra)); 

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