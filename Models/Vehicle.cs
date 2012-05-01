using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace VIS.Models
{
	public class Vehicle
	{
		public int VehicleID { get; set; }
		public string Model { get; set; }
		[DisplayName("Year of Make")]
		public int YearOfMake { get; set; }
		public string Color { get; set; }
        [DisplayName("Date of Purchase")]
		public DateTime PurchaseDate { get; set; }
		public decimal Cost { get; set; }
		public string Dealer { get; set; }
		public string FuelType { get; set; }

		public string RegistrationNo { get; set; }
		public DateTime RegistrationDate { get; set; }
		public decimal RoadTax { get; set; }
		public int ChasisNo { get; set; }
		public DateTime InspectionDue { get; set; }
		public string VehicleStatus { get; set; }

		public string PolicyType { get; set; }
		public string Policy { get; set; }
		public int PolicyNumber { get; set; }
		public decimal VehicleValue { get; set; }
		public decimal Amount { get; set; }
		public DateTime PolicyDate { get; set; }
		public DateTime PolicyExpireDate { get; set; }

		public int InsuranceAgencyID { get; set; }
		public virtual InsuranceAgency InsuranceAgency { get; set; }
	}
}