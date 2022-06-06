// See https://aka.ms/new-console-template for more information
Console.Write("Introduzca un Numero del 0 al 99: ");
int num = Convert.ToInt32(Console.ReadLine());

int decenas = (num / 10);
int unid = (num % 10);

if (decenas == 0) Console.WriteLine("CERO");
    else if (decenas == 1) Console.WriteLine("DIEZ");
    else if (decenas == 2) Console.WriteLine("VEINTE");
    else if (decenas == 3) Console.WriteLine("TREINTA");
    else if (decenas == 4) Console.WriteLine("CUARENTA");
    else if (decenas == 5) Console.WriteLine("CINCUENTA");
    else if (decenas == 6) Console.WriteLine("SESENTA");
    else if (decenas == 7) Console.WriteLine("SETENTA");
    else if (decenas == 8) Console.WriteLine("OCHENTA");
    else if (decenas == 9) Console.WriteLine("NOVENTA");
    
    if (unid != 0) Console.WriteLine(" Y ");

    if (unid == 0) Console.WriteLine("CERO");
    else if (unid == 1) Console.WriteLine("UNO");
    else if (unid == 2) Console.WriteLine("DOS");
    else if (unid == 3) Console.WriteLine("TRES");
    else if (unid == 4) Console.WriteLine("CUATRO");
    else if (unid == 5) Console.WriteLine("CINCO");
    else if (unid == 6) Console.WriteLine("SEIS");
    else if (unid == 7) Console.WriteLine("SIETE");
    else if (unid == 8) Console.WriteLine("OCHO");
    else if (unid == 9) Console.WriteLine("NUEVE");

    Console.ReadKey();
    