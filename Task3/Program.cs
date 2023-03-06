List<int> numbers = new List<int> { 10, 20, -5, 35, -42, 8, 16, -39, 58, -71, 63 };
var result = numbers
    .Where(n => n > 0)
    .Select(n => n % 10)
    .Distinct();
foreach (int digit in result)
    Console.Write($"{digit} ");