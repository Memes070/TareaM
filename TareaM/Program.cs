using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int sumaDiagonales = SumarDiagonales(matriz);
        Console.WriteLine("La suma de las diagonales de la matriz es: " + sumaDiagonales);
    }

    static int SumarDiagonales(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        if (filas != columnas)
        {
            throw new ArgumentException("La matriz debe ser cuadrada para sumar las diagonales.");
        }

        int suma = 0;

        for (int i = 0; i < filas; i++)
        {
            suma += matriz[i, i]; // Suma la diagonal principal
            suma += matriz[i, filas - 1 - i]; // Suma la diagonal secundaria
        }

        // Si la matriz es de tamaño impar, restamos el valor del centro para evitar contar dos veces
        if (filas % 2 == 1)
        {
            suma -= matriz[filas / 2, filas / 2];
        }

        return suma;
    }
}