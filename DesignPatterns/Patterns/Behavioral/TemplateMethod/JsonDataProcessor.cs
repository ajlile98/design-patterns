using System;
using System.Diagnostics;
using System.Text.Json;

namespace DesignPatterns.Patterns.Behavioral.TemplateMethod;

public class JsonDataProcessor : DataProcessor
{
  List<Person> data = new List<Person>();
  protected override void LoadData()
  {
   using (StreamReader r = new StreamReader("data.json"))
    {
      string json = r.ReadToEnd();
      data = JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
    }
  }

  protected override void SaveData()
  {
    using(StreamWriter s = new StreamWriter("data.out.json"))
    {
      string json_string = JsonSerializer.Serialize<List<Person>>(data);
      s.Write(json_string);
    }
  }

  protected override void ValidateData()
  {
    if(data.Count() > 0)
    {
      Console.WriteLine("Data is loaded properly!");
    } else
    {
      Console.WriteLine("ERROR: Data is NOT loaded properly!");
    }
  }
}

public record Person(int Id, string Name, string City);