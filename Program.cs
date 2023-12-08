using System;
using System.Globalization;
using System.Collections.Generic;
using CSharp_Exercicio_Aula_132.Entities;
using CSharp_Exercicio_Aula_132.Entities.Enums;

namespace CSharp_Exercicio_Aula_132
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------Exercicio Aula 132*/

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            Order order;
            order = new Order();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, productPrice);
                Product productItem = new Product(productName, productPrice);
                order = new Order(DateTime.Now, status, productItem, client);
                order.AddOrderItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);


        }
    }
}
