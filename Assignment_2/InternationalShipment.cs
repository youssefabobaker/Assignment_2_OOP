
namespace Assignment_2
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public String DestinationCountry
        {
            get 
            { 
                return destinationCountry; 
            }
            set
            {
                if (value != null && value != string.Empty && value != " ")
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.destinationCountry = destinationCountry;
            this.customsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5) + CustomsFee;
        }

    }
}
