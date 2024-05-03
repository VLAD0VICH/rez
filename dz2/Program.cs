//Напишите программу вычисления функции
//Аккермана с помощью рекурсии. Даны два
//неотрицательных числа m и n. 
using System.Data;
using System.Runtime.CompilerServices;

Console.WriteLine("m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n=");
int n = Convert.ToInt32(Console.ReadLine());



int akkerman(int n, int m){
    if (n == 0) return m + 1;
    if (m == 0) return akkerman(n - 1, 1);
    return akkerman(n - 1, akkerman(n, m - 1));
}
int number = akkerman(n,m);
Console.WriteLine(number);