Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoise = Console.ReadLine();

if (userChoise == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}







static void PrintHello()
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}