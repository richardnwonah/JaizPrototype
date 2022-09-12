using JaizPrototype.Models;

namespace JaizPrototype.ViewModels
{
    public class JaizSlipViewModel
    {
      public Transaction Transaction { get; set; }
      public Purchase Purchase { get; set; }
      public Merchant Merchant { get; set; }
      public Card Card { get; set; }
    }
}