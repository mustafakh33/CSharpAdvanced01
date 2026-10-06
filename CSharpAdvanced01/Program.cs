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

            #region Question04
            // Q4: What is a generic method? Write Swap<T> method.

            static void Swap<T>(ref T first, ref T second)
            {
                T temp = first;
                first = second;
                second = temp;
            }

            int x = 10;
            int y = 20;

            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            string firstName = "Mustafa";
            string secondName = "Khaled";

            Console.WriteLine($"Before Swap: {firstName}, {secondName}");

            Swap(ref firstName, ref secondName);

            Console.WriteLine($"After Swap: {firstName}, {secondName}");

            #endregion

            #region Question05
            // Q5: Write a generic method FindMax<T> that finds maximum value

            static T FindMax<T>(T first, T second) where T : IComparable<T>
            {
                return first.CompareTo(second) > 0 ? first : second;
            }

            int maxNumber = FindMax(10, 20);
            Console.WriteLine($"Max Number: {maxNumber}");

            #endregion
        }
    }
}
