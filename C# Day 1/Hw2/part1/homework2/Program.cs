// See https://aka.ms/new-console-template for more information
using homework2;


//Question 1 Copying an Array
int[] arr1 = new int[] {1,2,3,4,5,6,7,8,9,10};
int[] arr2 = arr1;

foreach (var item in arr2)
{
    Console.WriteLine(item);
}

int[] arr3 = new int[arr1.Length];

for(int i = 0; i < arr3.Length; i++)
{
    arr3[i] = arr1[i];
}

foreach (var item in arr2)
{
    Console.WriteLine(item);
}

//Question 2
//
/*
Console.Clear();
List<int> theList = new List<int>();


Console.Clear();
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    String command = Console.ReadLine();
    if (command.Equals("+")) {
        Console.WriteLine("Please enter a int you want to insert:");
        int value = int.Parse(Console.ReadLine());
        theList.Add(value);
    }if(command.Equals("-")){
        Console.WriteLine("Please enter a int you want to remove:");
        int value = int.Parse(Console.ReadLine());
        if (theList.Contains(value))
        {
            theList.Remove(value);
        }
        

    }
    if (command.Equals("--")) {
        Console.WriteLine("remove all the elements in the list");
        theList.Clear();

    }

    Console.WriteLine("The list has the following elements");
    foreach (var item in theList)
    {
        Console.Write(item);
        Console.Write(",");
    }
    Console.WriteLine();
}

//Question 3
// See in Class1.cs (question3)

Console.Clear();
Console.WriteLine("please enter a begin:");
int begin = int.Parse(Console.ReadLine());

Console.WriteLine("please enter a end:");
int end = int.Parse(Console.ReadLine());

int[] result = question3.FindPrimesInRange(begin,end);

foreach (var item in result)
{   
    if(item != 0)
    {
        Console.Write(item);
    }
  
}

*/


//Question 4

int[] Arrayq4 = { 3, 2, 4, -1};
int n = Arrayq4.Length;
int k = 3;

k = k % n;

for (int i = 0; i < n; i++)
{
    if (i < k)
    {


        Console.Write(Arrayq4[n + i - k] + " ");
    }
    else
    {

        Console.Write(Arrayq4[i - k] + " ");
    }
}
Console.WriteLine();

//Question 5


int[] numbers = new[] { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

int count = 1;

int longestNum = numbers[0];

int longestCount = 1;

for (int i = 1; i < numbers.Length; i++)
{
    // We're starting a new sequence
    if (numbers[i] != numbers[i - 1])
    {
        count = 0;
    }

    count++;
    if (count > longestCount)
    {
        longestCount = count;
        longestNum = numbers[i];
    }
}


Console.WriteLine(
    string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));


int[] result = new int[longestCount];
Array.Fill(result, longestNum);

//question 7

/*
 * 
 * int[] arrQ7 = new int [] { 0, 1, 1, 5, 2, 2, 6, 3, 3 };
int[] arrQ7H = new int [int.MaxValue];
int max = 0;


for(int i = 0; i < arrQ7.Length; i++)
{
    if (arrQ7H[arrQ7[i]] > max)
    {
        max = arrQ7H[arrQ7[i]];
    }

    arrQ7H[arrQ7[i]]++;

}

Console.WriteLine($"the most number is{arrQ7[max]}");

*/





