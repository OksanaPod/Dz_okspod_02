Console.WriteLine("Введите число 1-7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number<0 && number>7){
Console.WriteLine("Ошибка ввода ");
}
else{
    if(number>5){
        Console.WriteLine("выходной");
    }
    else{
        Console.WriteLine("будний");
    }
}