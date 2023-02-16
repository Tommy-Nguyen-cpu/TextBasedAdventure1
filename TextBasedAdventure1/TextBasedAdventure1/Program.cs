// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, you're now trapped in a dungeon. The only way out is through one of these doors.");

static void PlayerChoice()
{
    Console.WriteLine("Two doors stand in front of you. Please enter 1 or 2 in order to choose one");
    string Choice = Console.ReadLine();
    GenerateDoor();
}

static (bool, bool) GenerateDoor()
{
    Random random = new Random();
    int test = random.Next(0, 1);
    if (test == 0)
    {
        return (true, false);
    }
    return (false, true);
}

