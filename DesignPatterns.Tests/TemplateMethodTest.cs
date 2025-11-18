using System;
using DesignPatterns.Patterns.Behavioral.TemplateMethod;

namespace DesignPatterns.Tests;

public class TemplateMethodTest
{
  [Fact]
  public void TestTemplateMethod()
  {
    // Create test data file
    var testData = new List<Person>
    {
      new Person(1, "John Doe", "New York"),
      new Person(2, "Jane Smith", "Los Angeles"),
      new Person(3, "Bob Johnson", "Chicago")
    };
    
    string json = System.Text.Json.JsonSerializer.Serialize(testData);
    File.WriteAllText("data.json", json);

    // Process the data
    var processor = new JsonDataProcessor();
    processor.Process();

    // Verify output file was created
    Assert.True(File.Exists("data.out.json"));

    // Read and verify output
    string output = File.ReadAllText("data.out.json");
    var outputData = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(output);
    
    Assert.NotNull(outputData);
    Assert.Equal(3, outputData.Count);
    Assert.Equal("John Doe", outputData[0].Name);

    // Cleanup
    File.Delete("data.json");
    File.Delete("data.out.json");
  }
}
