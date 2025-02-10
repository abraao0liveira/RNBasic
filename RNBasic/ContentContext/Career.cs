namespace RNBasic.ContentContext;

public class Career : Content
{
  public Career(string title, string url)
    : base(title, url)
  {
    Items = new List<CareerItem>();
  }
  public IList<CareerItem> Items { get; set; }

  // public int TotalCourses
  // {
  //   get
  //   {
  //     return Items.Count;
  //   }
  // } //removi o "set" para não ocorrer alterações
  
  //se eu tiver somente uma linha no get, posso usar esse formato:
  public int TotalCourses => Items.Count;
}
