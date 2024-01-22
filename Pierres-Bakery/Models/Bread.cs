namespace PierreBakery
{
    public class Bread
    {
        public int CalculateCost(int quantity)
        {
            int dealQuantity = (quantity / 3) * 2;
            int remaining = quantity % 3;

            return dealQuantity * 5 + remaining * 5;
        }
    }
}