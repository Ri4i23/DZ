int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int total = Total(number);

Console.WriteLine(total);

int Total(int arg)
{
  int first = number % 100;
  return first / 10;
}
    



