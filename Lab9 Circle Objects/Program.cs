
using Lab9_Circle_Objects;

int circleCounter = 0;
bool doingMath = true;
while (doingMath)
{
    Console.WriteLine("Welcome to the Circle Tester");

    //get input
    Console.WriteLine("Enter radius: ");
    double _radius = double.Parse(Console.ReadLine());

    //make new circle
    Circle myCircle = new Circle(_radius);

    Console.WriteLine($"Circumfrence: {myCircle.CalculateFormattedCircumfrence()}");
    Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");
    circleCounter++;

    while (true)
    {
        Console.WriteLine("Do you want to go again? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            doingMath = true;
            break;
        }
        else if (choice == "n")
        {
            doingMath = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

Console.WriteLine($"You made {circleCounter} circles. Goodbye");
