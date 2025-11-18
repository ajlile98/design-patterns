using System;

namespace DesignPatterns.Patterns.Behavioral.TemplateMethod;

abstract public class DataProcessor
{
  public void Process()
  {
    LoadData();
    ValidateData();
    TransformData();
    SaveData();
  }

  protected abstract void LoadData();
  protected abstract void ValidateData();
  protected virtual void TransformData()
  {
    Console.WriteLine("Default TransformData()");
  }
  protected abstract void SaveData();
}
