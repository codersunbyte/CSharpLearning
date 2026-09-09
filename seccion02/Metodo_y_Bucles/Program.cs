/*BUCLES Y METODOS*/
bool valido = false;
while (valido == false)
{

    Console.WriteLine("Escriba número entero de 1 a 10");
    Console.Write("-> ");
    string numero = Console.ReadLine();

    //Conversion con TryParse
    if (int.TryParse(numero, out int numInt))
    {
        //Es entero
        //llamar metodo
        valido = validarNumero(numInt);

    }
    else if (double.TryParse(numero, out double numDouble))
    {
        //Es decimal
        Console.WriteLine("Ingrese un número entero, no se admiten decimales...");
    }
    else
    {
        //Otro
        Console.Write("Ingrese un valor válido...");

    }
}

//Metodo
static bool validarNumero(int a)
{
    if (a >= 1 && a <= 10)
    {
        //Dentro del rango
        return true;

    }
    else
    {
        Console.WriteLine("Número fuera de rango");
        return false;
    }
}