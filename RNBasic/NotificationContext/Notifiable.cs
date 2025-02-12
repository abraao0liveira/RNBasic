namespace RNBasic.NotificationContext;

public abstract class Notifiable //não pode ser instanciada
{
  public List<Notification> Notifications { get; set; }

  public Notifiable()
  {
    Notifications = new List<Notification>();
  }

  public void AddNotification(Notification notification) //método de notificação
  {
    Notifications.Add(notification);
  }
  
  public void AddNotifications(IEnumerable<Notification> notifications) //método de notificação
  {
    Notifications.AddRange(notifications);
  }

  public bool IsInvalid => Notifications.Any(); //retorna somente o get, e se conter um objeto ou não, Any() vai retornar um bool
} 