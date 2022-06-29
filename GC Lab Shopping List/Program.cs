

//gas station snacks
/* What will the application do?
Display at least 8 item names and prices.
Ask the user to enter an item name
If that item exists, display that item and price and add that item and its price to the user’s order.
If that item doesn’t exist, display an error and re-prompt the user.  (Display the menu again if you’d like.)
After adding one to their order, ask if they want to add another. If so, repeat.  (User can enter an item more than once; we’re not keeping track of quantity at this point.)
When they’re done adding items, display a list of all items ordered with prices in columns.
Display the sum price of the items ordered.

 */

//sum: loop through list of strings, for every item, to contribute to total.
//DO NOT STORE PRICES IN SEPARATE LIST, use dictionary


Dictionary<string, double> menu = new Dictionary<string, double>();
menu.Add("coffee", 1.50);
menu.Add("coke", 2.00);
menu.Add("chips", 1.50);
menu.Add("water", 1.00);
menu.Add("sprite", 2.00);
menu.Add("doritos", 1.50);
menu.Add("gum", 1.25);
menu.Add("ice tea", 1.50);

//List<string> orderList = new List<string> { "coffee", "coke", "chips", "water", "sprite", "doritos", "gum", "iced tea" };
List<string> orderList = new List<string> { };

double total = 0;

Console.WriteLine("Hello, welcome to this gas station.");
Console.WriteLine("Item\tPrice");
Console.WriteLine("=====\t=====");


bool addItems = true;
while (addItems)
{
    foreach (KeyValuePair<string, double> kvp in menu)
    {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }

    Console.WriteLine("what item would you like to order?");
    string input = Console.ReadLine();
    orderList.Add(input);

    bool choice = menu.ContainsKey(input);

    if (choice == true)
    {
        Console.WriteLine($"okay, adding {input} to cart at ${menu[input]}");
    }
    else
    {
        Console.WriteLine("Sorry, we don't have those.  Please try again.");
    }

    


    Console.WriteLine("Would you like anything else? y/n");
    string choice2 = Console.ReadLine();

    //bool addItem = true;
    //while (addItem)

    if (choice2 == "y")
    {

    }
    else if (choice2 == "n")
    {
        addItems = false;
    }
    else
    {
        Console.WriteLine("Sorry, please type y/n");

    }
}


    Console.WriteLine("Here is everything you've ordered:");

    for (int i = 0; i < orderList.Count; i++)
    {
        Console.WriteLine($"{orderList[i]} costs {menu[orderList[i]]}");
        total += menu[orderList[i]];
    }


    Console.WriteLine($"Your total is: ${total}.");


