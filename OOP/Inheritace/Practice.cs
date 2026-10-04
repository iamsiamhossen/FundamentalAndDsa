class Animal
{
    public string Name{ get; set; }
    public int Age{ get; set; }
    public string Email{ get; set; }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("I am Argentina Fan");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Name = "Tommy";
        dog.Age = 5;
        dog.Email = "barking@gmail.com";
        Console.WriteLine("Name: " + dog.Name);
        Console.WriteLine("Age: " + dog.Age);
        Console.WriteLine("Email: " + dog.Email);

        dog.Eat();
        dog.Bark();
    }
}