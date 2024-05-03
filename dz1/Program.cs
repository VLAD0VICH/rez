//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

using System.Data;

Console.WriteLine("M=");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N=");
int N = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(M,N);

void PrintNaturalNumbers(int M, int N){
    if(N==M) return;
    PrintNaturalNumbers(M,N-1);
    Console.Write($"{N} ");
}