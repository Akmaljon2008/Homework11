List<int> numbers = new List<int> { 1, 2, -5, 99858, 151 };
int number = numbers.Find(x => x < 0); 
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("----------------------------------");
System.Console.WriteLine(number);