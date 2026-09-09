/**CALCULADORA USANDO METODOS*/
bool exito = false; //Definimos flag para manejar bucle
string opcionOperacion; //Definimos variable que almacena la opcion de operacion
int counter = 0;        //Contador creado solamente por diversion

//Realizamos bucle
while (exito == false)
{
    Console.WriteLine("** CALCULADORA C# **");
    Console.WriteLine("Elija la operación que quiere realizar:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    opcionOperacion = Console.ReadLine();

    //Realizamos Conversion a int
    if (int.TryParse(opcionOperacion, out int op))
    {
        //En caso de recibir double
        if (op == 1) //SUMAR
        {
            Console.WriteLine("-- SUMA --");
            (double a, double b) = validarNumero();
            double resultado = sumar(a, b);
            Console.WriteLine($"El resultado de la operación es {resultado}");
            exito = true;

        }
        else if (op == 2) //RESTAR
        {
            Console.WriteLine("-- RESTAR --");
            (double a, double b) = validarNumero();
            double resultado = restar(a, b);
            Console.WriteLine($"El resultado de la operacion es {resultado}");
            exito = true;

        }
        else if (op == 3) //MULTIPLICAR
        {
            Console.WriteLine("-- MULTIPLICAR --");
            (double a, double b) = validarNumero();
            double resultado = multiplicar(a, b);
            Console.WriteLine($"El resultado de la operación es {resultado}");
            exito = true;

        }
        else if (op == 4) //DIVIDIR
        {
            Console.WriteLine("-- DIVIDIR --");
            (double a, double b) = validarNumero();
            double resultado = dividir(a, b);
            Console.WriteLine($"El resultado de la operación es {resultado}");
            exito = true;

        }
        else //OTRO VALOR NUMERICO
        {
            Console.Clear();
            Console.WriteLine("Pedazo de animal, digo usuario...");
            Console.WriteLine("Elija entre las opciones 1 al 4");
        }

    }
    else
    {
        //En caso de no recibir double
        Console.Clear();
        counter++;
        //Aqui amenazamos al usuario por equivocarse
        if (counter <= 5)
        {
            Console.WriteLine("Ingrese un número válido...");
        }
        else if (counter <= 10)
        {
            Console.WriteLine($"Este es su intento número {counter}...");
            Console.WriteLine("Ingrese número válido o se borrara el system32");
        }
        else if (counter <= 15)
        {
            Console.WriteLine($"Este es su intento número {counter}...");
            Console.WriteLine("USTED NO APRENDE, ULTIMA ADVERTENCIA, INGRESE VALOR VÁLIDO");
        }
        else
        {
            Console.WriteLine($"Este es su intento número {counter}...");
            Console.WriteLine("Filtrando IP...");
            Console.WriteLine("Hackeando Redes sociales...");
            Console.WriteLine("Eliminando usuario...");
            Environment.Exit(0);
        }
    }

}


/*DEFINIR METODOS*/
//SUMAR
static double sumar(double a, double b)
{
    double operacion = a + b;
    return operacion;
}

//RESTAR
static double restar(double a, double b)
{
    double operacion = a - b;
    return operacion;
}

//MULTIPLICAR
static double multiplicar(double a, double b)
{
    double operacion = a * b;
    return operacion;
}

//DIVIDIR
static double dividir(double a, double b)
{
    double operacion = a / b;
    return operacion;
}

//TOMAR NUMEROS
static (double, double) validarNumero()
{

    while (true)
    {

        Console.WriteLine("Ingrese los números para realizar la operación.");
        Console.Write("Número 1 -> ");
        string num1 = Console.ReadLine();
        Console.Write("Número 2 -> ");
        string num2 = Console.ReadLine();

        if (double.TryParse(num1, out double a) && double.TryParse(num2, out double b))
        {
            if (b == 0) //evitar operatorias como division por 0
            {
                Console.WriteLine("El valor no puede ser 0...");
            }
            else
            {
                return (a, b);
            }



        }
        else
        {
            Console.WriteLine("Tipo de dato incorrecto...");
        }
    }
}