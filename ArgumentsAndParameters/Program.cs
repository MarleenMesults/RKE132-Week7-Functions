Console.WriteLine("How many steps have you walked today?");
int userSteps = Int32.Parse(Console.ReadLine());

double result = HealthMonitor(userSteps);
Console.WriteLine(userSteps);

static void HealthMonitor(int steps)
{
    if (steps < 4000)
    {

        Console.WriteLine("You need to move more.");
    }
    else if (steps >= 4000 && steps < 8000)
    {

        Console.WriteLine("Health goal achieved,");
    }
    else
    {

        Console.WriteLine("Well done!");
    }
}