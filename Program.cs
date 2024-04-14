//C# Basics part 2 task 

using System.Linq;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

var lunchTime = 16;
if (11 < lunchTime && lunchTime < 14)
{
    Console.WriteLine("It is lunch time");
} else { Console.WriteLine("lunch time is not valid"); }
//loops
int[] nums = { 12, 24, 36 };
int count = 0;
for (int i = 0; i< nums.Length; i++)
{
    count += nums[i];
}
Console.WriteLine(count);


int countDown = 5;
while (countDown >= 1)
{
    Console.WriteLine(countDown);
    countDown--;
}


string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
foreach (string day in daysOfTheWeek)
{
    Console.WriteLine($"{day}");
}
//multi-dimentional array
int[,] numbers = { { 1, 9, 2 }, { 3, 6, 7 }};
Console.WriteLine(numbers[0, 1]);

// C# LINQ and functions 
// even and odd  task 1
int[] check_numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumber = check_numbers.Where(check_numbers => check_numbers % 2 == 0);
var oddNumber = check_numbers.Where(check_numbers => check_numbers % 2 == 1);

foreach (var number in evenNumber)
{
    Console.WriteLine("even number " + number);  
}
foreach (var number in oddNumber)
{
    Console.WriteLine("odd number "+ number);
}

// task 2
double[] studentsGrades = { 40, 90, 55, 88, 70, 66, 65, 89 };
var output = studentsGrades.Where(g => g >= 70).Count();

var gradeScale = studentsGrades.Select( g =>
{
    if (g >= 90) return "A";
    if (g >= 80 && g < 90) return "B";
    if (g >= 70 && g < 80) return "C";
    if (g >= 60 && g < 70) return "D";
    return "F";
}). GroupBy(v=> v).ToList();

foreach(var gradeGroup in gradeScale)
{
    Console.WriteLine($"{gradeGroup.Key}: {gradeGroup.Count()}");
}

var avgGrade = studentsGrades.Average();
Array.Sort(studentsGrades);
foreach (int i in studentsGrades)
{
    Console.WriteLine(i);

}

Console.WriteLine($"class Average   {avgGrade: 00.00}");

GreetPerson();
BoxVolume();
void GreetPerson()
{
    Console.WriteLine("please write your name ");

    string name = Console.ReadLine();
    Console.WriteLine($"Welcome {name} we are so great to see you.");
}


void BoxVolume()
{
    Console.WriteLine("Enter Width");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Length");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Height");
    double height = Convert.ToDouble(Console.ReadLine());
    double volume = width * length * height;
    Console.WriteLine($"the volume of the box = {volume: 00.00} ");

}



