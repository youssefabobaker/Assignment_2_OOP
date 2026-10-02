namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region indexers section in assignment 1 
            // i have solved and submittedthe indexers section in assignment 1 
            #endregion

            #region Question 1
            #region What is the difference between a class and a struct?
            // class --> reference type , copy the reference of the object to another variable , stored in heap memory , support inheritance and polymorphism , can be null , default constructor is provided if no constructor is defined in the class , suitable for large data
            // struct --> value type , copy the value of the struct to another variable , stored in stack memory , do not support inheritance and polymorphism , cannot be null , default constructor always provided , suitable for small data 
            #endregion

            #region Why are classes more suitable than structs for large applications?
            // classes are more suitable than structs for large applications because they are reference types and can be easily managed in memory. They also support inheritance and polymorphism, which allows for more flexible and reusable code. Structs, on the other hand, are value types and are better suited for small data structures that do not require inheritance or polymorphism.
            #endregion
            #endregion

            #region Question 2
            // Which class is the parent class? --> Shipment is the parent class
            // Which class is the child class? --> ExpressShipment is the child class
            // What members are inherited by ExpressShipment? --> TrackingCode 
            // Why is inheritance better than duplicating the same code in multiple classes? --> because it provides code maintainability, reusability the existing functions without having to rewrite the same code, reduces redundancy and makes it easier to manage and update the code. 
            #endregion

            #region Part 02 : Practical 
            DeliveryCenter deliveryCenter = new DeliveryCenter();

            Console.Write("Enter Delivery center Name: ");
            deliveryCenter.CenterName = Console.ReadLine()!;
            Console.WriteLine();

            string trackingCode;
            string description;
            decimal weight ;
            decimal deliveryFee;
            string city;
            string street;
            int number ;
            DeliveryAddress destination;
            bool isAdded;

            Console.WriteLine("Enter Standard Shipment Details:");
            Console.Write("Tracking Code: ");
            trackingCode = Console.ReadLine()!;
            Console.Write("Description: ");
            description = Console.ReadLine()!;
            Console.Write("Weight: ");
            weight = decimal.Parse(Console.ReadLine()!);
            Console.Write("Delivery Fee: ");
            deliveryFee = decimal.Parse(Console.ReadLine()!);
            Console.Write("City: ");
            city = Console.ReadLine()!;
            Console.Write("Street: ");
            street = Console.ReadLine()!;
            Console.Write("Bulding Number: ");
            number = int.Parse(Console.ReadLine()!);
            destination = new DeliveryAddress(city, street, number);
            StandardShipment standardShipment = new StandardShipment(trackingCode, description, weight, deliveryFee, destination);
            isAdded = deliveryCenter.AddShipment(standardShipment);
            if (isAdded)
            {
                Console.WriteLine("StandardShipment added successfully.");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Failed to add Standard shipment.");
                Console.WriteLine();

            }

            Console.WriteLine("Enter Express Shipment Details:");
            Console.Write("Tracking Code: ");
            trackingCode = Console.ReadLine()!;
            Console.Write("Description: ");
            description = Console.ReadLine()!;
            Console.Write("Weight: ");
            weight = decimal.Parse(Console.ReadLine()!);
            Console.Write("Delivery Fee: ");
            deliveryFee = decimal.Parse(Console.ReadLine()!);
            Console.Write("City: ");
            city = Console.ReadLine()!;
            Console.Write("Street: ");
            street = Console.ReadLine()!;
            Console.Write("Bulding Number: ");
            number = int.Parse(Console.ReadLine()!);
            destination = new DeliveryAddress(city, street, number);
            Console.Write("ExtraFee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine()!);
            ExpressShipment expressShipment = new ExpressShipment(trackingCode, description, weight, deliveryFee, destination, extraFee);
            isAdded = deliveryCenter.AddShipment(expressShipment);
            if (isAdded)
            {
                Console.WriteLine("Express Shipment added successfully.");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Failed to add Expressshipment.");
                Console.WriteLine();

            }

            Console.WriteLine("Enter International Shipment Details:");
            Console.Write("Tracking Code: ");
            trackingCode = Console.ReadLine()!;
            Console.Write("Description: ");
            description = Console.ReadLine()!;
            Console.Write("Weight: ");
            weight = decimal.Parse(Console.ReadLine()!);
            Console.Write("Delivery Fee: ");
            deliveryFee = decimal.Parse(Console.ReadLine()!);
            Console.Write("City: ");
            city = Console.ReadLine()!;
            Console.Write("Street: ");
            street = Console.ReadLine()!;
            Console.Write("Bulding Number: ");
            number = int.Parse(Console.ReadLine()!);
            destination = new DeliveryAddress(city, street, number);
            Console.Write("CustomsFee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine()!);
            Console.Write("DestinationCountry: ");
            String destinationCountry = Console.ReadLine()!;
            InternationalShipment internationalShipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee );
            isAdded = deliveryCenter.AddShipment(internationalShipment);
            if (isAdded)
            {
                Console.WriteLine("International Shipment added successfully.");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Failed to add International shipment.");
                Console.WriteLine();

            }

            Console.WriteLine("==========================================");
            Console.WriteLine($"Delivery Center : {deliveryCenter.CenterName}");
            Console.WriteLine("==========================================");
            deliveryCenter.PrintAllShipments();

            Console.Write("Enter Tracking Code To Search: ");
            string searchTrackingCode = Console.ReadLine()!;
            Shipment SearchedShipmint = deliveryCenter[searchTrackingCode];
            if (SearchedShipmint != null)
            {
                Console.WriteLine("Shipment found:");
                SearchedShipmint.PrintShipment();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
                Console.WriteLine();
            }

            Console.Write("Enter Tracking Code To Remove:");
            String trackingCodeToRemove = Console.ReadLine()!;
            bool isRemoved = deliveryCenter.RemoveShipment(trackingCodeToRemove);
            if (isRemoved)
            {
                Console.WriteLine("Shipment removed successfully.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Failed to remove Shipment.");
                Console.WriteLine();
            }

            Console.WriteLine("==========================================");
            Console.WriteLine($"Remaining Shipments");
            Console.WriteLine("==========================================");
            deliveryCenter.PrintAllShipments();
            #endregion
        }
    }
}
