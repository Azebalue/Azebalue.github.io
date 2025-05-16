IAnimal dog = new Dog();
IFlyable bird = new Bird();
IRunable cat = new Cat();

dog.printInformation();

bird.Fly();
cat.Run();

Console.ReadLine();

public interface IAnimal
{
    string Name { get; set; }

    void MakeSound();

    //디폴트 구현
    void printInformation()
    {
        Console.WriteLine($"안녕, 나는 {Name}야");
    }
}

public interface IFlyable
{
    void Fly();
}

public interface IRunable
{
    void Run();

}

class Bird : IAnimal, IFlyable
{
    public string Name { get; set; } = "앵돌이";
    public void MakeSound()
    {
        Console.Write("짹짹");
    }

    public void Fly()
    {
        Console.Write("새가 난다");
    }



}

class Dog : IAnimal, IRunable
{
    public string Name { get; set; } = "진돌이";
    public void MakeSound()
    {
        Console.Write("멍멍");
    }

    void IRunable.Run()
    {
        Console.Write("강아지가 달림");

    }
}



class Cat : IAnimal, IRunable
{
    public string Name { get; set; } = "나비";


    public void MakeSound()
    {
        Console.Write("야옹");

    }

    void IRunable.Run()
    {
        Console.Write("고양이가 달림");

    }
}