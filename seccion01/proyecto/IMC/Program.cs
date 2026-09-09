/*CALCULAR IMC V2*/
/*--Cara Principal--*/
Console.WriteLine("-.-Calcular IMC-.-");
Console.WriteLine("------------------");
Console.WriteLine("Ingrese los siguientes datos: ");
//Se guardan Peso 
Console.Write("Peso en kg -> ");
string pesoString = Console.ReadLine();
//Se guardan Altura
Console.Write("Altura en metros -> ");
string alturaString = Console.ReadLine();
Console.Clear(); //limpio consola...

//Transformar de string a double peso y altura
if (double.TryParse(pesoString, out double peso) && double.TryParse(alturaString, out double altura))
{
    //Peso y altura transformados a double
    //En caso de pasar los valores solicitados, usar la formuna de imc
    double imc = peso / (altura * altura);

    //Rangos de IMC ADULTOS
    /*
           IMC      | Clasificación 
     -------------: | ------------- 
     Menor que 18,5 | Bajo peso     
        18,5 a 24,9 | Peso normal   
        25,0 a 29,9 | Sobrepeso     
         30,0 o más | Obesidad      
    */

    /*--Salida de IMC--*/
    Console.WriteLine($"Tu IMC es de {imc}");

    //calcular rango IMC
    string rangoImc = "";
    if (imc <= 18.4)
    {
        rangoImc = "Bajo peso";
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        rangoImc = "Peso normal";
    }
    else if (imc >= 25.0 && imc <= 29.9)
    {
        rangoImc = "SobrePeso";
    }
    else if (imc >= 30.0)
    {
        rangoImc = "Obecidad";
    }

    //Imprimir rango
    Console.WriteLine($"Según tu IMC, estas {rangoImc}");

}
else
{
    //En caso de fallar
    Console.WriteLine("Valores fuera de rango, porfavor ingresar valores solicitados");
    Environment.Exit(0); // Salir del programa

}