﻿Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userInput = Console.ReadLine();
Console.WriteLine("User input: " + userInput);
userInput = "ABC";

var isUserInputAbc = userInput == "ABC";
var isUserInputNotAbc = userInput != "ABC";
var isUserInputNotAbc2 = !(userInput == "ABC");

var number = 10;

var isLargerThan5 = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;

var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number == 6;

if (userInput.Length <= 3)
{
    Console.WriteLine("User input is short");
}
else if (userInput.Length < 10)
{
    Console.WriteLine("User input is medium");
}
else
{
    Console.WriteLine("User input is long");
}

 
Console.ReadKey();
// string userInput = "A";
// Console.WriteLine(userInput);
//
// userInput = "ABC";
// Console.WriteLine(userInput);
//
// int number;
// number = 6;
//
// Console.WriteLine(number);
//
//
// int a = 10;
// int b = 25;
// ++a;
// --b;
// Console.WriteLine(a);
// Console.WriteLine(b);
//
// Console.WriteLine("Addition: " + (a + b));
// Console.WriteLine("Subtrsaction: " + (a - b));
// Console.WriteLine("Multiplication: " + a * b);
// Console.WriteLine("Division: " + a / b);
// Console.WriteLine("john" + " " + "Smith");
//
// string word = "abc";
// Console.WriteLine(word + a);
//


var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

// // the below is example of poor quality code 
// if (userChoice == "S")
// {
//     PrintSelectedOption("See all TODOs");
// }
// else if (userChoice == "A")
// {
//     PrintSelectedOption("Add a TODO");
// }
// else if (userChoice == "R")
// {
//     PrintSelectedOption("Remove a TODO");
// }
// else if (userChoice == "E")
// {
//     PrintSelectedOption("Exit");
// }
// Console.ReadKey();

// void PrintSelectedOption(string selectedOption)
// {
//     Console.WriteLine($"Selected option: " + selectedOption);
// }

int Add(int a, int b)
{
    return a + b;
}

