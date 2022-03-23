namespace Bai10
{
    internal class Product
    {
        string Description { get; set; }
        string ProductID { get; set; }
        double Price { get; set; }

        public Product()
        {
        }
        public Product(string description,string productID,double price)
        {
            Description = description;
            ProductID = productID;
            Price = price;
        }

    }
}