namespace TextBasedAdventure1
{
    public static class Program
    {

        public static void Main()
        {
            Console.WriteLine("Hello, you're now trapped in a dungeon. The only way out is through one of these doors.");
            int nonDeadEndDoorsOpened = 0;

            while (nonDeadEndDoorsOpened != 5)
            {
                bool isNonDoorDeadEnd = PlayerChoice();

                if (isNonDoorDeadEnd)
                {
                    Console.WriteLine("The door chosen was the correct door!");
                    nonDeadEndDoorsOpened++;
                    Console.WriteLine("The number of right doors opened is " + nonDeadEndDoorsOpened);
                }
                else
                {
                    Console.WriteLine("The door chosen was a dead end...try again...");
                }
            }

            Console.WriteLine("You reached the exit, congrats!");
        }

        public static bool PlayerChoice()
        {
            Console.WriteLine("Two doors stand in front of you. Please enter 1 or 2 in order to choose one");
            string Choice = Console.ReadLine();
            (bool leftDoor, bool rightDoor) = GenerateDoor();

            if (int.Parse(Choice) == 1)
            {
                return leftDoor;
            }
            else
            {
                return rightDoor;
            }
        }

        public static (bool, bool) GenerateDoor()
        {
            Random random = new Random();
            int test = random.Next(0, 2);
            if (test == 0)
            {
                return (true, false);
            }
            return (false, true);
        }

    }

}