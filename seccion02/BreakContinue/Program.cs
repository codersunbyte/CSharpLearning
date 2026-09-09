/*Break y Continue*/

/*-- BREAK --*/
/*La instrucción break finaliza la instrucción de iteración de los bucles vistos previamente*/

/*-- CONTINUE --*/
/*termina la iteración actual y pasa a la siguiente iteración del bucle. */

Console.WriteLine("Intrucciónes Break y Continue");
Console.WriteLine("1. Break");
Console.WriteLine("2. Continue");
string opcion = Console.ReadLine();

if (int.TryParse(opcion, out int op))
{
    if (op == 1)
    {
        //BREAK
        int counter = 0;
        while (counter <= 10)
        {
            Console.WriteLine($"El contador esta en {counter}");
            counter++;

            if (counter == 4)
            {
                Console.WriteLine($"Ops...Algo se rompio en el contador {counter}");
                break;
            }
        }


    }

    if (op == 2)
    {
        //CONTINUE
        int counter = 0;
        for (; counter < 10; counter++)
        {
            Console.Write($"Iteración número {counter} -");
            //inicio de nueva iteración
            if (counter < 4)
            {
                Console.WriteLine("Skips");
                continue;
            }
            //Continuación del for
            Console.WriteLine("Done");
        }
    }
}

