using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {


        var command = Console.ReadLine();

        var companyList = new List<Company>();
        var pokemonList = new List<Pokemon>();
        var parentsList = new List<Parents>();
        var childrenList = new List<Children>();
        var carList = new List<Car>();

        while (command!="End")
        {
             var parts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            Company company = new Company();
            Pokemon pokemon = new Pokemon();
            Parents parents = new Parents();
            Children children = new Children();
            Car car = new Car();


            switch (parts[1])
            {

                case "company":
                    var name1 = parts[0];
                    var companyName = parts[2];
                    var department = parts[3];
                    var salary = parts[4];

                    company.ComapnyName = companyName;
                    company.Name = name1;
                    company.Department = department;
                    company.Salary = decimal.Parse(salary);

                    companyList.Add(company);

                    break;

                case "pokemon":
                    var namePokemon = parts[0];
                    var pokemonName = parts[2];
                    var pokemonType = parts[3];

                    pokemon.Name = namePokemon;
                    pokemon.PokemonName = pokemonName;
                    pokemon.PokemonType = pokemonType;

                    pokemonList.Add(pokemon);

                    break;

                case "parents":
                    var nameParents = parts[0];
                    var parentName = parts[2];
                    var parentBirthday = parts[3];

                    parents.Name = nameParents;
                    parents.parentName = parentName;
                    parents.parentBirthday = parentBirthday;

                    parentsList.Add(parents);

                    break;

                case "children":
                    var nameChildren = parts[0];
                    var childName = parts[2];
                    var childBirthday = parts[3];

                    children.Name = nameChildren;
                    children.childName = childName;
                    children.childBirthday = childBirthday;

                    childrenList.Add(children);

                    break;

                case "car":
                    var nameCar = parts[0];
                    var carModel = parts[2];
                    var carSpeed = parts[3];

                    car.Name = nameCar;
                    car.CarModel = carModel;
                    car.CarSpeed = int.Parse(carSpeed);

                    carList.Add(car);
                    break;
            }


            command = Console.ReadLine();
        }

        var name = Console.ReadLine();

        Console.WriteLine(name);
        Console.WriteLine($"Company:");
        foreach (var company in companyList.Where(x=>x.Name==name))
        {
            Console.WriteLine($"{company.ComapnyName} {company.Department} {company.Salary:f2}");
            

        }

        Console.WriteLine($"Car:");
        foreach (var car in carList.Where(x => x.Name == name))
        {
            Console.WriteLine($"{car.CarModel} {car.CarSpeed}");
        }

        Console.WriteLine($"Pokemon:");
        foreach (var pokemon in pokemonList.Where(x => x.Name == name))
        {
            Console.WriteLine($"{pokemon.PokemonName} {pokemon.PokemonType}");
            

        }

        Console.WriteLine($"Parents:");
        foreach (var parent in parentsList.Where(x => x.Name == name))
        {
            Console.WriteLine($"{parent.parentName} {parent.parentBirthday}");
           

        }
        Console.WriteLine($"Children:");
        foreach (var children in childrenList.Where(x => x.Name == name))
        {
            Console.WriteLine($"{children.childName} {children.childBirthday}");
        }
      
      
        
    }
}
