/*--BUCLES--*/
/*Los bucles nos permiten repetir lógica sin necesidad de reescribir mucho código identico*/

//Contador local para bucles

int counter = 0; //inicializamos en contador en 0;

//Mini menu para tener los 3 bucles en un mismo programa.
Console.WriteLine("== Practicando bucles ==");
Console.WriteLine("1. WHILE");
Console.WriteLine("2. DO WHILE");
Console.WriteLine("3. FOR");
string opcion = Console.ReadLine();
if (int.TryParse(opcion, out int op))
{
    if (op == 1) //Elegimos WHILE
    {
        /*-- WHILE --*/
        /*El bucle while repite una lógica MIENTRAS se cumpla la condición*/

        while (counter < 10)
        { //Repetida el contenido mientras el contador sea menor a 10.
            Console.WriteLine($"El contador esta en -> {counter}");
            counter++; //aumentamos en contador en 1, la expresion ++ es lo mismo que counter = counter + 1
        }
        Console.WriteLine("Salimos de la matrix...");
        //si no aumentamos el contador, nunca llegamos a cumplir la condición, por ende, se transforma en un bucle infinito
        //un bucle infinito deja el programa repitiendo infinitamente.

    }
    else if (op == 2) //Elegimos DO WHILE
    {
        /*-- DO WHILE --*/
        /*El bucle do while ejecuta primero el código para a continuación comprobar la condicion*/
        do
        {
            Console.WriteLine($"El contador esta en -> {counter}");
            counter++;

        } while (counter < 10);

    }
    else if (op == 3) // Elegimos FOR
    {
        /*-- FOR --*/
        /* */

        for (; counter < 10; counter++) // Aqui omiti el primer parametro dejando solamente ; dado a que tenia el contador creado de antes
        {
            Console.WriteLine($"El contador esta en -> {counter}");
        }

    }
    else
    {
        Console.WriteLine("opción no valida");
        Environment.Exit(0);
    }

}
else
{
    Console.WriteLine("Opción invalida");
    Environment.Exit(0);
}


