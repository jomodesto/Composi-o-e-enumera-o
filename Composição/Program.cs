using System;
using Composição.Entities;
using Composição.Entities.Enums;

namespace Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(order);

        }
    }
}
