Console.WriteLine("Программа для сравнения двух чисел");
Console.WriteLine("Введите число1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число1 больше числа2");
}else if (a < b)
{
    Console.WriteLine("Число2 больше числа1");
}else
{
    Console.WriteLine("Число1 равно числу2"); 
}
