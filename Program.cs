//Task 1

//using System;

//class Program
//{
// static void Main()
//{
// Declare and initialize variables
// string userName = "Ankita Pokhrel";
//int luckyNumber = 5;

// Print using string interpolation
//Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
//}
//}





//Task 2 

//using System;

//class Circle
//{
// Declare a constant
//public const double PI = 3.14;

// Method to calculate area
//public static double CalculateArea(double radius)
//{
// return PI * radius * radius;
//}

// Method to calculate perimeter
//public static double CalculatePerimeter(double radius)
//{
//return 2 * PI * radius;
//}
//}

//class Program
//{
//static void Main()
//{
// Trying to modify the constant value (this will cause a compilation error)
// Circle.PI = 3.14159;   // ❌ ERROR: The left-hand side of an assignment must be a variable, property or indexer

// Correct usage
//double radius = 5.0;
//double area = Circle.CalculateArea(radius);
//double perimeter = Circle.CalculatePerimeter(radius);

//Console.WriteLine($"For a circle with radius {radius}:");
//Console.WriteLine($"Area = {area}");
//Console.WriteLine($"Perimeter = {perimeter}");
//}
//}



//Task3

//using System;

//class Program
//{
//static void Main()
//{
// Declare and initialize variables of various types
//byte byteVar = 10;
//short shortVar = 2000;
//int intVar = 50000;
//long longVar = 100000000L;
//float floatVar = 3.14f;
//double doubleVar = 6.283;
//decimal decimalVar = 123.456m;
//char charVar = 'A';
//bool boolVar = true;

// Type conversions
//string intToString = intVar.ToString();   // Convert int to string
//string stringNumber = "3.14";
//double stringToDouble = Convert.ToDouble(stringNumber);  // Convert string to double

// Print all variables with labels
//Console.WriteLine("=== Data Types and Type Conversion ===");
//Console.WriteLine($"byteVar (byte): {byteVar}");
//Console.WriteLine($"shortVar (short): {shortVar}");
//Console.WriteLine($"intVar (int): {intVar}");
//Console.WriteLine($"longVar (long): {longVar}");
//Console.WriteLine($"floatVar (float): {floatVar}");
//Console.WriteLine($"doubleVar (double): {doubleVar}");
//Console.WriteLine($"decimalVar (decimal): {decimalVar}");
//Console.WriteLine($"charVar (char): {charVar}");
//Console.WriteLine($"boolVar (bool): {boolVar}");
//Console.WriteLine();
//Console.WriteLine($"intToString (string): \"{intToString}\"");
//Console.WriteLine($"stringToDouble (double): {stringToDouble}");
//}
//}



//Task 4
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Create a single-dimensional integer array with 5 favorite numbers
//        int[] favoriteNumbers = { 7, 3, 42, 15, 9 };

//        Console.WriteLine("Original array:");
//        foreach (int num in favoriteNumbers)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();

//        // Sort the array in ascending order
//        Array.Sort(favoriteNumbers);
//        Console.WriteLine("\nArray after sorting:");
//        foreach (int num in favoriteNumbers)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();

//        // Reverse the sorted array
//        Array.Reverse(favoriteNumbers);
//        Console.WriteLine("\nArray after reversing:");
//        foreach (int num in favoriteNumbers)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();

//        // Use a for loop to print each element
//        Console.WriteLine("\nPrinting elements using a for loop:");
//        for (int i = 0; i < favoriteNumbers.Length; i++)
//        {
//            Console.WriteLine($"Element at index {i}: {favoriteNumbers[i]}");
//        }

//        // Find the position of a specific number (e.g., 15)
//        int searchNumber = 15;
//        int index = Array.IndexOf(favoriteNumbers, searchNumber);
//        if (index != -1)
//            Console.WriteLine($"\nThe number {searchNumber} is at index {index} in the array.");
//        else
//            Console.WriteLine($"\nThe number {searchNumber} is not found in the array.");
//    }
//}

//Task 5
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Create a DateTime variable for birthdate
//        DateTime birthDate = new DateTime(2002, 3, 3);  // Example: 3rd March 2002

//        // Create a DateTime variable for the current date and time
//        DateTime currentDate = DateTime.Now;

//        // Calculate age using TimeSpan
//        TimeSpan ageSpan = currentDate - birthDate;
//        int ageInYears = (int)(ageSpan.TotalDays / 365.25); // Approximate age in years

//        // Print birthdate, current date, and age
//        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
//        Console.WriteLine($"Age: {ageInYears} years");

//        // Add 10 days to birthdate
//        DateTime birthDatePlus10 = birthDate.AddDays(10);
//        Console.WriteLine($"Birthdate + 10 days: {birthDatePlus10.ToShortDateString()}");
//    }
//}


//Task 6
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a List<string> with 3 favorite fruits
//        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

//        // Add a new fruit
//        fruits.Add("Orange");

//        // Remove one fruit
//        fruits.Remove("Mango");

//        // Print all fruits using foreach
//        Console.WriteLine("Fruits in the list:");
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }

//        Console.WriteLine();

//        // Create a Dictionary<int, string> with fruit IDs
//        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
//        {
//            { 1, "Apple" },
//            { 2, "Mango" },
//            { 3, "Banana" }
//        };

//        // Add a new entry
//        fruitDictionary.Add(4, "Orange");

//        // Print all key-value pairs
//        Console.WriteLine("Fruit Dictionary:");
//        foreach (KeyValuePair<int, string> kvp in fruitDictionary)
//        {
//            Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");
//        }
//    }
//}








