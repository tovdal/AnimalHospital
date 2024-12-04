namespace AnimalHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var animals = new List<Animal>
            {
                new Animal {Name = "Conny", Type = "Dog", Legs = 4, Age = 3, IsVaccinated = true},
                new Animal {Name = "Fido", Type = "Dog", Legs = 4, Age = 5, IsVaccinated = true},
                new Animal {Name = "Biffen", Type = "Dog", Legs = 3, Age = 8, IsVaccinated = true},
                new Animal {Name = "Shadow", Type = "Cat", Legs = 4, Age = 2, IsVaccinated = true},
                new Animal {Name = "Misse", Type = "Cat", Legs = 4, Age = 9, IsVaccinated = false},
                new Animal {Name = "Ysera", Type = "Cat", Legs = 4, Age = 6, IsVaccinated = true},
                new Animal {Name = "Floppy", Type = "Bunny Rabbit", Legs = 4, Age = 1, IsVaccinated = false},
                new Animal {Name = "Tiny", Type = "Bunny Rabbit", Legs = 4, Age = 1, IsVaccinated = true},
                new Animal {Name = "Spike", Type = "Lizard", Legs = 4, Age = 4, IsVaccinated = false},
                new Animal {Name = "Spirit", Type = "Horse", Legs = 4, Age = 14, IsVaccinated = true},
                new Animal {Name = "Burb", Type = "Parrot", Legs = 2, Age = 35, IsVaccinated = false}
            };

            // a
            int numberOfDogs = animals.Count(dogs => dogs.Type == "Dog");
            Console.WriteLine($"Amount of dogs: {numberOfDogs}");


        }
    }
}
