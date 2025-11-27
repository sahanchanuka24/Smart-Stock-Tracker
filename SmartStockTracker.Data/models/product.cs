namespace SmartStockTracker.Data.Models
{
    public class Product
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public int CurrentStock { get; set; }
        public int LowStockThreshold { get; set; }
        // Navigation property for transactions
        public ICollection<Transaction> Transactions { get; set; }
    }
}