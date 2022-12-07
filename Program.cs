/*Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного 
массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

// int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//   Console.WriteLine("Result array");
//   for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}; ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SelectinSort(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//         {
//           int maxPosition = j;
//           for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//               if (array[i, k] > array[i, maxPosition])
//                 {
//                   maxPosition = k;
//                 }
//             }
//             int temp = array[i, j];
//             array[i, j] = array[i, maxPosition];
//             array[i, maxPosition] = temp;

//         }
//     }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(min, max, rows, columns);
// Show2DArray(myArray);
// SelectinSort(myArray);
// Show2DArray(myArray);


//Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray (int minValue, int maxValue, int rows, int columns)
// {
//   int[,] newArray = new int [rows, columns];
//   for (int i = 0; i < rows; i++)
//     {
//       for (int j = 0; j < columns; j++)
//         {
//           newArray[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//         {
//           Console.Write (array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindMinRow (int[,] array)
// {   
//   int minRow = 0;
//   int minSum = 0;
//   for (int a = 0; a < array.GetLength(1); a++)
//     {
//       minSum = minSum + array[0,a];
//     }
//   for (int i = 1; i < array.GetLength(0); i++)
//     {   
//       int sum = 0;
//       for (int j = 0; j < array.GetLength(1); j++)
//         {
//           sum = sum + array[i,j];
//         }
//         if (sum < minSum) 
//         {
//           minSum = sum;
//           minRow = i;
//         }
//     }
//     return minRow;
// }

// Console.WriteLine ("Введите количество строк");
// int rows = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("Введите количество столбцов");
// int columns = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(min, max, rows, columns);
// Show2DArray (myArray);
// Console.WriteLine (FindMinRow (myArray));

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void Show2DArray(int[,] array)
// {
//     Console.WriteLine("Result array");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//         {
//           Console.Write($"{array[i,j]}; ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MultiplyMatrices(int[,] arrA, int[,] arrB)
// {
//   int[,] zeroMatrix = new int[1, 1] {{ 0 }};
//   if (arrA.GetLength(1) != arrB.GetLength(0)) 
//     {
//       Console.WriteLine("Multiplication is not possible for entered matrices");
//       return zeroMatrix;
//     }
//     else
//     {
//       int m = arrA.GetLength(0);
//       int n = arrA.GetLength(1);
//       int p = arrB.GetLength(1);
//       int[,] arrResult = new int[m, p];//
//       for (int i = 0; i < m; i++)
//         {
//           for (int j = 0; j < p; j++)
//             {
//               for (int k = 0; k < n; k++)
//                 {
//                   arrResult[i,j] = arrResult[i,j] + arrA[i,k] * arrB[k,j];
//                 }
//             }
//         }
//         return arrResult;
//     }
// }

// int[,] arrayA = new int[2, 2]  {{2, 4}, {3, 2}};
// int[,] arrayB = new int[2, 2]  {{3, 4}, {3, 3}};
// Show2DArray(arrayA);
// Show2DArray(arrayB);
// int[,] arrayResult = MultiplyMatrices(arrayA, arrayB);
// Show2DArray(arrayResult);


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void Show3DArrayWithIndex(int[,,] array)
// {
//   for (int k = 0; k < array.GetLength(0); k++)
//     {
//       for (int i = 0; i < array.GetLength(1); i++)
//         {
//           for (int j = 0; j < array.GetLength(2); j++)
//             {
//               Console.Write($"{array[k, i, j]} ({i}, {j}, {k})  ");
//             }
//           Console.WriteLine();
//         }
//       Console.WriteLine();
//     }
// }

// int[,,] AppendArrayRandomUnique(int[,,] array, int pos, int minValue, int maxValue)
// {
//   if (maxValue - minValue < array.GetLength(0) * array.GetLength(1) * array.GetLength(2))
//     {
//       Console.WriteLine("Randomization may lead to infinite loop, number of elements is greater than possible random ");
//       return array;
//     }
//   if (pos >= array.GetLength(0) * array.GetLength(1) * array.GetLength(2))
//     {
//       return array;
//     }
//   else
//     {
//       int d1Cur = pos / (array.GetLength(1) * array.GetLength(2));
//       int d2Cur = pos % (array.GetLength(1) * array.GetLength(2)) / array.GetLength(2);
//       int d3Cur = pos % (array.GetLength(1) * array.GetLength(2)) % array.GetLength(2);
//       for (int i = 0; i < pos; i++)
//         {
//           int d1 = i / (array.GetLength(1) * array.GetLength(2));
//           int d2 = i % (array.GetLength(1) * array.GetLength(2)) / array.GetLength(2);
//           int d3 = i % (array.GetLength(1) * array.GetLength(2)) % array.GetLength(2);
//           if (array[d1,d2,d3] == array[d1Cur,d2Cur,d3Cur]
//                      ||
//                 array[d1Cur,d2Cur,d3Cur] < minValue
//                      ||
//                 array[d1Cur,d2Cur,d3Cur] > maxValue                     
//               )
//             {
//               array[d1Cur,d2Cur,d3Cur] = new Random().Next(minValue, maxValue + 1);
//               AppendArrayRandomUnique(array, pos, minValue, maxValue);
//             }
//         }
//         return AppendArrayRandomUnique(array, pos + 1, minValue, maxValue);
//     }
// }

// int[,,] myArray = new int[2,2,2];
// myArray[0, 0, 0] = new Random().Next(11, 99 + 1);
// myArray = AppendArrayRandomUnique(myArray, 0, 11, 99);
// Show3DArrayWithIndex(myArray);