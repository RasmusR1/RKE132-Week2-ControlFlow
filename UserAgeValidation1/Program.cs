// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young for Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}
//int userAge = Int32.Parse(Console.ReadLine());
