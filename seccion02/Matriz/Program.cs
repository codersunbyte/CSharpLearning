/*Matrices*/
/*Sintaxis y teoriaca definida en Obsidian*/

//Declarar  y crear un Array de enteros
int[] numbers = [10, 20, 30, 40, 50]; //Array de 5 Elementos

//Imprimir elemento número 1, 3 y ultimo
int primero = numbers[0];
int tercero = numbers[2];
int ultimo = numbers[numbers.Length - 1];
int largo = numbers.Length;
//El indice empieza con el número 0
//Imprimir resultados--
Console.WriteLine("Version de ARRAY 1");
Console.WriteLine($"El Array numbers cuento con un array de {largo} elementos");
Console.WriteLine($"Primer Elemento: {primero}");
Console.WriteLine($"Tercer Elemento: {tercero}");
Console.WriteLine($"Ultimo elemento: {ultimo}");
Console.WriteLine("");

//Ahora realizaremos cambios en los elementos, por eso visualizaremos primero el Array original.
//ForEach para visualizar Array antes de los cambios
Console.WriteLine("Version de ARRAY 1");
Console.WriteLine($"El Array numbers cuento con un array de {largo} elementos");
Console.WriteLine("-- ELEMENTOS --");

//Se solicito Foreach, por eso realizare un contador manual, con un FOR puedo sacar los indices correspondientes
int indice = 0;
foreach (int number in numbers)
{
    Console.WriteLine($"Indice {indice} -> {number}");
    indice++;
}
indice = 0;

Console.WriteLine("- - - - - - - - -");
Console.WriteLine("");
Console.WriteLine("Version de ARRAY 2");
Console.WriteLine("Se modificaran los elementos con indice 1 y 4");

//MODIFICACIÓN
numbers[1] = 200;
numbers[4] = 500;

foreach (int number in numbers)
{
    Console.WriteLine($"Indice {indice} -> {number}");
    indice++;
}


//IMPRIMIR EL MISMO ARRAY PERO USANDO FOR, NO FOREACH
Console.WriteLine("");
Console.WriteLine("- - IMPRIMIR ARRAY USANDO FOR - -");
for (int x = 0; x < numbers.Length; x++)
/*Aqui se crea var X = 0, mientras var X sea menor al largo del array repite, por cada iteracion se aumenta X en 1*/
{
    Console.WriteLine($"Indice {x} -> ELEMENTO {numbers[x]}");

}