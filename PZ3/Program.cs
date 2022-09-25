void Problem10 ()
{
    Console.WriteLine("Программа для проверки пятизначного числа на палиндромомность");
    Console.WriteLine("Введите пятизначное число");
    int y = int.Parse(Console.ReadLine());
    if ( y is > 9999 and < 100000 )
    {   
        string str = y.ToString();
        int[] b = new int[str.Length];
        for ( int i = 0; i < str.Length; i++)
        {
            b[i] = int.Parse(str[i].ToString());
        }
        int l_i = 0;
        int r_i = 4;
        while ( l_i < r_i )
        {
            if ( b[l_i] == b[r_i] )
            {
                l_i = ( l_i + 1 );
                r_i = ( r_i - 1 );
            }
            else
            {
                Console.WriteLine( " - " );
                return;
            }
        }
        Console.WriteLine(" + " );
        
        
    }else 
        { 
        Console.WriteLine("Введено недопустимое число");
        }
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
            b[i] = int.Parse(str[i].ToString());
            }
        Console.WriteLine("В введенном числе, третья цифра - " + b[2] );
        int tr = 12 + b[2];
        Console.WriteLine( tr );
        }
    else
        { 
        Console.WriteLine("Введеное число меньше допустимого предела. Третья цифра отсутствует");}   
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
if (x == 10)
    {
    Problem10 ();
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




