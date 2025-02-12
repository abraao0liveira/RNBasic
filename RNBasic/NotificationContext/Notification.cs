namespace RNBasic.NotificationContext;

public sealed class Notification //a classe não pode ser estendida, não pode ser herdada
{
  public Notification() //vazio para instanciar sem nada
  {
  }
  public Notification(string property, string message) //com os dados da notificação
  {
    Property = property;
    Message = message;
  }
  public string Property { get; set; } = string.Empty;
  public string Message { get; set; } = string.Empty;
}