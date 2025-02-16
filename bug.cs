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
        // The below line will throw a NullReferenceException if nullableInstance is null
        Console.WriteLine(nullableInstance.MyProperty); // NullReferenceException
    }
}