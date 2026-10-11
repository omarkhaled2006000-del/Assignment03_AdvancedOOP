//Exercise one
List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70,100,65 };
Console.WriteLine("======== Grades ========");
foreach (int numbers in grades)
{
    Console.WriteLine(numbers);
}
Console.WriteLine("======== Count ========");
Console.WriteLine(grades.Count());
Console.WriteLine("======== first grade ========");
Console.WriteLine(grades.First());
Console.WriteLine("======== last grade ========");
Console.WriteLine(grades.Last());
Console.WriteLine("======== sorting ascendingly ========");
grades.Sort();
foreach (int number in grades)
{
    Console.WriteLine(number);
}
Console.WriteLine("======== Grades above 90 ========");
foreach(int number in grades)
{
    if (number > 90)
    {
        Console.WriteLine(number);
    }
}
Console.WriteLine("======== failling grades ========");
foreach(int number in grades)
{
    if (number < 75)
    {
        Console.WriteLine(number);
    }
}
Console.WriteLine("======== removing grades below 75 ========");
foreach(int number in grades.ToList())
{
    if (number < 75)
    {
        grades.Remove(number);
    }
}
foreach (int number in grades)
{
    Console.WriteLine(number);
}
Console.WriteLine("======== grades equal to 100 ========");
foreach(int number in grades)
{
    if (number == 100)
    {
        Console.WriteLine(number);
    }
}

Console.WriteLine("======== transform to strings ========");


List<string> gradestrings = grades.Select(x => x.ToString()).ToList();
Console.WriteLine("\nGrade Strings");

foreach (string number in gradestrings)
{
    Console.WriteLine($"Grade : {number}");
}
