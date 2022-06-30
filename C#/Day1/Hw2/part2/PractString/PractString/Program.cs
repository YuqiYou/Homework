//Question 1 reverse string

/*
Console.WriteLine("Please enter a String");
String in1 = Console.ReadLine();
char[] cArray = in1.ToCharArray();
String reverse = String.Empty;
for (int i = cArray.Length - 1; i > -1; i--)
{
    reverse += cArray[i];
}

Console.WriteLine("The reversed array is: " + reverse);
*/

//Question 2
//i didnot figure this out...


//Question 3
/*
String ipt = Console.ReadLine();
Boolean y = Q3.Pal(ipt);

if (y) { Console.WriteLine("it's a palindrom"); }
else { Console.WriteLine("not a palindrom"); }
*/

//Question 4

// Taking a string
String str = "https://www.apple.com/iphone/";

String[] spearator = { "://, ", "/" };
Int32 count = 2;

// using the method
String[] strlist = str.Split(spearator, count,
       StringSplitOptions.RemoveEmptyEntries);

foreach (String s in strlist)
{
    Console.WriteLine(s);
}