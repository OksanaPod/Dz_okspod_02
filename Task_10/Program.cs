Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = number/10%10;
Console.WriteLine($"Ответ = {numberA}");