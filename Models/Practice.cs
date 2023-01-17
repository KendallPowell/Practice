namespace Practice.Models;

public class Practice
{
  public Practice(int id, string name, int level, string type);
    {
        Id = id;
        Name = name;
        Level = level;
        Type = type
}
public int Id { get; set; }
public string Name { get; set; }
public int Level { get; set; }
public string Type { get; set; }
}
