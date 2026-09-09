/*- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
Tipos de datos y creación de variables en C#
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
/*
La creación de variables sigue una sintaxis la cual consiste en lo siguiente:
Type -> nombre variable -> Valor Variable.
Al crear una variable no es necesario que se almacene un valor inicial.
Ej: string soyUnEjemplo ;
En la variable de ejemplo se crea una variable siguiendo la sintaxis pero no se inicaliza.

Tambien se pueden asignar el valor de otras variables según el tipo de dato
double precioFinal = precio1 + precio2;
*/

/*
Enteros - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
byte example1 = 255;
sbyte example2 = -100;
short example3 = 30000;
ushort example4 = 60000;
int example5 = 1000;
uint example6 = 4000000000U;
long example7 = 10000000000L;
ulong example8 = 18000000000UL;

//El tipo más usado es 'int', el resto se usa dependiendo de la optimización de datos según el rango a almacenar
//los tipos de datos con sufijo u (uint, ushort, ulong) no permiten negativos.
//Para detalles de rango según tipo, se encuentra detallado en obsidian notes.


/*
Punto Flotante - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
float example9 = 3.14f;
double example10 = 3.141592;
/*
* 'double' es el tipo más usado.
* float siempre va con sufijo f, ocupa menos memoria pero es más impreciso.
*/

/*
Decimal - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
decimal example11 = 3.141592m;
//Ofrece mayor presición y es ideal para calculos financieros.

/*
Carácter - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
char example12 = 'A';
//Se usa para almacenar un carácter, siempre debe ir con comillas simples a diferencia de string.

/*
String - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
string example13 = "Hola mundo";
/*
*Cadena de caracteres, va entre comillas doble y se puede aplicar concadenación.
*Concadenar -> string concadenarExample= "" + "" + ""; Se usa '+' para hacer cadenas.
*/

/*
Booleano - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
bool example14 = true;
//valores booleanos van de true o false.



/*-------------------------------------------------------------------------------------------------------*/
/*- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
Input y Output en C#
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
//Intput recolecta información de la pantalla y esa info se puede almacenar en variables
Console.WriteLine("Ingresa tu nombre...");
string name = Console.ReadLine();
//los valores almacenados SIEMPRE se guarda como string, en caso se guardar otro tipo se realiza conversion.
Console.WriteLine("Ingresa edad...");
string txt = Console.ReadLine();
if (int.TryParse(txt, out int edad))
{
    Console.WriteLine($"Tu nombre es {name} y tienes {edad} años.");
}
else
{
    Console.WriteLine("edad no valida");
}
