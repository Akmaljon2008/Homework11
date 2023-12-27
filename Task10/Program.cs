 List<int> numbers = new List<int>();
while (true)
{
    Console.Write("Enter numbers (or '0' for end): ");
    int  input = Convert.ToInt16(Console.ReadLine());

    if (input ==  0)
    {
        break;
    }

    numbers.Add(input);
   
    }
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
