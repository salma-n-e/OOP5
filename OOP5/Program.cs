using OOP04;
using System.ComponentModel.Design;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q 1
            // a) Only the reference is copied, not the actual object data.
            //  Both variables now point to the exact same memory location on the Heap.
            // b) No. It does not allocate new memory or create a new object. Any modification
            // made through one variable will directly affect the other variable because they reference the same object.
            // c) Copying a Reference: Copies only the pointer/address to the existing object.
            // No new object is created on the Heap.
            // Copying an Object: Allocates memory on the Heap and creates a new object containing duplicate values
            // from the original object.

            // Q 2
            // a) A Shallow Copy creates a new object, but copies only the top-level fields.
            // Primitive values are copied by value, while reference-type fields are copied as references 
            //  b)A Deep Copy creates a new object and recursively creates new copies of all nested objects/reference types,
            //  resulting in complete independence between the original and copied objects.
            // c) Their references  are copied, meaning both the original
            // and shallow-copied objects will share the exact same nested objects in memory.
            // d) Entirely new instances of the reference-type members are instantiated in memory,
            // copying their internal values so no references are shared.
            // e)  When an object contains nested complex structures ,
            // and you want to modify the cloned order's item details without affecting the original order's data.

            // Q 3 
            // a) A static field belongs to the Class itself and is shared across all instances (objects) in a single memory location.
            // An instance field belongs to a specific Object and each created object has its own separate copy of that field. 
            // b) A static method belongs to the class and can be called directly using the class name without
            // creating an instance.
            // No, a static method cannot directly access instance members (fields or methods)
            // because instance members require a specific object reference (this), which does not exist in a static
            // context.
            // c) A static constructor is used to initialize static data or perform actions required only once.
            // It is executed automatically before the first instance is created or any static members are referenced.
            // It takes no access modifiers or parameters and executes only once per application run.
            // d) A static class is a class that contains only static members and cannot be instantiated.
            // No, you cannot create an object from a static class (using the new keyword is prohibited).

            // Q 4
            // a) An extension method is a special kind of static method that enables you to "add"
            // new methods to existing types (like string, int, or custom classes) without modifying
            // the original code, inheriting from it, or recompiling it. 
            // b) The this keyword must precede the first parameter.
            // c) It must be declared inside a non-generic static class.
            // d) No, an extension method cannot access private or protected
            // members of the extended class. It can only access its public members.

            // Q 5
            // a) A Partial Class allows the definition/implementation of a single class
            // to be split across multiple physical .cs files using the partial keyword.
            // When compiled, all parts are combined into one single class.
            // b) To allow multiple developers to work on different parts of the same class simultaneously without merge conflicts.
            // To separate auto - generated code(like UI designers or database entities) from custom user code.
            //To organize large classes into cleaner, more manageable files based on features.
            // c) A Partial Method is a method declared in one part of a partial class and optionally implemented in another
            // part of the same partial class. It must return void and cannot have access modifiers (implicitly private).
            // d) The C# compiler completely removes the method declaration and all calls to it during compilation.
            // There is no performance penalty or runtime overhead.



            DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");



            Console.WriteLine($"[Check] Initial Shipments Count: {Shipment.GetTotalShipmentsCreated()}");


            ExpressDelivery shipment1 = new ExpressDelivery("SH001", "Laptop", 2.5, 50, new DeliveryAddress("Cairo", "Tahrir St", 10));


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(" Reference Assignment ");
            Shipment shipment2 = shipment1;


            Console.WriteLine($"shipment1 Tracking Code: {shipment1.TrackingCode}");
            Console.WriteLine($"shipment2 Tracking Code: {shipment2.TrackingCode}");
            Console.WriteLine($"Are shipment1 and shipment2 reference equal? {object.ReferenceEquals(shipment1, shipment2)}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(" Shallow Copy Demonstration ");
            Shipment shallowCopy = shipment1.ShallowCopy();


            Console.WriteLine($"Original Address City Before Change: {shipment1.Destination.City}");
            shallowCopy.Destination.City = "Giza";
            Console.WriteLine($"Original Address City After Changing Copy: {shipment1.Destination.City}");
            Console.WriteLine($"Same DeliveryAddress object? {object.ReferenceEquals(shipment1.Destination, shallowCopy.Destination)}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(" Deep Copy Demonstration ");
            Shipment deepCopy = shipment1.DeepCopy();


            Console.WriteLine($"Original Address City Before Change: {shipment1.Destination.City}");
            deepCopy.Destination.City = "Alexandria";
            Console.WriteLine($"Original Address City After Changing Copy: {shipment1.Destination.City}");
            Console.WriteLine($"Copied Address City: {deepCopy.Destination.City}");
            Console.WriteLine($"Same DeliveryAddress object? {object.ReferenceEquals(shipment1.Destination, deepCopy.Destination)}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(" Static Shipment Counter ");
            Console.WriteLine($"Total Shipments Created So Far: {Shipment.GetTotalShipmentsCreated()}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(" Extension Methods Demonstration ");


            Console.WriteLine($"Shipment Summary: {shipment1.GetSummary()}");


            Console.WriteLine($"Is Shipment Delivered? {shipment1.IsDelivered()}");


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine(" Partial Method & Status Updates ");


            shipment1.UpdateTrackingStatus("Out For Delivery");
            shipment1.UpdateTrackingStatus("Delivered");

            Console.WriteLine($"Is Shipment Delivered Now? {shipment1.IsDelivered()}");
            Console.WriteLine($"Updated Summary: {shipment1.GetSummary()}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("All Checklists Completed Successfully!");
            DeliveryUtilities.PrintSeparator();


            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Street 10", 5);
            DeliveryAddress addr2 = new DeliveryAddress("Giza", "Street 5", 89);
            DeliveryAddress addr3 = new DeliveryAddress("Alexandria", "Street 20", 90);


            StandardShipment std = new StandardShipment("SH001", "Books", 2.5, 50m, addr1);


            ExpressShipment exp = new ExpressShipment("SH002", "Electronics", 1.2, 100m, addr2, 25m);


            InternationalShipment inter = new InternationalShipment("SH003", "Documents", 0.5, 200m, addr3, "Germany", 30m);


            DeliveryCenter center = new DeliveryCenter("Main Hub", 10);
            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(inter);


            Console.WriteLine("========================================");
            Console.WriteLine("  All Shipment Details ");
            Console.WriteLine("========================================");
            center.PrintAllShipments();


            Console.WriteLine("========================================");
            Console.WriteLine("  Tracking Statuses via DeliveryCenter ");
            Console.WriteLine("========================================");
            center.PrintTrackingStatuses();


            Console.WriteLine("========================================");
            Console.WriteLine("  Insurance Costs via DeliveryReport ");
            Console.WriteLine("========================================");
            DeliveryReport.PrintInsurance(std);
            DeliveryReport.PrintInsurance(exp);
            DeliveryReport.PrintInsurance(inter);


            Console.WriteLine("========================================");
            Console.WriteLine("  Polymorphism via ITrackable Array ");
            Console.WriteLine("========================================");
            ITrackable[] trackables = new ITrackable[] { std, exp, inter };
            foreach (ITrackable item in trackables)
            {
                DeliveryReport.PrintShipment(item);
            }


            Console.WriteLine("========================================");
            Console.WriteLine("  Polymorphism via IInsurable Array ");
            Console.WriteLine("========================================");
            IInsurable[] insurables = new IInsurable[] { std, exp, inter };
            foreach (IInsurable item in insurables)
            {
                DeliveryReport.PrintInsurance(item);

            }
        }
    }
}
