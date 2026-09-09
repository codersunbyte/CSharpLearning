/*Ejercicios de ARRAYS*/
/*
Crea un programa que tenga un array:
int[] numeros = [10, 25, 7, 32, 18];

Y crea tres métodos separados:
1. Método Sumar -> Debe recibir el array como parámetro y devolver la suma de todos sus elementos.
2. Método ObtenerMayor -> Debe recibir el array y devolver el número mayor.
3. Método ObtenerMenor -> Debe recibir el array y devolver el número menor.

Reglas: 
Cada método debe recibir int[] como parámetro.
Dentro de los métodos puedes utilizar for.
No uses Sum(), Max(), Min() ni LINQ. 
Desde Main, llama a los tres métodos y muestra sus resultados.
Intenta que Main quede principalmente encargado de preparar los datos, llamar métodos y mostrar resultados.
*/

//Cada ejercicio sera un metodo para que la ejecución sea más clara.
Console.Clear();
//Ejercicio01();
//Ejercicio02();
Ejercicio03();
//EJERCICIO 01 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
static void Ejercicio01()
{
    int[] numeros = [10, 25, 7, 32, 18];

    Console.WriteLine("- - - Ejercicio práctico - - - ");
    Console.WriteLine("El Array contiene los siguientes elementos: [10, 25, 7, 32, 18]");
    Console.WriteLine("Sumatoria de elementos: " + sumar(numeros));
    Console.WriteLine("Obtener mayor: " + ObtenerMayor(numeros));
    Console.WriteLine("Obtener menor: " + ObtenerMenor(numeros));


}

//METODOS EJERCICIO 01 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
static int sumar(int[] numbers) //Los metodos reciben por parametro un array de Enteros
{
    int sumatoria = 0; //Definimos variable con valor temporal.
    for (int i = 0; i < numbers.Length; i++)
    {
        //DEBE SUMAR TODOS LOS ELEMENTOS
        sumatoria += numbers[i];

    }
    return sumatoria;
    //El metodo retorna la sumatoria del array

}

static int ObtenerMayor(int[] numbers)
{
    int numMayor = numbers[0]; //Definimos una variable con un valor temporal.
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numMayor < numbers[i]) //Si donde vamos almacenar el valor es menor que el numero que comparamos, se actualiza.
        {
            numMayor = numbers[i];
        }

    }
    return numMayor;
    //Retorna el número mayor.
}

static int ObtenerMenor(int[] numbers)
{
    int numMenor = numbers[0]; //Definimos una variable con un valor temporal.
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numMenor > numbers[i]) //Si donde vamos almacenar el valor es mayor que el numero que comparamos, se actualiza.
        {
            numMenor = numbers[i];
        }

    }
    return numMenor;
    //Retorna el número menor.

}

/*Ejercicio 02
Método que devuelve dos datos
Crea un método llamado ObtenerMayorYIndice

Debe recibir el array y devolver dos valores:
-El número mayor.
-El índice donde se encuentra.

Reglas
Usa for.
No uses Max(), LINQ, etc.
El método debe recorrer el array.
Devuelve tanto el mayor como su índice.
Desde el código principal, guarda los dos resultados y muéstralos.
*/
//EJERCICIO 02 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
static void Ejercicio02()
{
    int[] numeros = [10, 25, 7, 32, 18];
    Console.WriteLine("- - - - - Ejercicio 02 - - - - - - - - -");
    Console.WriteLine("El array es [10, 25, 7, 32, 18]");
    //Console.WriteLine($"Elemento mayor {ObtenerMayorYIndice}");
    (int mayor, int indice) = ObtenerMayorYIndice(numeros);
    Console.WriteLine("-> " + mayor);
    Console.WriteLine("-> " + indice);


}

static (int, int) ObtenerMayorYIndice(int[] numbers)
{
    int mayor = numbers[0];
    int indiceMayor = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (mayor < numbers[i])
        {
            mayor = numbers[i];
            indiceMayor = i;

        }
    }
    return (mayor, indiceMayor);
}


/*- - - - - - - EJERCICIO 03 - - - - - - - - */
/*
Siguiente ejercicio: método que analiza todo el array

crear un solo método que reciba un int[] y devuelva:

La suma.
El promedio.
El mayor.
El índice del mayor.
El menor.
El índice del menor.

Reglas:

Un único método para hacer el análisis.
Un único for dentro del método.
No LINQ.
Usa un tuple para devolver los 6 resultados.
Desde el código principal, deconstruye el tuple y muestra los resultados.
*/

/*METODO EJERCICIO 03*/
static void Ejercicio03()
{
    //Arary
    int[] numeros = [15, 8, 42, 23, 4, 31];

    (int sumatoria, double promedio, int numMayor, int idxMayor, int numMenor, int idxMenor) = ArrayAnalisis(numeros);

    Console.WriteLine("- - - - - Ejercicio 03 - - - - -");
    Console.WriteLine("Array -> [15, 8, 42, 23, 4, 31]");
    Console.WriteLine($"Suma total -> {sumatoria}");
    Console.WriteLine($"promedio -> {promedio}");
    Console.WriteLine($"Elemento Mayor -> {numMayor}, indice -> {idxMayor}");
    Console.WriteLine($"Elemento Menor -> {numMenor}, indice -> {idxMenor}");
}

static (int, double, int, int, int, int) ArrayAnalisis(int[] numbers)
{
    //Preparamos variables a retornar
    int sumatoria = 0;
    double promedio = 0;
    int numMayor = numbers[0];
    int numMenor = numbers[0];
    int idxMayor = 0;
    int idxMenor = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sumatoria += numbers[i];


        if (numMayor < numbers[i])
        {
            numMayor = numbers[i]; //Actualizamos para almacenar el mayor elemento
            idxMayor = i; //Aprovechamos de guardar el indice mayor
        }

        if (numMenor > numbers[i])
        {
            numMenor = numbers[i]; //Actualizamos para almacenar el menor elemento
            idxMenor = i; //Aprovechamos de guardar el indice menor
        }

    }
    promedio = (double)sumatoria / numbers.Length;

    //Retornamos los calculos
    return (sumatoria, promedio, numMayor, idxMayor, numMenor, idxMenor);

}