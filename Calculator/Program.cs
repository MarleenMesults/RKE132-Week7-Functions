
Console.WriteLine("Enter the operation (+ or - or * or /):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{

    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        subtraction(firstNum, secondNum);
        break;
    case '*':
        multiplication(firstNum, secondNum);
        break;
    case '/':
        divided(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}
static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}

static void multiplication(int a, int b)
{
    Console.WriteLine($"{a} * {b} = {a * b}");
}

static void divided(int a, int b)
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}
