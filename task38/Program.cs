// ﻿Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray () 
{
    double[] Array = new double [new Random().Next(2,10)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i]= Math.Round(new Random().NextDouble()*new Random().Next(-99,99),2) ;
    }
     return (Array);
 }

 double MaxArray (double[] Array) 
{
    double MaxArray=Array[0];
    foreach (var item in Array)
    {
        if (item > MaxArray)
        {
            MaxArray=item;
        }
    }    
    return (MaxArray);
 }

double MinArray (double[] Array) 
{
    double MinArray=Array[0];
    foreach (var item in Array)
    {
        if (item<MinArray)
        {
            MinArray=item;
        }
    }    
    return (MinArray);
 }

void PrintArray (double[] Array) 
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]+", ");
    }
}

void DifMaxMinArray (double[] Array) 
{
    Console.WriteLine($"Max = {MaxArray(Array)} Min = {MinArray(Array)} разница между Max и Min = {MaxArray(Array)-MinArray(Array)}");
}


double[] Array = GetArray();
PrintArray(Array);
Console.WriteLine(" ");
DifMaxMinArray(Array);
