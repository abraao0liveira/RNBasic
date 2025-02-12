using RNBasic.NotificationContext;

namespace RNBasic.SharedContext;

public abstract class BaseContent : Notifiable
{
  public BaseContent()
  {
    Id = Guid.NewGuid(); //cria um hash automatico
  }
  public Guid Id { get; set; }
}