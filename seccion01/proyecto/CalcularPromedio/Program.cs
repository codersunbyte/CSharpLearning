/*-- Calculadora de promedio --*/
//Solo se dejara un total de 3 números para este ejercicio por falta de bucles

//SOlicitamos los 3 números
Console.WriteLine("== Calcular Promedio ==");
Console.WriteLine("Escriba los 3 números a promediar: ");
//Número 01
Console.Write("Número 01 -> ");
string nro1 = Console.ReadLine();

//Validación nro1 
if (double.TryParse(nro1, out double num1))
{
    //Continuar flujo almacenando valor en variable double
}
else
{
    //En caso de error mostrar mensaje
    Console.WriteLine("Escriba un valor correcto.");
    Environment.Exit(0);
}

//Número 02
Console.Write("Número 02 -> ");
string nro2 = Console.ReadLine();
//Validación nro2
if (double.TryParse(nro2, out double num2))
{
    //Continuar flujo almacenando valor en variable double
}
else
{
    //En caso de error mostrar mensaje
    Console.WriteLine("Escriba un valor correcto.");
    Environment.Exit(0);
}

//Número 03
Console.Write("Número 03 -> ");
string nro3 = Console.ReadLine();
//Validación nro3 
if (double.TryParse(nro3, out double num3))
{
    //Continuar flujo almacenando valor en variable double
}
else
{
    //En caso de error mostrar mensaje
    Console.WriteLine("Escriba un valor correcto.");
    Environment.Exit(0);
}
Console.Clear();

//Calcular promedio
const int cantidadNotas = 3; //en este caso son 3, con bucles es más dinamico.
double promedio = (num1 + num2 + num3) / cantidadNotas;

//Mostrar promedio por pantalla
Console.WriteLine("== Calcular Promedio ==");
Console.WriteLine($"El promedio de los 3 números es el siguiente: \n{promedio}");