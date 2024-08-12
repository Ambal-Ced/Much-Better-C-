//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------

//Strings, Int and more

char characs = 'a'; //char only takes a single letter or number enclose with ''
String Name = "Julian"; //string in other hand takes every thing inside ""
string name2 = "Monte"; //another way to use string
int age = 10; //contains number positive and negative
long number = 13765757; // same as int but the limit is higher
double num = 10.0588454930; // This is for those who have decimal points very precise
float num2 = 10.0553f;  // same as double but not precise
decimal nums = 10.32m; // most precise and use for accounting
bool isTrue = true; // bool or boolean determines whether something is true or false
bool isFalse = false;

//we can call this data types like this

Console.WriteLine("My name is" + Name + " " + name2);
Console.WriteLine("My chosen Character is " + characs);
Console.WriteLine("My age is " + age);
Console.WriteLine("The long num i chose is " + number);
Console.WriteLine("While the Double is "+ num);
Console.WriteLine("The float are " + num2);
Console.WriteLine("And the Decimal is " + nums);
Console.WriteLine("And am I a Boy? well its " + isTrue);

// Data Types can be overriden like this

string htr = "upper";
Console.WriteLine(htr);
htr = "lower";//in here we overriden the value of htr which is upper by a value lower
Console.WriteLine(htr);