Dictionary<int, string> dict = new Dictionary<int, string>()
{
    [1] = "January",
    [2] = "February",
    [3] = "March",
    [4] = "April",
    [5] = "May"
};
List<int> keys = new List<int>(dict.Keys);
List<string> values = new List<string>(dict.Values);
for (int i = 0; i < keys.Count; i++)
    Console.WriteLine(keys[i] + ": " + values[i]);