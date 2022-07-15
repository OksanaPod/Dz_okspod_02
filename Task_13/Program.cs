Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if(number<100)
{
  Console.WriteLine("третьей цифры нет");
}
else{
    string number1=number.ToString();
    Console.WriteLine(number1[2]);
}