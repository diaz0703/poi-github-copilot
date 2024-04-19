//Crea una funcion en c sharp que se llame "ImprimeNumeros" que imprime en pantalla números del 1 al 100, si el número es multiplo de 3 entonces sumale la etiqueta "Fizz" y si es multiplo de 5 sumale la etiqueta "Buzz".

            ImprimeNumeros();

        static void ImprimeNumeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " Fizz Buzz");
                }else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");     
                }else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
