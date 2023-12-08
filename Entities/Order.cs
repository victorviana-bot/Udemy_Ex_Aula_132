using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using CSharp_Exercicio_Aula_132.Entities.Enums;

namespace CSharp_Exercicio_Aula_132.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Product Product { get; set; }
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Product product, Client client)
        {
            Moment = moment;
            Status = status;
            Product = product;
            Client = client;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItem.Remove(orderItem);
        }

        public double Total()
        {
            double tot = 0.0;
            foreach (OrderItem orderItem in OrderItem)
            {
                tot += orderItem.SubTotal();
            }
            return tot;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append($" ({Client.BirthDate.ToString("dd/MM/yyyy")}) - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order itens: ");
            foreach (OrderItem o in OrderItem)
            {
                sb.Append(Product.Name);
                sb.Append(", $");
                sb.Append(o.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(o.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(o.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total price: $ ");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }



    }
}
