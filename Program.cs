using System;

class Parent
{
    protected double Pole1;

    public Parent(double pole1)
    {
        Pole1 = pole1;
    }

    public void Print()
    {
        Console.WriteLine($"Pole1: {Pole1} м");
    }

    public double Metod()
    {
        return Pole1 * 0.03;
    }
}

class Child1 : Parent
{
    private int Pole2;

    public Child1(double pole1, int pole2) : base(pole1)
    {
        Pole2 = pole2;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Pole2: {Pole2} поверхів");
    }

    public new double Metod()
    {
        double baseMetodResult = base.Metod();
        if (Pole2 > 10)
        {
            return baseMetodResult + 0.005 * Pole2;
        }
        return baseMetodResult;
    }
}

class Child2 : Parent
{
    private double Pole3;

    public Child2(double pole1, double pole3) : base(pole1)
    {
        Pole3 = pole3;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Pole3: {Pole3} тонн");
    }

    public new double Metod()
    {
        return base.Metod() + 0.000002 * Pole3;
    }
}

class Program
{
    static void Main()
    {
        Parent parent = new Parent(5.0);
        Child1 child1 = new Child1(10.0, 12);
        Child2 child2 = new Child2(8.0, 100);

        Console.WriteLine("Parent:");
        parent.Print();
        Console.WriteLine($"Metod result: {parent.Metod()} м");

        Console.WriteLine("\nChild1:");
        child1.Print();
        Console.WriteLine($"Metod result: {child1.Metod()} м");

        Console.WriteLine("\nChild2:");
        child2.Print();
        Console.WriteLine($"Metod result: {child2.Metod()} м");
    }
}
