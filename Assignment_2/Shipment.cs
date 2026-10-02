
namespace Assignment_2
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;



        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (value != null && value != string.Empty && value != "")
                    trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != null && value != string.Empty && value != "")
                    description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public virtual decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5);
        }


        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            destination = default;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            this.destination = destination;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        }
    }
}
