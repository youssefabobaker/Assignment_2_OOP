
namespace Assignment_2
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.extraFee = extraFee;
        }

        

        public override decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5) + extraFee;
        }
    }
}
