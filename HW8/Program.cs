// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// int[,] SortRowAscending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int minPosition = j;                                            
//             for (int k = j + 1; k < array.GetLength(1); k++)                
//             {
//                 if (array[i, k] > array[i, minPosition]) minPosition = k;    
//             }
//             int tmp = array[i, j];                                          
//             array[i, j] = array[i, minPosition];                            
//             array[i, minPosition] = tmp;                                    
//         }

//     }
//     return array;
// }

// void PrintTable(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// int row = 4;
// int col = 4;
// int min = 10;
// int max = 100;

// int[,] table = GetMatrix(row, col, min, max);
// PrintTable(table);

// Console.WriteLine();
// int[,] rowSort = SortRowAscending(table);
// PrintTable(rowSort);

// ______________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// int rowNumber(int[,] array)
// {
//     int index = 0;
//     int sum = 0;
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (i == 0) result = sum;
//         else if (sum < result)
//         {
//             result = sum;
//             index = i;
//         }
//     }
//     return index;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// int row = 4;
// int col = 4;
// int min = 10;
// int max = 100;

// int[,] matrix = GetMatrix(row, col, min, max);
// PrintMatrix(matrix);
// Console.WriteLine();
// int index = rowNumber(matrix);
// Console.WriteLine("Наименьшая сумма в " +(index+1)+" строке");

// ___________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// void FillArray(int[,] matr, int[,] matr1)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(10, 100);
//         }
//     }
//     for (int m = 0; m < matr1.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr1.GetLength(1); n++)
//         {
//             matr1[m, n] = new Random().Next(10, 100);
//         }
//     }
// }

// void PrintArray(int[,] matr, int[,] matr1)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     for (int m = 0; m < matr1.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr1.GetLength(1); n++)
//         {
//             Console.Write($"{matr1[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Composition(int[,] matr, int[,] matr1, int[,] compMatr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             compMatr[m, n] = matr[m, n] * matr1[m, n];
//         }
//     }
// }

// void PrintCompArray(int[,] compMatr)
// {
//     for (int m = 0; m < compMatr.GetLength(0); m++)
//     {
//         for (int n = 0; n < compMatr.GetLength(1); n++)
//         {
//             Console.Write($"{compMatr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = new int[1, 2];
// int[,] matrix1 = new int[1, 2];
// int[,] compMatrix = new int[1, 2];
// FillArray(matrix, matrix1);
// PrintArray(matrix, matrix1);
// Console.WriteLine();
// Composition(matrix, matrix1, compMatrix);
// PrintCompArray(compMatrix);

// ____________________________________________________________________________

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
// Console.WriteLine();
// int dimensionX = EnterUserData("Ведите размер массива по X:");
// int dimensionY = EnterUserData("Ведите размер массива по Y:");
// int dimensionZ = EnterUserData("Ведите размер массива по Z:");
// int[,,] randomArray = new int[dimensionX, dimensionY, dimensionZ];
// Console.WriteLine();

// if ((dimensionX * dimensionY * dimensionZ) > 90)
// {
//     Console.WriteLine("Невозможно заполнить введенный массив неповторяющимися двузначными числами! Проверить размер введенного массива.");
//     return;
// }
// FillArray(randomArray, dimensionX, dimensionY, dimensionZ);
// ShuffleArray(randomArray);
// Console.WriteLine();
// Console.WriteLine("Введенный трех мерный массив:");
// Console.WriteLine();
// PrintArray(randomArray);

// int[,,] FillArray(int[,,] array, int dimensionX, int dimensionY, int dimensionZ)
// {
//     int offset = new Random().Next(10, 100);
//     int upperBound = 99;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int n = 0; n < array.GetLength(2); n++)
//             {
//                 array[i, j, n] = offset;
//                 if (offset >= array[0, 0, 0] && offset <= upperBound)
//                 {
//                     offset++;
//                 }
//                 else
//                 {
//                     offset--;
//                 }
//                 if (offset > upperBound)
//                 {
//                     offset = array[0, 0, 0] - 1;
//                 }
//             }

//         }
//     }
//     return array;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int n = 0; n < array.GetLength(2); n++)
//             {
//                 Console.Write($"{array[i, j, n]}[{i},{j},{n}] ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int EnterUserData(string nameUserData)
// {
//     Console.Write($"{nameUserData}");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,,] ShuffleArray(int[,,] array)
// {
//     int temp = 0, i1 = 0, j1 = 0, n1 = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         i1 = new Random().Next(0, array.GetLength(0));
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             j1 = new Random().Next(0, array.GetLength(1));
//             for (int n = 0; n < array.GetLength(2); n++)
//             {
//                 n1 = new Random().Next(0, array.GetLength(2));
//                 temp = array[i1, j1, n1];
//                 array[i1, j1, n1] = array[i, j, n];
//                 array[i, j, n] = temp;
//             }
//         }
//     }
//     return array;
// }

// _______________________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Console.WriteLine("Введите количество чисел в строке"); 
// int n = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите количество чисел в cтолбце"); 
// int m = int.Parse(Console.ReadLine()); 
// int[,] mas = new int[m, n]; 
// int k = 1; 
// int t = 0; 
// int i, j = 0; 
// int n1 = n; 
// int m1 = m; 
 
//     while (k <= n1 * m1) 
//     { 
//         for (i = t; i < n; i++) 
//             mas[j, i] = k++; 
//             j = n - 1; 
//         for (i = t + 1; i < m; i++) 
//             mas[i, j] = k++; 
//             j = m - 1;  
//         for (i = n - 2; i >= t; i--) 
//             mas[j, i] = k++; 
//             j = t; 
//         for (i = m - 2; i > t; i--) 
//             mas[i, j] = k++; 
//             n--; 
//             m--; 
//             t++; 
//             j = t; 
//     } 
// for (i = 0; i < mas.GetLength(0); i++) 
//     { 
//         for (j = 0; j < mas.GetLength(1); j++) 
//             Console.Write("{0,2} ", mas[i, j]); 
//             Console.WriteLine(); 
//     } 