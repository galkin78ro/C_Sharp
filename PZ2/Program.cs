void Problem10 ()
{
    Console.WriteLine("Программа для вывода второй цифры в трехзначном числе");
    Console.WriteLine("Введите трехзначное число");
    int y = int.Parse(Console.ReadLine());
    if ( y is > 99 and < 1000 )
    {   
        int d = y / 10 % 10;
        Console.WriteLine("В введенном числе, вторая цифра - " + d );}
    else 
    { 
        Console.WriteLine("Введено недопустимое число");}
}
void Problem13 ()
{
    Console.WriteLine("Программа для вывода третьей цифры в числе большем 99");
    Console.WriteLine("Введите число больше 99");
    int y = int.Parse(Console.ReadLine());
    if ( y > 99 )
        { 
        string str = y.ToString();
        int[] b = new int[str.Length];
        for ( int i = 0; i < str.Length; i++)
        {
        b[i] = int.Parse(str[i].ToString());}
        Console.WriteLine("В введенном числе, третья цифра - " + b[2] );}
    else
        { 
        Console.WriteLine("Введеное число меньше допустимого предела. Третья цифра отсутствует");}   
}
Console.WriteLine("Введите номер задания");
int x = int.Parse(Console.ReadLine());
if (x == 10)
    {
    Problem10 ();
    return;}
if (x == 13)
    {
    Problem13 ();
    return;}
else 
    {
    Console.WriteLine("Задания с таким номером не обнаружено");}




