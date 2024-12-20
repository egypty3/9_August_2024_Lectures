// Declaring variables example
string name = "Samer";
name = "Alaa";

Console.WriteLine("Hello " + name);

int x = 9;
int y = 12;

Console.WriteLine(x + y);

// declare varity of variables with a different data types
int age = 25;
double height = 1.75;
bool isStudent = false;

// declare more variables
string firstName = "Samer";
string lastName = "Najjar";
//string fullName = firstName + " " + lastName;

//Console.WriteLine("Hello " + fullName);

// string interpolation
Console.WriteLine($"Hello {firstName} {lastName}" );

// declare the pi constant
const double PI = 3.14;
//PI = 3.15; // error

// clacluate the area of a circle with radius 5
double radius = 5;
double area = PI * radius * radius;

Console.WriteLine($"The area of the circle with radius {radius} cm is {area} cm squared");



//////////////////////////////
///
/// Type Casting Example
/// implicit casting
/// 

int a = 10;
long b = a;

Console.WriteLine($"b is {b}");

// explicit casting
long c = 5000000000;
int d = (int) c;

Console.WriteLine($"d is {d}");

// Profit calculation example
Console.WriteLine("Enter the amount of money in dollars");
string money = Console.ReadLine();
double moneyAmount = double.Parse(money);

Console.WriteLine("Enter the profit percentage ");
string profit = Console.ReadLine();
double profitPercentage = double.Parse(profit);

double totalAmountAfterProfit =
                moneyAmount + (moneyAmount * profitPercentage / 100);

Console.WriteLine($"The total amount after profit is {totalAmountAfterProfit} US dollar");