// See https://aka.ms/new-console-template for more information
using System.Globalization;
/*
 * 
//FIzzBuzz game
Console.Clear();
for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("fizzbuzz"); }
    else if (i % 3 == 0) { Console.WriteLine("fizz"); }
    else if (i % 5 == 0) { Console.WriteLine("buzz"); }
}


//COUNT to 500
//This code will keep printing from 0 to 255 forever
int max = 500;
Console.WriteLine(byte.MaxValue);

//Warning max of byte is less than 500 so that it will not reach it

for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}


//2. Printing pyramid
Console.Write("Input number of rows for this pattern :");
int n = Convert.ToInt32(Console.ReadLine()) +1;
int j;
for (int i = 0; i < n; i++)
{
    for (j = 1; j <= n - i; j++)
        Console.Write(" ");
    for (j = 1; j <= 2 * i - 1; j++)
        Console.Write("*");
    Console.Write("\n");
}

//3 . Guess random number
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("please guess what the number is between 1 and 3");
int value = Int32.Parse(Console.ReadLine());
if (correctNumber == max) Console.WriteLine("Yes!");


while (correctNumber != value) {
    Console.WriteLine("please guess what the number is between 1 and 3");
    if(value > 0 && value <= 3)
    {
        value = Int32.Parse(Console.ReadLine());
        if (value < correctNumber) Console.WriteLine("too small");
        else if (value > correctNumber) Console.WriteLine("too big");
        else Console.WriteLine("Yes!");
    }
    else
    {
        Console.WriteLine("Please enter within range 1 to 3");
    }
}






//4. birthdate

Console.WriteLine("please enter your year ");
int Year = int.Parse(Console.ReadLine());
Console.WriteLine("please enter your Month ");
int Month = int.Parse(Console.ReadLine());
Console.WriteLine("please enter your Day ");
int Day = int.Parse(Console.ReadLine());

Console.WriteLine($"You have lived {(2022-Year) * 365 + (6-Month) * 30 + (29-Day)} Days!!");



//5 . Date time program
int Time = DateTime.Now.Hour;
if (Time < 12 && Time >= 6)
{
    Console.WriteLine("Good Morning");
}
if (Time < 17 && Time >= 12)
{
    Console.WriteLine("Good AfterNoon");
}
if (Time < 21 && Time >= 17)
{
   Console.WriteLine("Good Evening");
}

if(Time >= 21 && Time < 6)  Console.WriteLine("Good Night");

//DateTime date1 = new DateTime(2022, 6, 29, 3, 14, 0);
//Console.WriteLine(date1.ToString("G",
//                  DateTimeFormatInfo.InvariantInfo));
//// Displays 04/10/2008 06:30:00
//Console.WriteLine(date1.ToString("G",
//                  CultureInfo.CreateSpecificCulture("en-us")));
//// Displays 4/10/2008 6:30:00 AM
//Console.WriteLine(date1.ToString("G",
//                  CultureInfo.CreateSpecificCulture("nl-BE")));
//// Displays 10/04/2008 6:30:00


*/


//6 LOOP
Console.Clear();
for(int i = 1; i <= 4; i++)
{
    
    for (int j = 0; j <= 24; j = j + i)
    {
        Console.Write(j + ",");
        
    }
    Console.WriteLine();
}
