using System.Reflection;

namespace App_Workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== TASK 1 ========");
            BankAccount acc = new BankAccount("12345", 1000);
            Console.WriteLine("Account: " + acc.AccountNumber);
            acc.Deposit(500);
            acc.Withdraw(300);
            Console.WriteLine("Balance: " + acc.Balance);
            Console.WriteLine();

            Console.WriteLine("\n======== TASK 2 ========");
            Car car = new Car { Brand = "Toyota", Speed = 120, Seats = 4 };
            Motorcycle moto = new Motorcycle { Brand = "Yamaha", Speed = 90, HasCarrier = true };
            Console.WriteLine("\nCar Information:");
            car.DisplayInfo();
            Console.WriteLine("\nMotorcycle Information:");
            moto.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("\n======== TASK 3 (Overloading - Printer Class) ========");

            Printer printer = new Printer();

            printer.Print("Hello Students");
            printer.Print(250);
            printer.Print("Repeated Output", 3);
            Console.WriteLine();

            Console.WriteLine("\n======== TASK 3 (Inheritance + Polymorphism - Teacher) ========");

            NepaliTeacher nepali = new NepaliTeacher();
            nepali.Name = "Mr. Sharma";

            EnglishTeacher english = new EnglishTeacher();
            english.Name = "Mrs. Allen";

            nepali.Teaching();     // overridden method
            nepali.SalaryInfo();   // sealed 
            Console.WriteLine();

            english.Teaching();    // base method
            english.SalaryInfo();  // sealed method
            Console.WriteLine();

            Console.WriteLine("\n======== TASK 4 (Abstraction - AbsVehicle) ========");

            AbsVehicle carObj = new AbsCar();
            AbsVehicle bikeObj = new AbsBike();

            carObj.Display();
            carObj.StartEngine();
            carObj.StopEngine();

            Console.WriteLine();

            bikeObj.Display();
            bikeObj.StartEngine();
            bikeObj.StopEngine();

            Console.WriteLine();
        }
    }
}
