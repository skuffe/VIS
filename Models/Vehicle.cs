using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
		[DataType(DataType.Date)]
		public DateTime? PurchaseDate { get; set; }
		public decimal Cost { get; set; }
		public string Dealer { get; set; }
		[DisplayName("Fuel Type")]
		public string FuelType { get; set; }

		[DisplayName("Registration Number")]
		[RegularExpression("([A-Z]){2}([0-9]){5}")]
		public string RegistrationNo { get; set; }
		[DisplayName("Date of Registration")]
		[DataType(DataType.Date)]
		public DateTime? RegistrationDate { get; set; }
		[DisplayName("Road Tax")]
		public decimal RoadTax { get; set; }
		[DisplayName("Chasis Number")]
		public int ChasisNo { get; set; }
		[DisplayName("Inspection Due")]
		[DataType(DataType.Date)]
		public DateTime? InspectionDue { get; set; }
		[DisplayName("Vehicle Status")]
		public string VehicleStatus { get; set; }

		[DisplayName("Policy Type")]
		public string PolicyType { get; set; }
		public string Policy { get; set; }
		[DisplayName("Policy Number")]
		public int PolicyNumber { get; set; }
		[DisplayName("Vehicle Value")]
		public decimal VehicleValue { get; set; }
		public decimal Amount { get; set; }
		[DisplayName("Policy Date")]
		[DataType(DataType.Date)]
		public DateTime? PolicyDate { get; set; }
		[DisplayName("Policy Expire Date")]
		[DataType(DataType.Date)]
		public DateTime? PolicyExpireDate { get; set; }

		public int InsuranceAgencyID { get; set; }
		public virtual InsuranceAgency InsuranceAgency { get; set; }
	}
}