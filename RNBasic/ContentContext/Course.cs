using RNBasic.ContentContext.Enums;

namespace RNBasic.ContentContext;

public class Course : Content
{
  public Course(string tilte, string url)
    : base(tilte, url)
  {
    Tag = string.Empty;
    Modules = new List<Module>();
  }
  public string Tag { get; set; }
  public IList<Module> Modules { get; set; }
  public int DurationInMinutes { get; set; }
  public EContentLevel Level { get; set; }
}