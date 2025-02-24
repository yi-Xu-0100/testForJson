﻿using Newtonsoft.Json;

namespace testForJson;

class TestForJsonArray
{
    public List<double> TestArray { get; set; } = [1, 1];
}

public class Program()
{
    static void Main()
    {
        string testString = @"{TestArray : [2,2]}";
        Console.WriteLine($"{nameof(testString)}: {testString}");
        var testModel = JsonConvert.DeserializeObject<TestForJsonArray>(testString);

        string testModelString = JsonConvert.SerializeObject(testModel);
        Console.WriteLine($"{nameof(testModelString)}: {testModelString}");
    }
}
