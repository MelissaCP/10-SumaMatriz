using System;
using C = System.Console;

namespace _10_SumaMatriz
{
    class Program
    {
        /// Practica 8
        /// 8.- Generar un arreglo a partir de 2 arreglos ordenados.
        /// 
        /// Chávez Pérez Melissa
        /// #M21210035
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;


            int i, j, filas = 0, columnas = 0, sumadiagonal = 0, sumacontradiagonal=0,sumarenglon=0, sumacolumna=0;
            C.WriteLine("Filas?");
            filas = Convert.ToInt16(C.ReadLine());
            C.WriteLine("Columnas?");
            columnas = Convert.ToInt16(C.ReadLine());
            Random aleatorio = new Random();
            int[,] matriz = new int[filas, columnas];
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(0, 10);
                    //Console.WriteLine("Ingrese numero en la posicion {0},{1}",i.ToString(),j.ToString());
                }
            }

            C.WriteLine("MATRIZ");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    C.Write(matriz[i, j].ToString() + " ");
                }
                C.WriteLine();
            }

            C.WriteLine("Diagonal");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        C.Write(matriz[i, j].ToString() + " ");
                    }
                }
                C.WriteLine();
            }

            C.WriteLine("Contradiagonal");
            for ( i = 0, j= matriz.GetLength(1) - 1; i <matriz.GetLength(0); i++, j--)

            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        C.Write(matriz[i, j].ToString() + " ");
                    }
                }
                C.WriteLine();
            }

            C.WriteLine("Renglon-Fila");
           // int filas = Convert.ToInt32(C.ReadLine());
           for ( i=0; i<matriz.GetLength(0); i++)
           // for (i = 0, j = matriz.GetLength(1) - 1; i < matriz.GetLength(0); i++, j--)

            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        C.Write(matriz[i, j].ToString() + " ");
                    }
                }
                C.WriteLine();
            }
            C.WriteLine("Columna");
            for (i = 0; i < matriz.GetLength(1) ; i++)

            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        C.Write(matriz[i, j].ToString() + " ");
                    }
                }
                C.WriteLine();
            }


            for (i = 0; i < matriz.GetLength(0) && i < matriz.GetLength(1); i++)
            {
                sumadiagonal += matriz[i, i];
               
            }

    
            for (i = 0; i < matriz.GetLength(0) && i < matriz.GetLength(1); i++)
            {
                sumacontradiagonal += matriz[i, i];
               
            }

            for (i = 0; i < matriz.GetLength(0) && i < matriz.GetLength(1); i++)
            {
                sumarenglon += matriz[i, i];

            }

            for (i = 0; i < matriz.GetLength(0) && i < matriz.GetLength(1); i++)
            {
                sumacolumna += matriz[i, i];

            }

            C.Write("\nLa suma de contradiagonal es: "+ sumacontradiagonal);
            C.Write("\nLa suma de diagonal es: "+ sumadiagonal);
            C.Write("\nLa suma de diagonal es: " + sumarenglon);
            C.Write("\nLa suma de diagonal es: " + sumacolumna);
            C.ReadLine();
        }
        }
    }

