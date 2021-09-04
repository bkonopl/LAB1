using System;
using KonLab5.Collections;
using KonLab5.Entities;

namespace KonLab5
{
    internal class Program
    {
        
        private static MyCustomCollection<Order> orderList = new MyCustomCollection<Order>();

        static void BuyTicket(Tariff ticket, Human person)
        {
            if (person.balance < ticket.price)
            {
                return;
            }

            person.balance -= ticket.price;
            person.orderHistory.Add(ticket);
            
            orderList.Add(new Order(ticket, person));
        }

        static void FilterByRoute(Route route)
        {
            Console.WriteLine(route.targetA + " - > " + route.targetB);
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].ticket.route.Equals(route))
                {
                    Console.WriteLine(orderList[i].passanger.ID);
                }
            }
        }
        
        public static void Main(string[] args)
        {
            MyCustomCollection<Route> routes = new MyCustomCollection<Route>();
            MyCustomCollection<Human> humans = new MyCustomCollection<Human>();
            MyCustomCollection<Tariff> tarrifs = new MyCustomCollection<Tariff>();
            humans.Add(new Human("HB123", 200));
            humans.Add(new Human("PP222", 300));
            for (int i = 0; i < humans.Count; i++)
            {
                Console.WriteLine(humans[i].ID + " - " + humans[i].balance);
            }
            
            routes.Add(new Route("Mazyr", "Minsk"));
            tarrifs.Add(new Tariff(routes[0], 15));
            routes.Add(new Route("Mazyr", "Gomel"));
            tarrifs.Add(new Tariff(routes[1], 6));
            routes.Add(new Route("Gomel", "Minsk"));
            tarrifs.Add(new Tariff(routes[2], 8));
            
            for (int i = 0; i < routes.Count; i++)
            {
                Console.WriteLine(routes[i].targetA + " - " + routes[i].targetB);
            }

            for (int i = 0; i < tarrifs.Count; i++)
            {
                Console.Write(tarrifs[i].route.targetA + " - " + tarrifs[i].route.targetB + " ");
                Console.WriteLine(tarrifs[i].price);
            }

            BuyTicket(tarrifs[0], humans[0]);

            for (int i = 0; i < orderList.Count; i++)
            {
                Route ticket = orderList[i].ticket.route;
                Console.WriteLine(ticket.targetA + " -> " + ticket.targetB + " : " + " " + orderList[i].passanger.ID);
            }
            
            FilterByRoute(routes[0]);
        }
    }
}