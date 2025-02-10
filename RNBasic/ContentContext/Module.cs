namespace RNBasic.ContentContext;

public class Module
{
  public Module()
  {
    Title = string.Empty;
    Lectures = new List<Lecture>();
  }
  public int Order { get; set; }
  public string Title { get; set; }
  public IList<Lecture> Lectures { get; set; }
}