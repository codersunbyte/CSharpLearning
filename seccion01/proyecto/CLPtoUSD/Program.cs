/*CLP a USD*/
const double TASA_CAMBIO = 950;

Console.Write("Ingrese el monto en $ Chilenos (clp)");
string clpRecibido = Console.ReadLine();
if (double.TryParse(clpRecibido, out double clp))
{
    double dolar = clp / TASA_CAMBIO;
    Console.WriteLine($"El valor de {clpRecibido} CLP queda en {dolar} USD");
}
else
{
    Console.WriteLine("Valor no valido...");
    Environment.Exit(0);
}
