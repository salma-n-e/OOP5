using System;

namespace OOP04
{
   
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            
            string shipmentType = shipment.GetType().Name.Replace("Delivery", "");

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus().Equals("Delivered", StringComparison.OrdinalIgnoreCase);
        }
    }
}