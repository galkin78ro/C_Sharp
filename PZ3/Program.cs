void Problem19 ()
{
    Console.WriteLine("Программа для проверки пятизначного числа на палиндромомность");
    Console.WriteLine("Введите положительное пятизначное число");
    int y = int.Parse(Console.ReadLine());
    if ( y is > 9999 and < 100000 )
    {   
        int y1 = y / 10000;
        int y2 = y % 10000 / 1000;
        int y3 = y % 1000 / 100;
        int y4 = y % 100 /10;
        int y5 = y % 10;
        if ( y1 == y5 & y2 == y4 ) 
        {
            Console.WriteLine("Введенное число является палиндромнным");
            return;
        }
        Console.WriteLine("Введенное число не является палиндромнным");
        return;
    }
    else 
    { 
        Console.WriteLine("Введено недопустимое число");
    }
}
void Problem13 ()
{
    
        Console.WriteLine("Введеное число меньше допустимого предела. Третья цифра отсутствует");   
}
void Problem15 ()
{
    Console.WriteLine("Программа для определения выходных дней недели");
    Console.WriteLine("Введите число от 1 до 7");
    int y = int.Parse(Console.ReadLine());
    if ( y is > 0 and < 8 )
    {   
        if ( y is > 0 and < 6 )
        {
            Console.WriteLine("К сожалению данный день является рабочим");}
        else
        {
            Console.WriteLine("УРА! Сегодня выходной");}       
    }
    else
    {
        Console.WriteLine("Указан некорректный день недели");}
}
Console.WriteLine("Введите номер задания");
int x = int.Parse(Console.ReadLine());
if (x == 19)
    {
    Problem19 ();
    return;}
if (x == 13)
    {
    Problem13 ();
    return;}
if (x == 15)
    {
    Problem15 ();
    return;}
else 
    {
    Console.WriteLine("Задания с таким номером не обнаружено");}




