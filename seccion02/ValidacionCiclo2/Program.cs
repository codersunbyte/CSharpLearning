/*2d0 Ejercicio de validación de ciclos*/
/*Realizar un menu que tenga por opciones 1, 2 y 3*/
//Reto personal, usar DO WHILE para variar

bool matrix = false;
do
{
    //Diseño de menú de videojuego...
    Console.WriteLine("-- C# Game 3D --");
    Console.WriteLine("1. Nueva partida");
    Console.WriteLine("2. Cargar partida");
    Console.WriteLine("3. Salir");
    string opcion = Console.ReadLine(); //Almacenamos el input del usuario.

    //Realizamo conversion del input
    if (int.TryParse(opcion, out int op))
    {
        //En caso de transformar a int, continuar el flujo((
        if (op == 1)
        {
            //Nueva partida
            Console.WriteLine("Creando nueva partida");
            Console.Write("Saliendo de la matrix...");
            matrix = true;
        }
        else if (op == 2)
        {
            //Cargar Partida
            Console.WriteLine("Seleccione archivo de guardado");
            Console.WriteLine("Archivo seleccionado, saliendo de la matrix...");
            matrix = true;
        }
        else if (op == 3)
        {
            //Salir
            Console.WriteLine("¿Estas seguro?");
            Console.WriteLine("Saliendo de la matrix...");
            matrix = true;
        }
        else
        {
            //valor diferente pero entero
            Console.WriteLine("Opcion no válida, seleccione una de las opciones disponibles...");
        }
    }
    else
    {
        //Tipo de dato no se logro transformar, no es un entero
        Console.Clear(); //Limpiamos terminal para mejor visualización
        Console.WriteLine("El valor ingresado no es válido, intente nuevamente");
    }

} while (matrix == false); //mientras el valor sea false, no podras salir de la matrix...