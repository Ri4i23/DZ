int a = new Random().Next(1,1000);
Console.WriteLine(a); // Выводим число, чтобы проверить наглядность работы кода;
Console.WriteLine("Играем в угадайку! Загадай число!");
int b = Convert.ToInt32(Console.ReadLine());
int tries = 0;
while (tries <2)
{
    if (a!=b)
    {
        Console.WriteLine("Вы не угадали! ещё разок!");
     
    }
    else
    {
        Console.WriteLine("Наконец то угадали!");
        break;
    }
    int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("GAME OVER");
tries++;    
}
