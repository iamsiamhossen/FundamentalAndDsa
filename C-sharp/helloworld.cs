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
// int number1, number2;
// number1 = int.Parse(Console.ReadLine());
// number2 = int.Parse(Console.ReadLine());
// int modnumber = number1 % number2;
// if (number1 < number2)
// {
//     int temp = number1;
//     number1 = number2;
//     number2 = temp;
// }
// Console.WriteLine($"The remainder is: {modnumber}");
// for (int i = 1; i <= 4; i++)
// {
//     if (i % 2 == 0)
//     {
//         for (int j = 1; j <= 4; j++)
//         {
//             Console.Write("25 ");
//         }
//     }
//     else
//     {
//         for (int j = 1; j <= 4; j++)
//         {
//             Console.Write("25");
//         }
//     }
//     Console.WriteLine();
// }
// Write a C# program that removes a specified character from a non-empty string using the index of a character.
// string input="w3resource.com";
// int index=1;
// string result = input.Remove(index, 1);
// Console.WriteLine(result);
// Write a C# program to create a new string from a given string where the first and last characters change their positions.
string input = "w3resource.com";
char firstChar = input[0];
char lastChar = input[input.Length - 1];
string result = lastChar + input.Substring(1, input.Length - 2) + firstChar;
Console.WriteLine(result);