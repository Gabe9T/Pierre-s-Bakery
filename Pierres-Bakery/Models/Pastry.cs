namespace PierreBakery
{
    public class Pastry
    {
        public int Quantity { get; set; }

        public Pastry(int quantity)
        {
            Quantity = quantity;
        }

        public int CalculateCost()
        {
            int dealQuantity = (Quantity / 4) * 3;
            int remaining = Quantity % 4;

            return dealQuantity * 2 + remaining * 2;
        }
    }
}