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

            #region Question06
            // Q6: What is a generic interface? Write IRepository<T>. 
            /*
             * A generic interface is an interface that uses a type parameter
             * so it can work with different data types.

             * IRepository<T> can be used with different types such as:
             * IRepository<Product>
             * IRepository<Employee>
             * IRepository<Student>
             */

            #endregion

            #region Question07
            // Q7: What is the 'struct' constraint? Write an example.
            // The 'struct' constraint specifies that T must be a value type.
            static void PrintValue<T>(T value) where T : struct
            {
                Console.WriteLine($"Value: {value}");
            }

            PrintValue(100);
            PrintValue(3.14);
            PrintValue('A');

            #endregion

            #region Question08
            // Q8: What is the 'class' constraint? Write an example.
            // The 'class' constraint specifies that T must be a reference type.
            static void PrintReference<T>(T value) where T : class
            {
                Console.WriteLine($"Value: {value}");
            }

            PrintReference("Hello");
            PrintReference(new object());

            #endregion

            #region Question09
            // Q9: What is the 'new()' constraint? Write an example.
            // The 'new()' constraint specifies that T must have a parameterless constructor.

            var factory = new Factory<Student>();

            Student s = factory.CreateInstance();
            Console.WriteLine(s);

            #endregion

            #region Question10
            // Q10:  What is the interface constraint? Write an example.
            // The interface constraint specifies that T must implement a specific interface.
            static void PrintName<T>(T item) where T : IPrintable
            {
                item.Print();
            }

            Employee employee = new Employee();

            PrintName(employee);

            #endregion

            #region Question11
            // Q11: What is the base class constraint? Write an example.
            // The base class constraint specifies that T must inherit from a specific base class.
            static void PrintInfo<T>(T item) where T : Product
            {
                Console.WriteLine($"Name: {item.Name}");
            }
            ElectronicProduct laptop = new ElectronicProduct
            {
                Name = "Dell Laptop"
            };

            PrintInfo(laptop);

            #endregion

            #region Question12
            // Q12: How do you apply multiple constraints? Write an example
           /* Multiple constraints can be applied to the same generic type
              using multiple constraints in the where clause.
           */
           void DisplayInfo<T>(T item) where T : Product, IPrintable
            {
                Console.WriteLine($"Name: {item.Name}");
                item.Print();
            }
            ElectronicProduct Smartphone = new ElectronicProduct
            {
                Name = "Smartphone"
            };

            DisplayInfo<ElectronicProduct>(Smartphone);
            #endregion

            #region Question13
            // Q13: What does the 'default' keyword do in generics?
            /*
              The 'default' keyword returns the default value of the generic type T.
              For value types:
                     int    -> 0
                     double -> 0
                     bool   -> false

             For reference types:
                     string -> null
                     object -> null
             */
            #endregion
        }
    }
}
