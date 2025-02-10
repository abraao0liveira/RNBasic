namespace RNBasic.ContentContext;

public abstract class Content //nunca pode ser instanciado por ser "abstract", mas pode herdar
{
  public Content(string title, string url)
  {
    Id = Guid.NewGuid(); //cria um hash automatico
    Title = title;
    Url = url;
  }
  public Guid Id { get; set; }
  public string Title { get; set; }
  public string Url { get; set; }
}