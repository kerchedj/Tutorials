using System.Reflection;
Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp == null) return;

//Loop through the assemblies that my app references
foreach(AssemblyName name in myApp.GetReferencedAssemblies())
{
    //Load the assembly so we can read its details
    Assembly a = Assembly.Load(name);

    // Declare a variable to count the number of methods
    int methodCount = 0;

    foreach(TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of methods
        methodCount += t.GetMethods().Count();
    }

    // Output the count of types and their methods.
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", 
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}


// Outputs the current line terminator string.
// By default, this is a carriage return and line feed.
Console.WriteLine();

// Outputs the greeting and the current line terminator string.
Console.WriteLine("Hello Ahmed.");

// Outputs the formatted number and date and the current line terminator string.
Console.WriteLine("Temperature on {0:D} is {1} degrees C", DateTime.Today, 23.4);

