namespace JaizPrototype.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string Status { get; set; }
        public int ResponseCode { get; set; }
        public string AID { get; set; }
        public string RRN { get; set; }
        //public Card Card{ get; set; }
       // public List<Purchase> Purchase { get; set; }
        //public Merchant Merchant { get; set; }
    }
}