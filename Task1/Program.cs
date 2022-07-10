/*Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
в промежутке от M до N с помощью рекурсии. */

Console.Clear();
int Prompt(string message)
{
Console.Write(message);
string a_String = Console.ReadLine();
return int.Parse(a_String);
}
void PrintArray(int M, int N)
{
if (M > N) return;
PrintArray(M, N-1);
if (N%2==0) System.Console.Write($"{N}; ");
}

int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");

System.Console.WriteLine();

System.Console.Write($"M = {M}, N = {N} : ");
PrintArray(M, N);
System.Console.WriteLine();