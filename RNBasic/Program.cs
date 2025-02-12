using RNBasic.ContentContext;
using RNBasic.SubscriptionContext;

namespace RNBasic;

class Program
{
  static void Main(string[] args)
  {
    var articles = new List<Article>();
    articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
    articles.Add(new Article("Artigo sobre C#", "charp"));
    articles.Add(new Article("Artigo sobre .NET", "dotnet"));

    foreach (var article in articles)
    {
      Console.WriteLine(article.Id);
      Console.WriteLine(article.Title);
      Console.WriteLine(article.Url);
    }

    var courses = new List<Course>();
    
    var courseOop = new Course("Fundamentos OOP", "fundamentos-oop");
    var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
    var courseAsp = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
    
    courses.Add(courseOop);
    courses.Add(courseCsharp);
    courses.Add(courseAsp);
    
    var careers = new List<Career>();
    var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
    var careerItemTwo = new CareerItem(2, "Aprenda OOP", "", courseOop);
    var careerItemOne = new CareerItem(1, "Comece por aqui", "", courseCsharp);
    var careerItemThree = new CareerItem(3, "Aprenda ASP.NET", "", courseAsp);
    careerDotnet.Items.Add(careerItemTwo);
    careerDotnet.Items.Add(careerItemOne);
    careerDotnet.Items.Add(careerItemThree);
    careers.Add(careerDotnet);

    foreach (var career in careers)
    {
      Console.WriteLine(career.Title);
      foreach (var item in career.Items.OrderBy(x => x.Order)) //ordenar
      {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course.Title);
        Console.WriteLine(item.Course.Level);

        foreach (var notification in item.Notifications)
        {
          Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
      }
    }

    var payPalSubscription = new PayPalSubscription();
    var student = new Student();
    student.CreateSubscription(payPalSubscription);
  }
}
