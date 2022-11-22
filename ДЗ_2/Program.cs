int value=525;//("Введите любое число от 0 до 999");
if((value/100)<1)
{
    Console.WriteLine("нет третей цифры");
}
else
{
    Console.WriteLine(value%10);
}