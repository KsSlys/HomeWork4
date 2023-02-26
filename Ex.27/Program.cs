// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {n} -> {SumNumbers(n)}");

int SumNumbers(int n)
{
    int result = 0;
    while (n > 0){
        result = result + n%10;
        n/= 10;
    }
    return result;

}