// See https://aka.ms/new-console-template for more information
static int Multiplication(int x, int y)
{
    int result = x * y;
    return result;
}

static int Division(int x, int y)
{
    int result = x / y;
    return result;
}

Console.WriteLine("What are your desired numbers?");
Console.WriteLine("First number: "); string num1 = Console.ReadLine();
Console.WriteLine("Second number: "); string num2 = Console.ReadLine();

int trueNum1 = int.Parse(num1);
int trueNum2 = int.Parse(num2);

Console.WriteLine("What do you want to do with them? (1.Multiplication  2.Division)");
string type = Console.ReadLine();
if (type == "1")
{
    int answer = Multiplication(trueNum1, trueNum2);
    Console.WriteLine($"The Multiplication of the said numbers is {answer}");
}
else if (type == "2")
{
    int answer = Division(trueNum1, trueNum2);
    Console.WriteLine($"The Division of the said numbers is {answer}");
}
else { Console.WriteLine("Not funny")}

static void phoneNumber1(string x)
{
    int result = x.Length;
    if (result < 11 || result > 11) {
        Console.WriteLine("Dude! that's a wrong number!");
    }
    else {
        Console.WriteLine("I try my best to remember it");
    }
}

Console.WriteLine("What is your desired number?"); string num = Console.ReadLine();

phoneNumber1(num);


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i * 2);
}

static bool phoneNumber1(string x)
{
    int result = x.Length;
    if (result < 11 || result > 11)
    {
        Console.WriteLine("Dude! that's a wrong number!");
        return false;
    }
    else
    {
        Console.WriteLine("I try my best to remember it");
        return true;
    }
}

bool x;
do
{
    Console.WriteLine("What is your desired number?"); string num = Console.ReadLine();

    x = phoneNumber1(num);
}
while (x == false);

