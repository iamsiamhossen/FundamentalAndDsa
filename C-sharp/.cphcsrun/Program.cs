using System;
// taking input from user
// int number1, number2;
// Console.Write("Enter first number: ");
// number1 = int.Parse(Console.ReadLine());
// Console.Write("Enter second number: ");
// number2 = int.Parse(Console.ReadLine());
// string ans = "Hello World";
// string ans2 = "Hello";
// Console.WriteLine($"Amar nam {ans}, and  amar boyosh {ans2}");
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

