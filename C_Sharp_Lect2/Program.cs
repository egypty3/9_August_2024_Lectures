int x = 5;
Console.WriteLine(
    "is x > 3 and x < 10 and x== 6 ? " +
        ((x > 3) && (x < 10) && (x== 6))
    );

Console.WriteLine(
    "is x > 3 || x < 4 ? " +
        (x > 3 || x < 4)
    );

Console.WriteLine(
    "is x is not positive ? " +
        ! ( x > 0)
    );



Console.WriteLine( "The largest number is : " +
        Math.Max(5, 10)
    );

Console.WriteLine("The smallest number is : " +
        Math.Min(5, 10)
    );

Console.WriteLine("The square root of : " +
        Math.Sqrt(64)
    );

Console.WriteLine("The absolute value  of -4.7 : " +
        Math.Abs(-4.7)
    );

Console.WriteLine("The Rounded value  of 9.75 : " +
        Math.Round(9.75,1)
    );




string firstName = "Tarek";
string lastName = "Mamdouh";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

string myString = "Hello";

Console.WriteLine(myString[0]); // array access 

Console.WriteLine(myString.IndexOf("e"));



// Sentence
//string sentence = "I am learning \"C#\" programming is cool";
//Console.WriteLine(sentence);

//Console.ForegroundColor = ConsoleColor.Cyan;

//Console.WriteLine("Enter the search word : ");
//string searchWord = Console.ReadLine();
//// Location of word "programming"
//int index = sentence.IndexOf(searchWord);

//// get the text of programming and after
//string serachAndAfter = sentence.Substring(index);

//Console.ForegroundColor = ConsoleColor.Green;

//// print the result
//Console.WriteLine(serachAndAfter);

//Console.ForegroundColor = ConsoleColor.White;

////////////////////////////////////////////////
///
int myAge = 45;
int votingAge = 18;

bool canVote = 
    myAge >= votingAge;

Console.WriteLine($"voting ability : {canVote}");

//////////////////////////////////////////////////////

DateTime myDate = DateTime.Now;

Console.WriteLine(myDate);

int currentHour = myDate.Hour;


//if (currentHour < 12)
//{
//    Console.WriteLine("Good Morning");
//}
//else if (currentHour < 18)
//{
//    Console.WriteLine("Good Afternoon");
//}
//else
//{
//    Console.WriteLine("Good Evening");
//}

//////////////////////////////////////////////////////  
/// using short if
/// 
string greeting = (currentHour < 12) ? "Good Morning" : "Good Afternoon" ;

Console.WriteLine(greeting);


/////////////////////////////////////////////////////
/// switch case based on the day of the week and print the day name in arabic
/// 

int day = (int) myDate.DayOfWeek;
Console.WriteLine(day);

string dayName = "";

switch (day)
{
    case 0:
        dayName = "الأحد";
        break;
    case 1:
        dayName = "الإثنين";
        break;
    case 2:
        dayName = "الثلاثاء";
        break;
    case 3:
        dayName = "الأربعاء";
        break;
    case 4:
        dayName = "الخميس";
        break;
    case 5:
        dayName = "الجمعة";
        break;
    case 6:
        dayName = "السبت";
        break;
    default:
        break;
}



Console.WriteLine(dayName);