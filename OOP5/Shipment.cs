using System;

namespace OOP04
{
    
    public abstract partial class Shipment
    {
        private static int totalShipmentsCreated;

        public static int TotalShipmentsCreated => totalShipmentsCreated;

        static Shipment()
        {
            totalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public static int GetTotalShipmentsCreated() => totalShipmentsCreated;

        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get => trackingCode;
            set => trackingCode = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
        }

        public string Description
        {
            get => description;
            set => description = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
        }

        public double Weight
        {
            get => weight;
            set => weight = value > 0 ? value : 1;
        }

        public decimal DeliveryFee
        {
            get => deliveryFee;
            set => deliveryFee = value >= 0 ? value : 50;
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedDeliveryTCost => DeliveryFee + ((decimal)Weight * 5);

        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            totalShipmentsCreated++;
        }

        public virtual void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Total Cost: {EstimatedDeliveryTCost}");
            Console.WriteLine($"Destination: {Destination?.GetFullAddress()}");
        }

        public abstract decimal EstimatedCost { get; }
        public abstract void printShipment();

        public Shipment CopyShipment() => (Shipment)this.MemberwiseClone();
        public Shipment ShallowCopy() => (Shipment)this.MemberwiseClone();

        public Shipment DeepCopy()
        {
            Shipment clonedShipment = (Shipment)this.MemberwiseClone();
            if (this.Destination != null)
            {
                clonedShipment.Destination = this.Destination.DeepCopy();
            }
            return clonedShipment;
        }

      
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}