using System.Runtime.Versioning;

namespace KonLab5.Entities
{
    public struct Tariff
    {
        public Route route;
        public int price;

        public Tariff(Route way, int value)
        {
            route = way;
            price = value;
        }
    }
}