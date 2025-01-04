public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a non-existent property will not throw a compile-time error,
        // but will result in a runtime exception if not handled.
        int result = this.NonExistentProperty; // Runtime exception: 'System.NullReferenceException'
    }
}