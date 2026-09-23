using System;

namespace OOP04
{
 
    public abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";

      
        partial void OnTrackingStatusChanged(string newStatus);

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;

             
                OnTrackingStatusChanged(newStatus);
            }
        }
    }
}