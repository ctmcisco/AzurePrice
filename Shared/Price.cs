using System.Runtime.CompilerServices;
using System;
// Generated from https://app.quicktype.io?share=BIWN5YNMt1MFeiqHapU1 and modified for System.Text.Json
namespace Client.Shared
{
    public class Price
    {
        public string CurrencyCode { get; set; }
        public double TierMinimumUnits { get; set; }
        public double RetailPrice { get; set; }
        public double UnitPrice { get; set; }
        public string ArmRegionName { get; set; }
        public string Location { get; set; }
        public DateTimeOffset EffectiveStartDate { get; set; }
        public Guid MeterId { get; set; }
        public string MeterName { get; set; }
        public string ProductId { get; set; }
        public string SkuId { get; set; }
        public string ProductName { get; set; }
        public string SkuName { get; set; }
        public string ServiceName { get; set; }
        public string ServiceId { get; set; }
        public string ServiceFamily { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Type { get; set; }
        public bool IsPrimaryMeterRegion { get; set; }
        public string ArmSkuName { get; set; }
        public string ReservationTerm { get; set; }

        //Calculated properties
        public string UnitPriceDollars { 
            get {
                return UnitPrice.ToString("C6");
            }
        }
        public double UnitPriceMonthly {
            get {
                //An azure month is 730 hours
                return UnitPrice*730;
            }
        }
        
        public string UnitPriceMonthlyDollars {
            get {
                //An azure month is 730 hours
                return UnitPriceMonthly.ToString("C6");
            }
        }
    }
}
