/*--Ejercicio de crear conversor de celcius a Fahrenheit*/
/*
* Celsius → Fahrenheit: °F=(°C×9/5)+32
* Fahrenheit → Celsius: °C=(°F−32)× 5/9
*/
double Celcius;
double Fahrenheit;

Console.WriteLine("Conversor de Celcius a Fahrenheit...");
Console.WriteLine("Elige la operación a realizar: ");
Console.WriteLine("1. Celcius a Fahrenheit");
Console.WriteLine("2. Fahrenheit a Celcius");
string opciones = Console.ReadLine();

if (int.TryParse(opciones, out int opcionMenu))
{
    //se guarda

    if (opcionMenu == 1)
    {
        Console.Clear();
        Console.WriteLine("Escribe la temperatura en Celcius...");
        string tempCelcius = Console.ReadLine();
        if (double.TryParse(tempCelcius, out Celcius))
        {
            double FahrenheitToCelcius = (Celcius * 9 / 5) + 32;
            Console.WriteLine($"La temperatura es de {FahrenheitToCelcius} grados Fahrenheit");

        }
        else
        {
            Console.WriteLine("Debe ser un valor válido");
            Environment.Exit(0);

        }

    }
    else if (opcionMenu == 2)
    {
        Console.Clear();
        Console.WriteLine("Escribe la temperatura en Fahrenheit...");
        string tempFahrenheit = Console.ReadLine();
        if (double.TryParse(tempFahrenheit, out Fahrenheit))
        {
            double CelciusToFahrenheit = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"La temperatura es de {CelciusToFahrenheit} grados Celcius");

        }
        else
        {
            Console.WriteLine("Debe ser un valor válido");
            Environment.Exit(0);

        }
    }
    //else if (opcionMenu != 1 && opcionMenu != 2)
    //{
    //    Console.WriteLine("Debe elegir entre las opciones disponibles...");
    //}
    else
    {
        Console.WriteLine("Eso fue todo amigos");
    }


}
else
{
    Console.WriteLine("Opcion invalida");
    Environment.Exit(0);

}


