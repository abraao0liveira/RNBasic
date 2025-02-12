using RNBasic.ContentContext.Enums;
using RNBasic.SharedContext;

namespace RNBasic.ContentContext;

public class Lecture : BaseContent
{
  public int Ordem { get; set; }
  public string Title { get; set; } = string.Empty;
  public int DurationInMinutes { get; set; }
  public EContentLevel Level { get; set; }
}