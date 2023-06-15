// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray ()
{
    int[] Array = new int [new Random().Next(2,10)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i]= new Random().Next(-100,100) ;
    }
     return (Array);
 }

int SumNlArray (int[] Array)
{
    int SumNlArray=0;
    for (int i = 1; i < Array.Length; i=i+2)
    {
        SumNlArray=SumNlArray+Array[i];
    }
    return (SumNlArray);
 }


void PrintArray (int[] Array) 
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]+", ");
    }
}

int[] Array = GetArray();
PrintArray(Array);
Console.Write($" Сумма элементов, стоящих на нечётных позициях = {SumNlArray(Array)}");
