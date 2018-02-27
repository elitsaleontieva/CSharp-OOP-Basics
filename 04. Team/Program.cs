using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var team = new Team("Name");

            for (int i = 0; i < n; i++)
            {
                var input= Console.ReadLine();
                var parts = input.Split(' ');
                var firstName = parts[0];
                var secondName = parts[1];
                var age = int.Parse(parts[2]);
                var salary = decimal.Parse(parts[3]);

                Person person = new Person(firstName,secondName,age,salary);

                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");

        }
    }
}
