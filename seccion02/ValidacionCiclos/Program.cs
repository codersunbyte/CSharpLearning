/*Validación de Bucles*/
/*Con lo aprendido previamente de intentara diseñar sistema que eviten usar el uso repetido de Enviroment.Exit*/




/*-- Transformación a interger --*/
/*
Console.WriteLine("Escriba un número entero...");
Console.Write("-> ");
string numero = Console.ReadLine();
bool isCorrect = false;

while (isCorrect == false)
{

    if (int.TryParse(numero, out int nro))
    {
        Console.WriteLine($"Su número es {nro}");
        isCorrect = true;

    }
    else
    {
        Console.WriteLine("Valor incorrecto, intente nuevamente...");
        isCorrect = false;
    }
}
*/
//V2
//En anterior falla y entra en un bucle infinito, tiene razon porque no solicita que vuenta a colocar otro input
/*
bool isCorrect = false;

while (isCorrect == false)
{
    Console.WriteLine("Escriba un número entero...");
    Console.Write("-> ");
    string numero = Console.ReadLine();

    if (int.TryParse(numero, out int nro))
    {
        //Si el número es entero
        Console.WriteLine($"Valor correcto, su número es {nro}");
        //para salir de while 
        isCorrect = true;

    }
    else
    {
        //fallo, valor incorrecto
        Console.WriteLine("Valor incorrecto, intenta nuevamente...");

    }
}
*/

/*-------------------------------------------------------------------------------*/
/*La V2 funciona, ahora se realizara más estricto, denegar valores que no sean int*/
/*y el número debe ser entre 1 a 10*/

/*V2.1*/

//Creación de bandera
bool isCorrect = false;

//bucle while que repite hasta que la bandera cambie a true
while (isCorrect == false)
{
    //Solicitamos número entre 1 a 10
    Console.WriteLine("Escriba número entre 1 a 10...");
    Console.Write("-> ");
    string numero = Console.ReadLine();
    Console.Clear();

    //TryParse de var
    //determinar tipo de dato
    if (int.TryParse(numero, out int nro))
    {
        //Es Entero
        if (nro >= 1 && nro <= 10)
        {
            //Camino correcto
            Console.WriteLine("Su numero es válido...");
            Console.WriteLine($"Su número es {nro}");
            isCorrect = true;

        }
        else
        {
            //En caso que el número esta fuera del rango solicitado
            Console.WriteLine("Número fuera de rango, debe ser mayor a 0 y menor que 11");

        }


    }
    else
    {
        //Otro...
        Console.WriteLine("Valor invalido, intente nuevamente...");
    }
}
