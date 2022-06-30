using System.Collections;

//menu steup
Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("coffee", 1);
menu.Add("coke", 2);
menu.Add("chips", 1);
menu.Add("water", 1);
menu.Add("sprite", 2);
menu.Add("doritos", 1);
menu.Add("gum", 1);
menu.Add("ice tea", 1);

//List setup
List<string> orderList = new List<string> { };


//greeting and menu
Console.WriteLine("Hello, welcome to this gas station.");
Console.WriteLine("Item\tPrice");
Console.WriteLine("=====\t=====");

//loop back for adding additional items
bool addItems = true;
while (addItems)
{
    foreach (KeyValuePair<string, decimal> kvp in menu)
    {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
    //loop back if wrong item is ordered
    bool wrongItem = true;
    while (wrongItem)
    {
        Console.WriteLine("what item would you like to order?");
        string input = Console.ReadLine();
        orderList.Add(input);

        bool choice = menu.ContainsKey(input);

        if (choice == true)
        {
            Console.WriteLine($"okay, adding {input} to cart at ${menu[input]}");
            wrongItem = false;
            break;
        }
        else
        {
            Console.WriteLine("Sorry, we don't have those.  Please try again.");
        }
    }

    Console.WriteLine("Would you like anything else? y/n");
    string choice2 = Console.ReadLine();

    if (choice2 == "y")
    {

    }
    else if (choice2 == "n")
    {
        addItems = false;
        break;
    }
    else
    {
        Console.WriteLine("Sorry, please type y/n");        
    }

}
//determining total
decimal total = 0;
Console.WriteLine("Here is everything you've ordered:");

for (int i = 0; i < orderList.Count; i++)
{
Console.WriteLine($"{orderList[i]} costs ${menu[orderList[i]]}");
total += menu[orderList[i]];
}
   
Console.WriteLine($"Your total is: ${total}.  Thanks for stopping by!");


