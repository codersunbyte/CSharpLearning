/*Matrices / ARRAY segunda parte*/
//Declaramos y creamos el array de la primera parte
int[] numbers = [10, 20, 30, 40, 50];

//Intentaremos Duplicar los valores del Array usando un FOR
Console.Clear();
for (int x = 0; x < numbers.Length; x++)
{
    numbers[x] *= 2;
    Console.WriteLine($"indice {x} -> {numbers[x]}");
}

//Nuevo Array para experimentar; Objetivo encontrar con un for el elemento con el numero mayor sin usar Array.Max()
Console.Clear(); //Usamos Clear para limpiar consola mostrando solo este segundo ejercicio
//int[] numbers2 = [15, 8, 42, 23, 4, 31];
int[] numbers2 = [-15, -8, -42, -23, -4, -31];

//For que recorra el Array
int mayor = numbers2[0]; //Al iniciarlo en 0, tiene errores con numeros negativos
int indiceMayor = 0;
for (int x = 0; x < numbers2.Length; x++)
{
    // mayor = numbers2[x];
    if (mayor < numbers2[x])
    {
        mayor = numbers2[x];
        indiceMayor = x;
    }


}
Console.WriteLine($"El elemento mayor es {mayor}");
Console.WriteLine($"Indice mayor {indiceMayor}");


//Nuevo Array para experimentar
int[] numbers3 = [15, 8, 42, 23, 4, 31];
Console.Clear(); //Limpiamos los ejercios pasados.

//Sumaremos todos los elementos
int suma = 0; //Creamos un incrementador, variable que se aumentando
double promedio = 0;
for (int x = 0; x < numbers3.Length; x++)
{
    suma += numbers3[x]; //SUMA TOTAL
}

//conversion
/*if(double.TryParse(suma, out promedio))
{
    
}
*/
//nota: TryParse no funciona, no transforma de int a decimal. Solo sirve si estaba en string.
//Leí sobre Casting
promedio = (double)suma / numbers3.Length; //al usar el (double) le dice que no ignore decimales


Console.WriteLine($"Suma total de elementos: {suma}");
Console.WriteLine($"El promedio es {promedio}");


Console.Clear(); //Limpiamos para visualizar solo el siguiente ejercicio
//Encontrar el elemento menor del array
//int[] numbers3 = [15, 8, 42, 23, 4, 31];
int menor = numbers3[0]; //Inicializamos con el primer elemento del array, evitando errores logicos en caso de tener negativos.
int indiceMenor = 0;
for (int x = 0; x < numbers3.Length; x++)
{
    if (menor > numbers3[x])
    {
        menor = numbers3[x];
        indiceMenor = x;
    }
}
Console.WriteLine($"Elemento menor del array es {menor}, cuyo indice es {indiceMenor}");


/*EJERCICIO */
/* Con un solo FOR obtener:
La suma total.
El promedio.
El número mayor y su índice.
El número menor y su índice.
*/
Console.Clear();

int[] numeros = [15, 8, 42, 23, 4, 31];

//Creacion de variables
int sumaTotal = 0;
double avg = 0;
int numMayor = numeros[0];
int numMenor = numeros[0];
int indexMayor = 0;
int indexMenor = 0;

//Ciclo For
for (int x = 0; x < numeros.Length; x++)
{
    //Suma total
    sumaTotal += numeros[x];
    //Mayor y Menor
    if (numMayor < numeros[x])
    {
        //Mayor
        numMayor = numeros[x];
        indexMayor = x;

    }
    if (numMenor > numeros[x])
    {
        //Menor
        numMenor = numeros[x];
        indexMenor = x;
    }
}
//Promedio
avg = (double)sumaTotal / numeros.Length;
Console.WriteLine("- - - - - Resultados: - - - - - ");
Console.WriteLine($"Suma Total -> {sumaTotal}");
Console.WriteLine($"Promedio -> {avg}");
Console.WriteLine($"Elemento mayor -> {numMayor} cuyo indice es {indexMayor}");
Console.WriteLine($"Elemento menor -> {numMenor} cuyo indice es {indexMenor}");