using System;

public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        // This will throw a NullReferenceException if ExampleClass is null
        var instance = new ExampleClass(5);
        Console.WriteLine(instance.MyProperty); 

        ExampleClass? nullableInstance = null;
        // The null-conditional operator safely handles the potential null value
        Console.WriteLine(nullableInstance?.MyProperty); // Output: (null)

        // Alternative using null coalescing operator
        int? myProperty = nullableInstance?.MyProperty ?? 0;
        Console.WriteLine(myProperty); // Output: 0
    }
}