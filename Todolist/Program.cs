// Console.WriteLine("Hello, World!");
// Console.WriteLine("What would you like to do?");
// Console.WriteLine("[S]ee all TODO's");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");
//
// var userChoice = Console.ReadLine();
//
// switch (userChoice)
// {
//     case "S":
//     case "s":
//         PrintSelectedOption("See all TODOs");
//         Console.WriteLine("Extra content");
//         break;
//     case "A":
//     case "a":
//         PrintSelectedOption("Add a TODO");
//         break;
//     case "R":
//     case "r":
//         PrintSelectedOption("Remove a TODO");
//         break;
//     case "E":
//     case "e":
//         PrintSelectedOption("Exit");
//         break;
//     default:
//         Console.WriteLine("invalid choice");
//         break;
// }



// grading app
// Console.WriteLine("input the points");
// char convertPointsToGrade(int points)
// {
//     switch(points)
//     {
//         case 10:
//         case 9:
//             return 'A';
//         case 8:
//         case 7:
//         case 6:
//             return 'B';
//         case 5:
//         case 4:
//         case 3:
//             return 'C';
//         case 2:
//         case 1:
//             return 'D';
//         case 0:
//             return 'E';
//         default:
//             return '!';
//     }
// }



var number = 0;
while (number < 10)
{
    number++;
    Console.WriteLine(number);
}
Console.WriteLine("The loop is finished");
Console.ReadLine();

