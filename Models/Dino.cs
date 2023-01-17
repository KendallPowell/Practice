namespace dinoTamed.Models;

public class Dino
{
  public Dino(int id, string name, int level, string type);
{
  Id = id;
  Name = name;
  Level = level;
  Color = color;
  
}
public int Id { get; set; }
public string Name { get; set; }
public int Age { get; set; }
public string Color { get; set; }

}
