using System;

namespace OOP04
{
    public class DeliveryAddress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.City = city;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{City}, {Street}, {BuildingNumber}";
        }

        
        public DeliveryAddress DeepCopy()
        {
            return new DeliveryAddress(this.City, this.Street, this.BuildingNumber);
        }
    }
}