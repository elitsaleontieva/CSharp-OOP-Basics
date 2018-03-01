    namespace AnimalFarm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var chars = ";"
                .ToCharArray();

                var nameAndMoneyInput = Console.ReadLine();
                var nameAndMoneyInputParts = nameAndMoneyInput
                    .Split(chars, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                var productAndCostInput = Console.ReadLine();
                var productAndCostInputParts = productAndCostInput
                    .Split(chars, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var listOfPerson = new List<Person>();
                var listOfProduct = new List<Product>();


                foreach (var nameAndMoney in nameAndMoneyInputParts)
                {
                    var parts = nameAndMoney.Split('=').ToArray();

                    var name = parts[0];
                    var money = decimal.Parse(parts[1]);

                    Person person = new Person(name, money, listOfProduct);
                    
                    listOfPerson.Add(person);
                    
                }

                foreach (var productAndCost in productAndCostInputParts)
                {
                    var parts = productAndCost.Split('=').ToArray();
                    var name = parts[0];
                    var cost = decimal.Parse(parts[1]);

                    Product product = new Product(name, cost);
                    
                    listOfProduct.Add(product);

                }
                

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var parts = command.Split(' ').ToArray();
                    var nameOfBuyer = parts[0];
                    var productToBeBought = parts[1];

                    foreach (var person in listOfPerson)
                    {
                        foreach (var product in listOfProduct)
                        {
                            if (nameOfBuyer == person.Name && productToBeBought == product.Name)
                            {
                                if (person.Money >= product.Cost)
                                {
                                    person.Money -= product.Cost;

                                    person.AddToBag(product.Name, product.Cost);

                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                                }
                            }
                        }
                    }
                    
                    command = Console.ReadLine();

                }

                foreach (var person in listOfPerson)
                {
                    var result = string.Empty;
                    result = $"{ Environment.NewLine} {person.Name} - ";

                    if (person.Bag.Count > 0)
                    {
                        foreach (var product in person.Bag)
                        {
                            result += $"{product.Name}, ";
                            
                        }
                        result = result.TrimStart().TrimEnd().TrimEnd(',');
                        Console.WriteLine(result);
                    }
                    else
                    {
                        result = result.TrimStart().TrimEnd().TrimEnd(',');
                        Console.WriteLine($"{result} Nothing bought");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}



