﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int Promt (string mesage)
{
    Console.Write(mesage);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}
int[] Array ()