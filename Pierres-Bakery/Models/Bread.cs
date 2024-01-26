namespace PierreBakery
{
    public class Bread
    {
        public int Quantity { get; set; }

        public Bread(int quantity)
        {
            Quantity = quantity;
        }

        public int CalculateCost()
        {
            int dealQuantity = (Quantity / 3) * 2;
            int remaining = Quantity % 3;

            return dealQuantity * 5 + remaining * 5;
        }
    }
}