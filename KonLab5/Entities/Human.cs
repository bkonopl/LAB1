using KonLab5.Collections;

namespace KonLab5.Entities
{
    public struct Human
    {
        public string ID;
        public int balance;
        public MyCustomCollection<Tariff> orderHistory ;
        
        public Human(string id, int value)
        {
            ID = id;
            balance = value;
            orderHistory = new MyCustomCollection<Tariff>();
        }
    }
}