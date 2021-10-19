﻿using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess:IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Pearl Jam Ten", Price = 12.99m },
            new Product() { Name = "Megaman X Collection", Price = 59.99m },
            new Product() { Name = "Keyboard", Price = 120.99m },
            new Product() { Name = "Monitor", Price = 159.99m },
            new Product() { Name = "Mouse", Price = 65.99m },
            new Product() { Name = "Desk", Price = 250.99m },
            new Product() { Name = "Power Supply", Price = 120.99m }
        };
        public MongoDataAccess()
        {
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from {GetType().Name} to the console");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from {GetType().Name} ");
            return Products;
        }
    }
}
