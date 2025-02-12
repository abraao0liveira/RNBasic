using RNBasic.SharedContext;

namespace RNBasic.ContentContext;

public abstract class Content : BaseContent //nunca pode ser instanciado por ser "abstract", mas pode herdar
{
  public Content(string title, string url)
  {
    Title = title;
    Url = url;
  }
  public string Title { get; set; }
  public string Url { get; set; }
}