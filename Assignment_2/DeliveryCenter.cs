
namespace Assignment_2
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[20];

        public String CenterName { get; set; } = default!;

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                else
                    return default!;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;

            }
        }

        public Shipment this[String trackingCode]
        {
            get
            {
                foreach (var shipment in shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                        return shipment;
                }
                return default!;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(String trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null!;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            foreach (var shipment in shipments)
            {
                if (shipment != null && shipment.TrackingCode != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine();
                } 
            }
        }
    }
}
