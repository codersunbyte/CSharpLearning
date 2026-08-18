/*-- Calculadora de edad --*/
Console.WriteLine("- - - - - - - - - - - -");
Console.WriteLine("Ingrese el su fecha de nacimiento con el siguiente formato dd/mm/yyyy");
//capturamos fecha de nacimiento y actual
string FechaNacimientoString = Console.ReadLine();
DateTime FechaActual = DateTime.Today;

//convertir fecha nacimiento en DateTime
if (DateTime.TryParse(FechaNacimientoString, out DateTime FechaNacimiento))
{
    //Se transforma fecha de nacimiento
    //Año almacenado
    int year = FechaActual.Year;
    int yearBirth = FechaNacimiento.Year;
    //Mes Almacenado
    int month = FechaActual.Month;
    int monthBirth = FechaNacimiento.Month;
    //Dia Almacenado
    int day = FechaActual.Day;
    int dayBirth = FechaNacimiento.Day;

    //calculos
    int calculoAno = year - yearBirth;
    if (monthBirth > month)
    {
        calculoAno -= 1;
    }
    else if (month == monthBirth)
    {
        //Si el mese es igual al de nacimiento comprobar dias
        if (dayBirth > day)
        {
            calculoAno -= 1;
        }
    }

    //imprimir en pantalla
    Console.Write($"Tu edad es {calculoAno} años");
}
else
{
    Console.Write("Eliminando System32...");
    Environment.Exit(0);
}

