namespace PierreBakery
{
    class Pastry
    {
        public int CalculateCost(int quantity)
        {
            int dealQuantity = (quantity / 4) * 3;
            int remaining = quantity % 4;

            return dealQuantity * 2 + remaining * 2;
        }
    }
}