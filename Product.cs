namespace ProductLibrary
{
    public class Product
    {
        public double Price { get; set; }

        public Product(double price)
        {
            Price = price;
        }

        public double ApplyDiscount(double discountPercentage)
        {
            //Placeholder
            if (discountPercentage < 0)
            {
                discountPercentage = 0;
            }
            return Price - (Price * ( discountPercentage / 100));
        }
    }
}
