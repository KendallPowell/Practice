namespace Practice.Repositories;

public class PracticesRepository
{
  private List<Practice> practiceDb;

  public PracticesRepository()
  {
    this.practiceDb = new List<Practice>(){
    new Practice(1, "Larry", 2, "Parasaur")
  }
  }
}