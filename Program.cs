// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// void FillArray(int[] array)
// {
   
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(100,1000);
// }
// }

// void PrintArray(int[] array)
// {
// foreach (var item in array)
// {
// Console.Write($"{item} ");
// }
// System.Console.WriteLine();
// }

// void FindSums(int[] array)
// {
    
//    int evenCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }
    
// System.Console.WriteLine($"Количество четных элементов массива равно " + evenCount);

// }
// Console.Clear();
// System.Console.WriteLine("введите количество трехзначных цифр в массиве");
// int size=Convert.ToInt32(Console.ReadLine());
// int [] array= new int[size];
// FillArray(array);
// PrintArray(array);
// FindSums(array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
// void FillArray(int[] array)
// {
   
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0,1000);
// }
// }

// void PrintArray(int[] array)
// {
// foreach (var item in array)
// {
// Console.Write($"{item} ");
// }
// System.Console.WriteLine();
// }

// void FindSums(int[] array)
// {
//    int oddSum=0;
//         for (int i = 0; i < array.Length; i+=2)
//         {
//             oddSum+=array[i];
//         }
    
// System.Console.Write($"Сумма  не четных индексов  равна => " + oddSum);

// }
// Console.Clear();
// System.Console.WriteLine("Задайте массив => ");
// int size=Convert.ToInt32(Console.ReadLine());
// int [] array= new int[size];
// FillArray(array);
// PrintArray(array);
// FindSums(array);

