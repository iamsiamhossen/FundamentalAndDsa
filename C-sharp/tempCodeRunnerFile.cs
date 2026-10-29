int number1, number2;
number1 = int.Parse(Console.ReadLine());
number2 = int.Parse(Console.ReadLine());
if (number1 < number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}
Console.WriteLine($"The larger number is: {number1}");