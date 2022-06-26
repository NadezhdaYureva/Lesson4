// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigits (int number)
{
    int digit = 0;
    while (number > 0) 
    {
        digit=digit+number%10; 
        number = number / 10; 
    }
    return digit;
}

int number = prompt("Введите число ");
Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigits(number)}");
