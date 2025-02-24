Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
var firstAsText = Console.ReadLine();
int a = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");
var secondAsText = Console.ReadLine();
int b = int.Parse(secondAsText);

Console.WriteLine("What would you like to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var choice = Console.ReadLine().ToLower();

if (EqualCaseInsensitive(choice, "A"))
{
    var sum = a + b;
    PrintFinalEquation(a, b, sum, "+");
} 
else if (EqualCaseInsensitive(choice, "S"))
{
    var difference = a - b;
    PrintFinalEquation(a, b, difference, "-");
} 
else if (EqualCaseInsensitive(choice, "M"))
{
    var multipied = a * b;
    PrintFinalEquation(a, b, multipied, "*");
}
else
{
    Console.WriteLine("Invalid choice");
}

Console.WriteLine("Press an key to close.");
Console.ReadKey();
 
void PrintFinalEquation(int a, int b, int result, string @operator)
{
    Console.WriteLine(a + " "+ @operator +" "+ b + " = " + result);
    
}

bool EqualCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}