using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a database to use from the options(List,SQL,Mongo)");
            string database = Console.ReadLine();
            IDataAccess data = DataAccessFactory.GetDataAccessType(database);
            List<Product> products = data.LoadData();
            data.SaveData();
            Console.WriteLine("Products\n--------------\n");
     
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Product Name: {products[i].Name} | " +
                    $"Product Price: {products[i].Price}");
            }
        }
    }
}

