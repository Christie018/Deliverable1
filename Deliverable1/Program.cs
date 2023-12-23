// See https://aka.ms/new-console-template for more information
int sodaRestock = 40;
int sodaStock = 100;
int chipRestock = 20;
int chipStock = 40;
int candyRestock = 40;
int candyStock = 60;
int input = 0;

Console.WriteLine("Welcome to the restocking tool.");

// Checking soda stock 
Console.WriteLine("How many sodas have been sold today? 100 are in stock.");

input = int.Parse(Console.ReadLine());

if (input <= sodaStock) {
    sodaStock -= input;
    Console.WriteLine("There are " + sodaStock + " sodas left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

//Checking chip stock
Console.WriteLine("How many chips have been sold today? 40 are in stock.");

input = int.Parse(Console.ReadLine());

if (input <= chipStock)
{
    chipStock -= input;
    Console.WriteLine("There are " + chipStock + " chips left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

//Checking candy stock
Console.WriteLine("How much candy has been sold today? 60 are in stock.");

input = int.Parse(Console.ReadLine());

if (input <= candyStock)
{
    candyStock -= input;
    Console.WriteLine("There are " + candyStock + " candies left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");

//Checking soda restock
if(sodaStock <= sodaRestock)
{
    Console.WriteLine("Soda needs to be restocked.");
} else {
    ;
}

//Checking chip restock
if (chipStock <= chipRestock)
{
    Console.WriteLine("Chips need to be restocked.");
}
else
{
    ;
}

//Checking candy restock
if (candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked.");
}
else
{
    ;
}

//If nothing needs to be restocked
if (candyStock > candyRestock && chipStock > chipRestock && sodaStock > sodaRestock)
{
    Console.WriteLine("Nothing needs to be restocked at this time.");
} else {
    ;
}

Console.WriteLine("Goodbye!");