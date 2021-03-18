namespace CheckoutKata.Models
{
    class Deal
    {
        public int Number { get; set; }
        public int Cost{ get; set; }

        public Deal(int number, int cost)
        {
            Number = number;
            Cost = cost;
        }
    }
}
