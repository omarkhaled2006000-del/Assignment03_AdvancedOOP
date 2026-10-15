//Exercise one
using System.Collections.Immutable;

Console.WriteLine("\n --------------- Exercise one ---------------  \n");
List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70,100,65 };
Console.WriteLine("======== Grades ========");
foreach (int numbers in grades)
{
    Console.WriteLine(numbers);
}
Console.WriteLine("======== Count ========");
Console.WriteLine(grades.Count());
Console.WriteLine("===== first grade ======");
Console.WriteLine(grades.First());
Console.WriteLine("======== last grade ====");
Console.WriteLine(grades.Last());
Console.WriteLine("=== sorting ascendingly ===");
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
Console.WriteLine("\n");

Console.WriteLine("\n --------------- Exercise two ---------------  \n");


//Excersie two
Dictionary<int, string> players = new Dictionary<int, string>
{
    {500,"Ahmed"},
    {200,"Sara"},
    {800,"Ali"},
    {350,"Mona"}
};
Console.WriteLine("============ Print ============");
var sortedPlayers = players.OrderByDescending(x => x.Key);
foreach (var player in sortedPlayers)
{
    Console.WriteLine($"Player score: {player.Key}, Name: {player.Value}");
}

Console.WriteLine("============ first key and first value ============");
Console.WriteLine($"Player score: {players.First().Key}, Name: {players.First().Value}");

Console.WriteLine("============ checking if 500 exists ============");
Console.WriteLine($"Does 500 exist = {players.ContainsKey(500)}");

Console.WriteLine("============ get the playeer with score 999 ============");
Console.WriteLine($"Player with score 999 = {players.GetValueOrDefault(999, "Not Found")}");

Console.WriteLine("============ remove player with key 200 ============");
players.Remove(200);
var newPlayers = players.OrderByDescending(x => x.Key);
foreach (var player in newPlayers)
{
    Console.WriteLine($"Player score: {player.Key}, Name: {player.Value}");
}

Console.WriteLine("\n");
Console.WriteLine("\n --------------- Exercise Three ---------------  \n");
//Exercise three
Console.WriteLine("============ Create Phone Book ============");
Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    {"Ahmed", "01012345678"},
    {"Omar", "01112345678"},
    {"Sara", "01212345678"},
    {"Ali", "01512345678"}
};

Console.WriteLine("============ Add New Contact ============");
phoneBook["Mona"] = "01098765432";
Console.WriteLine($"Mona's Number: {phoneBook["Mona"]}");

Console.WriteLine("============ Add Duplicate Using Add() ============");
try
{
    phoneBook.Add("Ahmed", "01000000000");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("============ Add Duplicate Using TryAdd() ============");
Console.WriteLine($"TryAdd succeeded: {phoneBook.TryAdd("Ahmed", "01011111111")}");

Console.WriteLine("============ Search for Non-Existing Contact ============");
Console.WriteLine($"Does Khaled exist = {phoneBook.ContainsKey("Khaled")}");

Console.WriteLine("============ Get Contact with Fallback ============");
Console.WriteLine($"Khaled's Number = {phoneBook.GetValueOrDefault("Khaled", "Not Found")}");

Console.WriteLine("============ Print All Keys ============");
Console.WriteLine(string.Join(", ", phoneBook.Keys));

Console.WriteLine("============ Print All Values ============");
Console.WriteLine(string.Join(", ", phoneBook.Values));

Console.WriteLine("\n");
Console.WriteLine("\n --------------- Exercise Four ---------------  \n");
//Exercise four
HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
{
    "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@TEST.Com"   
};

Console.WriteLine("============ Count ============");
Console.WriteLine($"Number of unique emails: {emails.Count}"); /*because HashSet only count unique emails no redundancy 
                                                                * and also because we used string used StringComparer.OrdinalIgnoreCase 
                                                                * it will ignore the case sensitivity*/
HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };

HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
Console.WriteLine("============ union============");


HashSet<int> union = new HashSet<int>(set1);
union.UnionWith(set2);

foreach (int number in union)
{
    Console.WriteLine(number);
}
Console.WriteLine("============  intersection ============");
HashSet<int> intersection = new HashSet<int>(set1);
intersection.IntersectWith(set2);

foreach (int number in intersection)
{
    Console.WriteLine(number);
}

Console.WriteLine("============  exception ============");
HashSet<int> exception = new HashSet<int>(set1);
exception.ExceptWith(set2);
foreach(int number in exception)
{
    Console.WriteLine(number);
}

Console.WriteLine("============  is SUbset ============");
HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
HashSet<int> setB = new HashSet<int>() { 1, 2 };
Console.WriteLine("Is {1 , 2 } a subset of set A = " + setB.IsSubsetOf(setA));
