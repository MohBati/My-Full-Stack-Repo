Console.WriteLine("Welcome to the calculator!");

while(true)
{
Console.WriteLine("Press 1 for addition");
Console.WriteLine("Press 2 for subtraction");
Console.WriteLine("Press 3 for multiplication");
Console.WriteLine("Press 4 for division");
Console.WriteLine("Press 5 to exit");
Console.WriteLine(); //Blank line

int input = Convert.ToInt32(Console.ReadLine());

if (input == 5)
{
    Console.WriteLine("Goodbye!");
    Thread.Sleep(1000);
    Environment.Exit(0);
}

Console.WriteLine("Please enter the first number");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
int y = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (input == 1)
{
    result = x + y;
}
else if (input == 2)
{
    result = x - y;
}
else if (input == 3)
{
    result = x * y;
}
else if (input == 4)
{
   result = x / y;
}
Console.WriteLine(); //Blank line
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"The result is: {result}");
Console.ResetColor();
Console.WriteLine(); //Blank line

Thread.Sleep(1500);

}
