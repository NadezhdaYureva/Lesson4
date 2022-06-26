// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int powerInt (int number, int power)
{
    if (power ==0) return 1;
    int result = number;
    for (int i = 1; i<power; i++)
    {
       result=result*number;
    }
    return result;
}

int a = Prompt("Введите число А ");
int b = Prompt("Введите число B ");
Console.WriteLine($"Число А в степени B равно {powerInt(a, b)}");
