public static void InsertAndRemove(Repository<TestClass> testObjects)
{
    // Create some test objects
    TestClass obj1 = new TestClass(1, "Alice");
    TestClass obj2 = new TestClass(2, "Bob");
    TestClass obj3 = new TestClass(3, "Charlie");

    // Insert them into the repository
    testObjects.Insert(obj1);
    testObjects.Insert(obj2);
    testObjects.Insert(obj3);

    // Print the contents of the repository
    Console.WriteLine("The repository contains:");
    foreach (var obj in testObjects.GetAll())
    {
        Console.WriteLine(obj);
    }

    // Remove some test objects from the repository
    testObjects.Remove(obj1);
    testObjects.Remove(obj3);

    // Print the contents of the repository again
    Console.WriteLine("The repository now contains:");
    foreach (var obj in testObjects.GetAll())
    {
        Console.WriteLine(obj);
    }
}
