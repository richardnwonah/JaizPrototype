namespace JaizPrototype.Models;

public class Merchant
{
    public int MerchantId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int TerminalId { get; set; }
    //public List<Transaction> Transactions { get; set; }
}
