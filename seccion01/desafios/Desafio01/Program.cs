/*DESAFIO 01  - Creación de una caja*/
/*Simular una tienda donde se ingresa:
 * Producto, Cantidad y Precio a Pagar
*/


//Definir productos disponibles (uso int en el contexto de clp)
const int Pan = 250;
const int Leche = 1500;
const int Galleta = 1000;

//Interfaz inicial de tienda 
Console.WriteLine("- - Tienda CSharp - -");
Console.WriteLine("Elija entre los productos disponibles...");
Console.WriteLine("1. Pan");
Console.WriteLine("2. Leche");
Console.WriteLine("3. Galleta");
string opcion = Console.ReadLine();

Console.Clear();
Console.WriteLine("- - Tienda CSharp - -");

//Conversión de opcion almacenada
if (int.TryParse(opcion, out int op))
{
    //Flujo Según producto elegido
    int productoSeleccionado;
    if (op == 1)
    {
        productoSeleccionado = Pan;
        Console.WriteLine($"Este producto vale ${Pan}");
        Console.Write("Escriba cantidad: ");
        string cantidadProduct = Console.ReadLine();
        int total;

        //Conversion y válidación de cantidad
        if (int.TryParse(cantidadProduct, out int cantidad) && cantidad > 0)
        {
            //En caso de ser válido
            total = Pan * cantidad;
            Console.WriteLine($"El valor total de la compra es de {total}.");
            Console.WriteLine("¿Realizar pago?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            string opPagoString = Console.ReadLine();

            //Validación de pago
            if (int.TryParse(opPagoString, out int opPago))
            {
                if (opPago == 1)
                {
                    //Lógica de Pago
                    Console.WriteLine("Escriba el dinero a pagar...");
                    Console.Write("-> $");
                    string PagoString = Console.ReadLine();

                    //Conversión y válidacion
                    if (int.TryParse(PagoString, out int Pago) && Pago >= total)
                    {
                        int vuelto = total - Pago;
                        Console.WriteLine($"Gracias por su compra, su vuelo es ${vuelto}");
                        Console.WriteLine("Porfavor no vuelva nunca más");

                    }
                    else if (Pago < total)
                    {
                        Console.WriteLine("Dinero insuficiente, cancelando operación y llamando a seguridad...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Valor no válido, intentelo nuevamente...");
                        Environment.Exit(0);
                    }

                }
                else if (opPago == 2)
                {
                    //Cancelar operación
                    Console.WriteLine("Cancelando operación");
                    Environment.Exit(0);
                }
            }
            else
            {
                //Error
                Console.WriteLine("Seleccione opción válida");
                Environment.Exit(0);
            }
        }

    }
    else if (op == 2)
    {
        productoSeleccionado = Leche;
        Console.WriteLine($"Este producto vale ${Leche}");
        Console.Write("Escriba cantidad: ");
        string cantidadProduct = Console.ReadLine();
        int total;

        //Conversion y válidación de cantidad
        if (int.TryParse(cantidadProduct, out int cantidad) && cantidad > 0)
        {
            //En caso de ser válido
            total = Leche * cantidad;
            Console.WriteLine($"El valor total de la compra es de {total}.");
            Console.WriteLine("¿Realizar pago?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            string opPagoString = Console.ReadLine();

            //Validación de pago
            if (int.TryParse(opPagoString, out int opPago))
            {
                if (opPago == 1)
                {
                    //Lógica de Pago
                    Console.WriteLine("Escriba el dinero a pagar...");
                    Console.Write("-> $");
                    string PagoString = Console.ReadLine();

                    //Conversión y válidacion
                    if (int.TryParse(PagoString, out int Pago) && Pago >= total)
                    {
                        int vuelto = total - Pago;
                        Console.WriteLine($"Gracias por su compra, su vuelo es ${vuelto}");
                        Console.WriteLine("Porfavor no vuelva nunca más");

                    }
                    else if (Pago < total)
                    {
                        Console.WriteLine("Dinero insuficiente, cancelando operación y llamando a seguridad...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Valor no válido, intentelo nuevamente...");
                        Environment.Exit(0);
                    }

                }
                else if (opPago == 2)
                {
                    //Cancelar operación
                    Console.WriteLine("Cancelando operación");
                    Environment.Exit(0);
                }
            }
            else
            {
                //Error
                Console.WriteLine("Seleccione opción válida");
                Environment.Exit(0);
            }
        }

    }
    else if (op == 3)
    {
        productoSeleccionado = Galleta;
        Console.WriteLine($"Este producto vale ${Galleta}");
        Console.Write("Escriba cantidad: ");
        string cantidadProduct = Console.ReadLine();
        int total;

        //Conversion y válidación de cantidad
        if (int.TryParse(cantidadProduct, out int cantidad) && cantidad > 0)
        {
            //En caso de ser válido
            total = Galleta * cantidad;
            Console.WriteLine($"El valor total de la compra es de {total}.");
            Console.WriteLine("¿Realizar pago?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            string opPagoString = Console.ReadLine();

            //Validación de pago
            if (int.TryParse(opPagoString, out int opPago))
            {
                if (opPago == 1)
                {
                    //Lógica de Pago
                    Console.WriteLine("Escriba el dinero a pagar...");
                    Console.Write("-> $");
                    string PagoString = Console.ReadLine();

                    //Conversión y válidacion
                    if (int.TryParse(PagoString, out int Pago) && Pago >= total)
                    {
                        int vuelto = total - Pago;
                        Console.WriteLine($"Gracias por su compra, su vuelo es ${vuelto}");
                        Console.WriteLine("Porfavor no vuelva nunca más");

                    }
                    else if (Pago < total)
                    {
                        Console.WriteLine("Dinero insuficiente, cancelando operación y llamando a seguridad...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Valor no válido, intentelo nuevamente...");
                        Environment.Exit(0);
                    }

                }
                else if (opPago == 2)
                {
                    //Cancelar operación
                    Console.WriteLine("Cancelando operación");
                    Environment.Exit(0);
                }
            }
            else
            {
                //Error
                Console.WriteLine("Seleccione opción válida");
                Environment.Exit(0);
            }
        }

    }

}
else
{
    //En caso de error
    Console.WriteLine("Error, selecciona una opción válida...");
    Environment.Exit(0);
}