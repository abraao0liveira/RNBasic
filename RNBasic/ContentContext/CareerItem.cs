using RNBasic.NotificationContext;
using RNBasic.SharedContext;

namespace RNBasic.ContentContext;

public class CareerItem : BaseContent
{
  public CareerItem(int order, string title, string description, Course? course)
  {
    if (course == null)
    {
      AddNotification(new Notification("Course", "Curso inválido"));
    }
    
    Order = order;
    Title = title;
    Description = description;
    Course = course ?? throw new Exception("O curso não pode ser nulo"); //?? = null, cai dentro da exception
  }
  public int Order { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }
  public Course Course { get; set; }
}