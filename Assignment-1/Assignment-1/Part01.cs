// Q1: Explain with code example how class and struct behave differently
// difference between a class and a struct in C# is how they are stored in memory and copied:
// Class(Reference Type): Stored on the heap. When you copy a class variable, you copy the reference to the same object. Changing one affects the other.
// Struct (Value Type): Stored on the stack. When you copy a struct variable, you get a completely independent copy of the data. Changing one does not affect the other.

//namespace Question01
//{
//    // A Class (Reference Type)
//    public class PersonClass
//    {
//        public string Name { get; set; }
//    }

//    // A Struct (Value Type)
//    public struct PersonStruct
//    {
//        public string Name { get; set; }
//    }

//    class Program
//    {
//        // comment that to make the program.cs only entry point to solve assignment-1 part02
//    //    static void Main(string[] args)
//    //    {
//    //        PersonClass class1 = new PersonClass { Name = "MonMon" };
//    //        PersonClass class2 = class1;
//    //        class2.Name = "MINAAA";

//    //        Console.WriteLine($"Class1 Name: {class1.Name}"); // Output: MINAAA (Changed!)
//    //        Console.WriteLine($"Class2 Name: {class2.Name}"); // Output: MINAAA

//    //        // --- STRUCT BEHAVIOR ---
//    //        PersonStruct struct1 = new PersonStruct { Name = "Mina" };
//    //        PersonStruct struct2 = struct1;
//    //        struct2.Name = "Maged";

//    //        Console.WriteLine($"Struct1 Name: {struct1.Name}"); // Output: Mina (Unchanged)
//    //        Console.WriteLine($"Struct2 Name: {struct2.Name}"); // Output: Maged
//    //    }
//    //}
//}

//Q2: Explain the difference between public and private access modifiers with an example
//Access modifiers control the visibility and accessibility of class members(methods, properties, fields) from other parts of your code.
//public: The member is accessible from anywhere—inside the class, outside the class, and from other projects.
//private: The member is accessible only within the class where it is defined.It is hidden from the outside world (this is the core concept of encapsulation).

//namespace Question02
//{
//    public class BankAccount
//    {
//        private double balance = 1000.00;
//        public void DisplayBalance()
//        {
//            // Internal methods can access private fields
//            Console.WriteLine($"Current Balance: ${balance}");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount();

//            // This method is public
//            account.DisplayBalance();

//            // ERROR: This line will cause a compile-time error because 'balance' is private
//            // account.balance = 5000000.00; 
//        }
//    }
//}


//Q3: Describe the steps to create and use a class library in Visual Studio
//A Class Library packages your code so it can be reused across multiple projects.

//how to create and use one in Visual Studio:

//Step 1: Create the Class Library Project
//Open Visual Studio and select Create a new project.
//Search for Class Library, select the template for C# (ensure it targets .NET), and click Next.
//Name your project(e.g., MyUtilities) and click Next, then Create.
//Write your reusable code in the automatically generated Class1.cs file(or create a new class file).
//Go to the top menu and select Build > Build Solution. This generates a .dll file.

//Step 2: Add a Console Project to Use It
//Right-click on your Solution in the Solution Explorer.
//Select Add > New Project.
//Choose Console App, name it (e.g., MyConsoleApp), and click Create.

//Step 3: Reference the Class Library
//In the Solution Explorer, look under your new MyConsoleApp project.
//Right-click on Dependencies (or References) and select Add Project Reference...
//In the Reference Manager window, check the box next to your Class Library (MyUtilities) and click OK.

//Step 4: Use it in Code
//At the top of your Console App's Program.cs file, add a using statement pointing to your library, and call its methods:
//using MyUtilities; // Refers to your class library namespace




//Q4: What is a class library? Why do we use class libraries?
//What is a Class Library?
//A Class Library is a collection of reusable classes, interfaces, types, and methods that are compiled into a dynamic link library (.dll) file.
//Unlike a Console App or a Web App, a Class Library cannot be run directly because it doesn't have an entry point (a Main method). (it does not run but it can be built)
//Instead, it acts as a toolkit that other applications pull functionality from.

//Why do we use Class Libraries?
//Code Reusability (DRY - Don't Repeat Yourself): If we write a great piece of code, we don't want to copy-paste it into five different apps.
//we write it once in a class library and share it.

//Maintainability: If a bug is found or a rule changes, we only have to fix it in one place (the library) rather than updating multiple applications.

//Separation of Concerns: It helps organize large software projects.