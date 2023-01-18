using ejercicio1;
using System;

ClassNumero cn = new ClassNumero();
int suma;

do
{
    cn.CEstu = cn.Validar("Ingrese la cantidad de estudiantes ");

    for (int j = 0; j < 4; j++)
    {
        do
        {
            cn.Num = cn.Validar("Ingresa la " + (1 + j) + "° nota en el rango de 0 a 25: ");

        } while (cn.Num < 1 || cn.Num > 25);

            suma += cn.Num[i];
            Console.WriteLine("El resultado de la sumatoria es:");

        Console.WriteLine(cn.Estado);
    }
} while (cn.CEstu < 1 || cn.CEstu > 24);

