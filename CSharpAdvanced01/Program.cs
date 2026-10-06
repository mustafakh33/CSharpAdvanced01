namespace CSharpAdvanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // Q1: What is a generic class? Why use generics?
            // Answer: A generic class is a class that can operate with different data types without the need to create multiple versions of the same class. Generics allow for type safety, code reusability, and performance improvements by enabling developers to define classes, methods, and data structures that can work with any data type specified at runtime.
            #endregion

            #region Question02
            // Q2: Write a generic class Container<T> with Add and Get methods.
            Container<int> intContainer = new Container<int>();

            intContainer.Add(100);

            int number = intContainer.Get();

            Console.WriteLine(number);
            #endregion

            #region Question03
            // Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            Pair<int, string> student = new Pair<int, string>(101, "Mustafa");

            Console.WriteLine($"Key: {student.Key}");
            Console.WriteLine($"Value: {student.Value}");
            #endregion
        }
    }
}
