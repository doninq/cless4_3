/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using System.CodeDom.Compiler;

static int[] GenerateArroy(int n)
{
    int[] Arr = new int[n];
    for(int i = 0; i < n; i++)
    {
       Arr[i] = new Random().Next(9);
    }
    return Arr;
}

void PrintArray(int[] Arr)
    {
    Console.Write("[ ");  
    
    for (int i = 0; i < Arr.Length; i++)
    {
    Console.Write(Arr[i] + " ");        
    }
    Console.Write("]");  
    }
PrintArray(GenerateArroy(8));
