/*
* En este proyecto intentare realizar una calculadora...
*/

/*- - - MENU CALCULADORA - - -*/
/*El usuario elige la opearación a realizar entre las opciones*/
Console.WriteLine("-.-.-.-.-.-.Bienvenido a la calculadora.-.-.-.-.-.-");
Console.WriteLine("Seleccione alguna de las siguientes operaciones: ");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Salir");
Console.WriteLine();
string opcionMenu = Console.ReadLine();
int nroTransformado1;
int nroTransformado2;
int resultado;
/*- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -*/
/*SUMAR*/
if (opcionMenu == "1")
{
    Console.Clear();
    Console.WriteLine("Ingrese los números a sumar...");
    Console.Write("Número 1: ");
    string nroSuma1 = Console.ReadLine();
    if (int.TryParse(nroSuma1, out nroTransformado1))
    {
        //número convertido   
    }
    else
    {
        Console.WriteLine("Valor erroneo...");
        Environment.Exit(0);
    }

    Console.Write("Número 2: ");
    string nroSuma2 = Console.ReadLine();
    if (int.TryParse(nroSuma2, out nroTransformado2))
    {
        //número convertido   
    }
    else
    {
        Console.WriteLine("Valor erroneo...");
        Environment.Exit(0);
    }



    resultado = nroTransformado1 + nroTransformado2;
    Console.WriteLine($"El resultado de la suma es {resultado}");
    Environment.Exit(0);





    /*RESTAR*/
}
else if (opcionMenu == "2")
{
    Console.Clear();
    Console.WriteLine("Ingrese los números a restar...");
    Console.Write("Número 1: ");
    string nroResta1 = Console.ReadLine();
    if (int.TryParse(nroResta1, out nroTransformado1))
    {
        //tranformación
    }
    else
    {
        Console.WriteLine("Valor Erroneo...");
        Environment.Exit(0);
    }

    Console.WriteLine("Número 2: ");
    string nroResta2 = Console.ReadLine();
    if (int.TryParse(nroResta2, out nroTransformado2))
    {
        //transformación
    }
    else
    {
        Console.WriteLine("Valor Erroneo...");
        Environment.Exit(0);
    }

    resultado = nroTransformado1 - nroTransformado2;
    Console.WriteLine($"El resultado de la operación es {resultado}");
    Environment.Exit(0);






    /*MULTIPLICAR*/
}
else if (opcionMenu == "3")
{
    Console.Clear();
    Console.WriteLine("Ingrese los números a multiplicar...");
    Console.Write("Número 1: ");
    string nroMuli1 = Console.ReadLine();
    if (int.TryParse(nroMuli1, out nroTransformado1))
    {
        //Nro Transformado
    }
    else
    {
        Console.WriteLine("Valor Erroneo...");
        Environment.Exit(0);
    }

    Console.Write("Número 2: ");
    string nroMulti2 = Console.ReadLine();
    if (int.TryParse(nroMulti2, out nroTransformado2))
    {
        //Nro Transformado
    }
    else
    {
        Console.WriteLine("Valor Erroneo...");
        Environment.Exit(0);
    }


    resultado = nroTransformado1 * nroTransformado2;
    Console.WriteLine($"El resultado de la operación es {resultado}");
    Environment.Exit(0);


    /*DIVIDIR*/
}
else if (opcionMenu == "4")
{
    Console.Clear();
    Console.WriteLine("");
    Console.Write("Número 1: ");
    string nroDiv1 = Console.ReadLine();
    if (double.TryParse(nroDiv1, out double nroTransformadoDiv1))
    {
        //Nro Transformado
    }
    else
    {
        Console.WriteLine("Valor Erroneo...");
        Environment.Exit(0);
    }

    Console.Write("Número 2: ");
    string nroDiv2 = Console.ReadLine();
    if (double.TryParse(nroDiv2, out double nroTransformadoDiv2))
    {
        //Nro Transformado
    }
    else
    {
        Console.WriteLine("Valor Erroneo...");
        Environment.Exit(0);
    }
    double resultadoDiv = nroTransformadoDiv1 / nroTransformadoDiv2;
    Console.WriteLine($"El resultado de la operación es {resultadoDiv}");
    Environment.Exit(0);
    /*SALIR*/
}
else if (opcionMenu == "5")
{
    Environment.Exit(0);
}
else
{
    Console.Write("opción invalida");
    Environment.Exit(0);
}