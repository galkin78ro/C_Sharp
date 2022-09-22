void Problem10 ()
{
    Console.WriteLine("Программа для вывода второй цифры в трехзначном числе");
    Console.WriteLine("Введите трехзначное число");
    int y = int.Parse(Console.ReadLine());
    if ( y is > 99 and < 1000 )
    {   
        int d = y / 10 % 10;
        Console.WriteLine("В введенном числе, вторая цифра - " + d );
        return; 
    }else  
    Console.WriteLine("Введено недопустимое число");
}

Console.WriteLine("Введите номер задания");
int x = int.Parse(Console.ReadLine());
if (x == 10)
    {
    Problem10 ();
    }
else 
    {
    Console.WriteLine("Задания с таким номером не обнаружено");
    }




