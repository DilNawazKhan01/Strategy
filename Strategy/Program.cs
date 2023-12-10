using System;
using System.Collections.Generic;

// Interface for the flight behavior
public interface Flight
{
    void fly();
}

// Concrete class for flying with wings
public class FlyWithWings : Flight
{
    public void fly()
    {
        Console.WriteLine("*FLIES BY FLAPPING WINGS*");
    }
}

// Concrete class for not flying
public class NoFly : Flight
{
    public void fly()
    {
        Console.WriteLine("*CANNOT FLY*");
    }
}

// Concrete class for floating in water
public class FloatInWater : Flight
{
    public void fly()
    {
        Console.WriteLine("*FLOATS IN WATER*");
    }
}

// Concrete class for sliding by belly
public class SlideByBelly : Flight
{
    public void fly()
    {
        Console.WriteLine("*SLIDES BY BELLY*");
    }
}

// Parent class for all birds
public class Bird
{
    protected Flight movementBehavior;

    public Bird(Flight behavior)
    {
        this.movementBehavior = behavior;
    }

    public void performFly()
    {
        movementBehavior.fly();
    }
}

// Concrete bird class - Mallard Duck
public class MallardDuck : Bird
{
    public MallardDuck() : base(new FlyWithWings())
    {
    }
}

// Concrete bird class - Emperor Penguin
public class EmperorPenguin : Bird
{
    public EmperorPenguin() : base(new SlideByBelly())
    {
    }
}

// Concrete bird class - Bald Eagle
public class BaldEagle : Bird
{
    public BaldEagle() : base(new FlyWithWings())
    {
    }
}

// Concrete bird class - Ostrich
public class Ostrich : Bird
{
    public Ostrich() : base(new NoFly())
    {
    }
}

// Concrete bird class - Yellow Rubber Duck
public class YellowRubberDuck : Bird
{
    public YellowRubberDuck() : base(new FloatInWater())
    {
    }
}

class Program
{
    static void Main()
    {
        List<Bird> birds = new List<Bird>
        {
            new MallardDuck(),
            new EmperorPenguin(),
            new BaldEagle(),
            new Ostrich(),
            new YellowRubberDuck()
        };

        Console.WriteLine("Number of birds in the simulation: " + birds.Count);
        foreach (Bird bird in birds)
        {
            Console.Write("Here is the " + bird.GetType().Name + "'s movement behavior: ");
            bird.performFly();
        }
    }
}
