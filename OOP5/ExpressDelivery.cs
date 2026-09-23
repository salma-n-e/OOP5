using OOP04;
using System;

namespace OOP5
{
    public class ExpressDelivery : Shipment
    {
        public ExpressDelivery(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => EstimatedDeliveryTCost;

        public override void printShipment()
        {
            PrintShipmentDetails();
        }
    }
}