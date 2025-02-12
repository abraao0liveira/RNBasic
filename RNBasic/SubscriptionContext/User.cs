using RNBasic.SharedContext;

namespace RNBasic.SubscriptionContext;

public class User : BaseContent
{
  public string UserName { get; set; }
  public string Password { get; set; }
}