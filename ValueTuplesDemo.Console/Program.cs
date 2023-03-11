internal class Program
{
    private static void Main(string[] args)
    {
        // Create a simple value tuple
        (int, string, string, decimal) tuple = SimpleValueTuple();

        // Deconstructing a tuple
        DeconstructTuple(tuple);

        // Create a tuple with named elements
        NamedElementsTuple();

        // Get a tuple with named elements from a function
        var phone = GetPhones();

        // Write phone to the console
        Console.WriteLine($"Quantity: {phone.Qty} Model: {phone.Model} OS: {phone.OS} Price: {phone.Price:c}");
    }

    /// <summary>
    /// Creating a simple value tuple
    /// </summary>
    /// <returns>A simple value tuple</returns>
    private static (int, string, string, decimal) SimpleValueTuple()
    {
        // Create a new tuple
        var tuple = (10, "Pixel 5a 5G", "Android", 499.99M);

        // Write the tuple to the console
        Console.WriteLine(tuple);
        return tuple;
    }

    /// <summary>
    /// Creating a tuple with named elements
    /// </summary>
    private static void NamedElementsTuple()
    {
        // Tuple with named elements
        var phone = (Qty: 5, Model: "iPhone 14", OS: "iOS", Price: 799.99M);

        // Write named elements to the console
        Console.WriteLine($"Quantity: {phone.Qty} Model: {phone.Model} OS: {phone.OS} Price: {phone.Price:c}");
    }

    /// <summary>
    /// Deconstructing a tuple
    /// </summary>
    /// <param name="tuple">The tuple to be dexonstructed</param>
    private static void DeconstructTuple((int, string, string, decimal) tuple)
    {
        // Deconstructing a tuple
        var (qty, model, os, price) = tuple;

        // Write deconstructed tuple to the console
        Console.WriteLine($"Quantity: {qty} Model: {model} OS: {os} Price: {price:c}");
    }

    /// <summary>
    /// Function that returns a value tuple with named elements
    /// </summary>
    /// <returns>A value tuple representation of a phone</returns>
    private static (int Qty, string Model, string OS, decimal Price) GetPhones()
    {
        int qty = 12;
        string model = "Moto G Power";
        string os = "Android";
        decimal price = 149.99M;
        return (qty, model, os, price);
    }
}