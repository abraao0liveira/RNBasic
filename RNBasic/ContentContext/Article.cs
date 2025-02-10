namespace RNBasic.ContentContext;

public class Article : Content //um artigo é apenas um conteúdo
{
  public Article(string title, string url)
    : base(title, url)
  {
  }
}