using DataFlow.Core;
using DataFlow.Demo;
using System;
using System.Threading;

var catalog = new List<Product>
{
    new Product { Id = 1, Name = "apple", Price = 100m },
    new Product { Id = 2, Name = "bread", Price = 50m },
    new Product { Id = 3, Name = "Сыр", Price = 450m }
};