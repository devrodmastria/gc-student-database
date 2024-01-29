
// author: Rod M
// topic: Unit 3 - Lab - Student Database

Console.WriteLine("-------------- GC Student Database --------------");

string[] Names = { "Rod Mastria", "Elijah Reid", "Logan Reeves", "Dominic Nutaitis", "Ethan Thomas", "Justin Jones" };
string[] Foods = { "Anything Italian", "Spaghetti", "Wings", "Sushi", "Jambalaya", "Baja Blast" };
string[] Homes = { "Detroit/SaoPaulo", "Whitehall", "Mansfield", "New Baltimore", "Rolla", "Grand rapids" };
bool runAgain = true;

Console.WriteLine($"We have {Names.Length} students in this cohort. Which one would you like to look up first?\nPlease enter a number from 1 through {Names.Length}");

while (runAgain)
{

    string input = "";

    bool invalidNameInput = true;
    while (invalidNameInput)
    {
        input = Console.ReadLine();
        int rawValue = int.Parse(input);
        if (rawValue > Names.Length || rawValue <= 0)
        {
            Console.WriteLine($"Please enter a valid student number, between 1 and {Names.Length}");
        }
        else break;
    }

    int indexForName = int.Parse(input) - 1;

    Console.WriteLine();
    Console.WriteLine($"Great! You chose {Names[indexForName]}");
    Console.WriteLine();
    Console.WriteLine("What would you like to look up next? Hometown (1) or Favorite Meal(2) ?\nPlease enter either 1 or 2");

    int indexCategory = 0;

    bool invalidCategoryInput = true;
    while (invalidCategoryInput)
    {
        string inputCategory = Console.ReadLine();
        indexCategory = int.Parse(inputCategory);
        if (indexCategory > 2 || indexCategory <= 0)
        {
            Console.WriteLine("Please enter a valid category, either 1 or 2, for Hometown (1) or Favorite Meal(2)");
        }
        else break;
    }

    switch (indexCategory)
    {
        case 1: 
            Console.WriteLine($"{Names[indexForName]}'s hometown is {Homes[indexForName]}"); 
            break;
        default:
            Console.WriteLine($"{Names[indexForName]}'s favorite meal is {Foods[indexForName]}");
            break;

    }

    Console.WriteLine("Would you like to look up another student? yes/no");
    string replay = Console.ReadLine();
    if (replay.ToLower().Trim().Contains("y"))
    {
        Console.WriteLine($"Which one would you like to look up next? 1-{Names.Length}");
    } else
    {
        runAgain = false;
        Console.WriteLine("Thanks for playing, have a nice day!");
    }
}

