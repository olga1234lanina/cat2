// задача 25. написать цикл, который принимает на вход два числа (А и В) и возводит  число А в натульную степень В
// 3, 5 -> 243 (3⁵) 
// 2, 4 -> 16 

Console.Clear();
Console.Write("Введите назначаемое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A}, {B} -> {GetStepen(A,B)}");

double GetStepen(int A, int B)
{
    double result = Math.Pow(A,B);
    return result;
}
