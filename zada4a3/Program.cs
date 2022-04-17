Console.WriteLine("Введите число от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());
int[] massiveA = new int [7] {1, 2, 3, 4, 5, 6, 7};
if (number > massiveA[4] && number <= massiveA[6])
{
    Console.WriteLine("да ");
}
if (number >= massiveA[0] && number <= massiveA[4])
{
    Console.WriteLine("нет ");
}
if (number >=8)
Console.WriteLine("Вы ввели число вне рамок 1-7 ");