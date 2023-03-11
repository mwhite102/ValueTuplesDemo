# Value Tuples in C#

Value tuples were introduced in C# 7 to simplify creating tuples.  It is a data structure representing an ordered sequence of values.

Unlike regular tuples, value tuples are implemented as structs rather than classes, which means they are value types rather than reference types.

Tuples can be created by enclosing a comma-separated list of values enclosed in parentheses:

```csharp
var tuple = (10, "Pixel 5a 5G", "Android", 499.99M);
```

A tuple can be deconstructed using the following syntax:

```csharp
// Deconstructing a tuple
var (qty, model, os, price) = tuple;

// Write deconstructed tuple to the console
Console.WriteLine($"Quantity: {qty} Model: {model} OS: {os} Price: {price:c}");
```

Value tuples also support named elements:

```csharp
// Tuple with named elements
var phone = (Qty: 5, Model: "iPhone 14", OS: "iOS", Price: 799.99M);

// Write named elements to the console
Console.WriteLine($"Quantity: {phone.Qty} Model: {phone.Model} OS: {phone.OS} Price: {phone.Price:c}");
```

Returning a tuple with named elements from a function

```csharp
/// <summary>
/// Function that returns a value tuple with named elements
/// </summary>
/// <returns>A value tuple representation of a phone</returns>
private static (int Qty,string Model, string OS, decimal Price) GetPhones()
{
    int qty = 12;
    string model = "Moto G Power";
    string os = "Android";
    decimal price = 149.99M;
    return (qty, model, os, price);
}
```

Value tuples are a useful feature in C# that make it easy to work with ordered sequences of values in a concise and efficient way.