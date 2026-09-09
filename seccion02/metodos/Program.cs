/*METODOS*/
/*Utiles para reutilizar codigo, en vez de escribir el mismo codigo varias veces se puede reutilizar llamandolo*/
/*Se declara primero y cuando se usa solo hay que llamarlo, hay versiones con parametros*/


//El metodo esta creado pero como no se llama, no se muestra, para llamarlo se hace de esta forma


/*METODOS*/
//Menu();
//MostrarJugador("Diego");
//Menu02();
/***Metodo con return***/
bool exito = false; //flag para controlar bucle
while (exito == false)
{

    Console.WriteLine("Nro1 ->");
    string n1 = Console.ReadLine();
    Console.WriteLine("Nro2 ->");
    string n2 = Console.ReadLine();
    int num1;
    int num2;
    if (int.TryParse(n1, out num1) && int.TryParse(n2, out num2))
    {
        int sumatoria = sumar(num1, num2); //se realiza la suma
        Console.WriteLine($"La suma es de {sumatoria}");
        exito = true; //Salimos del bucle

    }
    else
    {
        Console.WriteLine("Escriba números válidos...");

    }


}
/*METODOS COMPLEJOS?*/

//Conts
const int precioPan = 250;
const int precioGalleta = 990;
const string productoPan = "Pan";
const string productoGalleta = "Galleta";


static void Menu02()
{
    string opcionSeleccion;
    bool exito = false;
    //Interfaz primaria
    while (exito == false)
    {
        Console.Clear();
        Console.WriteLine("Tiendita...");
        Console.WriteLine("Seleccione que producto comprar:");
        Console.WriteLine("1. Pan");
        Console.WriteLine("2. Galleta");
        opcionSeleccion = Console.ReadLine();

        //Conversion
        if (int.TryParse(opcionSeleccion, out int opcion))
        {
            //caso correcto que sea int
            if (opcion == 1) //PAN
            {
                Console.Clear();
                MiniTienda(precioPan, productoPan);
                exito = true;

            }
            else if (opcion == 2)//GALLETA
            {
                Console.Clear();
                MiniTienda(precioGalleta, productoGalleta);
                exito = true;

            }
            else
            {
                //fuera de rango int
                Console.Clear();
                Console.WriteLine("opción ingresada no válida");
            }
        }
        else
        {
            //caso que no sea int
            Console.Clear();
            Console.WriteLine("Usted sera eliminado si no selecciona un valor entero válido");
        }

    }



}

//Definir Metodo
static void Menu()
{
    //Definimos un menu que esta vez solo sera texto
    Console.WriteLine("-- C# The Game --");
    Console.WriteLine("1. New Game");
    Console.WriteLine("2. Continue");
    Console.WriteLine("3. Exit");
}

static void MostrarJugador(string jugador)
{
    Console.WriteLine($"El jugador es el {jugador} ganador");
}

//METODO 02
static void MiniTienda(int precio, string producto)
{
    int intentos = 3;
    bool repetir = true;
    while (intentos != 0)
    {
        Console.WriteLine("Cuantos productos quiere comprar?");
        Console.Write("-> ");
        string cantidad = Console.ReadLine();

        //conversion a int
        if (int.TryParse(cantidad, out int cant))
        {
            if (cant <= 0)
            {
                Console.WriteLine("La cantidad mínima de productos debe ser 1");
                intentos--;
                Console.WriteLine($"Números de intentos restantes: {intentos}");
            }
            else if (cant > 51)
            {
                Console.WriteLine("La cantidad máxima permitida por compra es de 50 unidades...");
                intentos--;
                Console.WriteLine($"Números de intentos restantes: {intentos}");

            }
            else
            {
                int total = cant * precio;
                Console.Clear();
                Console.WriteLine($"Se realizo la compra de {cant} {producto}...");
                Console.WriteLine($"El precio total de la compra es de {total}");
                repetir = false;
                break;
            }

        }
        else
        {
            //no int
            Console.WriteLine("Valor incorrecto, ingrese un número válido");
            intentos--;
            Console.WriteLine($"Números de intentos restantes: {intentos}");
        }
    }
    if (intentos == 0 && repetir == true)
    {
        Menu02();
    }


}

//METODO CON RETURN
static int sumar(int nro1, int nro2)
{
    int suma = nro1 + nro2;
    return suma;

}