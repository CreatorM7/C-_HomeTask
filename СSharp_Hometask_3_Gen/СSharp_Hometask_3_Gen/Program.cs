using System;

public interface IStartable
{
    void Start();
}

public interface IClouseble
{
    void Close();
}
public class Factory<T> where T : class, new()
{
    public T Create()
    {
        return new T();
    }
}
public class Util : IStartable, IClouseble
{
    public void Start()
    {
        Console.WriteLine("Factory Begen work");
    }

    public void Close()
    {
        Console.WriteLine("Factory stop proces");
    }
}
public static class ExtensionMethods
{
    public static void DaylyProces<T>(this T item) where T : class, IStartable, IClouseble
    {
        item.Start();
        item.Close();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Factory<Util> factory = new Factory<Util>();
        Util workDay = factory.Create();
        workDay.DaylyProces();
    }
}
