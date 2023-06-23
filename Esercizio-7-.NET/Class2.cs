public class Class2
{
    private int privateVariable;
    protected int protectedVariable;
    internal int internalVariable;
    public int publicVariable;

    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method called.");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal method called.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }
}
