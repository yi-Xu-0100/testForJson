namespace testForJson;

class TestForJsonArray
{
    public List<double> TestArray { get; set; } = [1, 1];
}

public class Program()
{
    static void Main()
    {
        string testString = "{\"TestArray\" : [2,2]}";
        Console.WriteLine($"{nameof(testString)}: {testString}");
        var testModel1 = System.Text.Json.JsonSerializer.Deserialize<TestForJsonArray>(testString);
        string testModelString1 = System.Text.Json.JsonSerializer.Serialize(testModel1);
        Console.WriteLine($"{nameof(testModelString1)}: {testModelString1}");

        var testModel2 = Newtonsoft.Json.JsonConvert.DeserializeObject<TestForJsonArray>(
            testString
        );
        string testModelString2 = Newtonsoft.Json.JsonConvert.SerializeObject(testModel2);
        Console.WriteLine($"{nameof(testModelString2)}: {testModelString2}");
    }
}
