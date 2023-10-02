namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class and object
            //Person person1 = new Person("Ram", 30);
            //Person person2 = new Person("Rahul", 25);

            //person1.Greet();
            //person2.Greet();


            //inheritance
            //Dog myDog = new Dog("Tommy", 3, "Golden Retriever");
            //Console.WriteLine($"Name: {myDog.Name}");
            //Console.WriteLine($"Age: {myDog.Age}");
            //Console.WriteLine($"Breed: {myDog.Breed}");

            //myDog.Eat();   
            //myDog.Sleep(); 
            //myDog.Bark();


            //polymorphism
            //Shape shape1 = new Circle(); 
            //Shape shape2 = new Square(); 

            // Compile-time polymorphism (method overloading)
            //DisplayInfo(shape1);
            //DisplayInfo(shape2);

            // Runtime polymorphism (method overriding)
            //shape1.Display();
            //shape2.Display();


            // Compile-time polymorphism (method overloading)
            //static void DisplayInfo(Shape shape)
            //{
            //    Console.WriteLine("Displaying information about a shape:");
            //    shape.Display();
            //}



            //encapsulation
            BankAccount myAccount = new BankAccount("123456");

            //Console.WriteLine("Account Number: " + myAccount.GetAccountNumber());
            //Console.WriteLine("Balance: $" + myAccount.GetBalance());

            //myAccount.Deposit(1000);
            //myAccount.Withdraw(500);

            //Console.WriteLine("Updated Balance: $" + myAccount.GetBalance());


            //abstraction
            //Size size1 = new Triangle();
            //Size size2 = new Rectangle();

            //size1.Draw();
            //size2.Draw();


            //variables
            //int age = 25;
            //Console.WriteLine($"Age: {age}");

            //float temperature = 72.5f;
            //Console.WriteLine($"Temperature: {temperature}°F");

            //double price = 19.99;
            //Console.WriteLine($"Price: ${price}");

            //char grade = 'A';
            //Console.WriteLine($"Grade: {grade}");

            //bool isStudent = true;
            //Console.WriteLine($"Is Student? {isStudent}");

            //string name = "John";
            //Console.WriteLine($"Name: {name}");

            //DayOfWeek day = DayOfWeek.Wednesday;
            //Console.WriteLine($"Day: {day}");


            //value type
            //int a = 10;
            //int b = a; 
            //a = 20; 

            //Console.WriteLine($"a: {a}, b: {b}");


            //reference type
            Student student1 = new Student();
            student1.Name = "Ram";

            Student student2 = student1;

            student1.Name = "Raj"; 

            Console.WriteLine($"person1.Name: {student1.Name}");
            Console.WriteLine($"person2.Name: {student2.Name}");
        }
    }
}
