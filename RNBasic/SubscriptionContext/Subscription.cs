using RNBasic.SharedContext;

namespace RNBasic.SubscriptionContext;

public class Subscription : BaseContent
{
  public Plan Plan { get; set; }
  public DateTime? EndDate { get; set; }
  public bool IsInactive => EndDate <= DateTime.Now; //estará inativo se o EndDate for menor que a Data Atual
}