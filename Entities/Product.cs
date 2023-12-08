﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Exercicio_Aula_132.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}

