List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 5 };
bool allUnique = numbers.Distinct().Count() == numbers.Count;
if (allUnique)
    Console.WriteLine("Всi елементи унiкальнi");
else
    Console.WriteLine("Список мiстить повторюванi елементи");
        