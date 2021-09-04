namespace KonLab5.Entities
{
    public struct Order
    {
        public Tariff ticket;
        public Human passanger;

        public Order(Tariff pass, Human person)
        {
            ticket = pass;
            passanger = person;
        }
    }
}