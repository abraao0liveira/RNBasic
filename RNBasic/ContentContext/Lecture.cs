using RNBasic.ContentContext.Enums;

namespace RNBasic.ContentContext;

public class Lecture
{
  public int Ordem { get; set; }
  public string Title { get; set; } = string.Empty;
  public int DurationInMinutes { get; set; }
  public EContentLevel Level { get; set; }
}