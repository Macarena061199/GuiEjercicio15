using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  
  /* Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.*/
   bool flag = false;
do
{
    Console.Write("Por favor ingrese un número: ");
    string ingreso = Console.ReadLine();

    if (!int.TryParse(ingreso, out int salida))
    {
        Console.WriteLine("El valor ingresado debe ser numérico.");
    }
    else
    {
        flag = true;
    }

    
} while (flag == false);









