List<bool> values = new List<bool>{ true, true, true };
bool allTrue = values.All(x => x);
Console.WriteLine("Are all the values in the list true? " + allTrue);