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

		[Required]
		public string Model { get; set; }

		[Required]
		[DisplayName("Year of Make")]
		public int YearOfMake { get; set; }

		[Required]
		public string Color { get; set; }

		[Required]
        [DisplayName("Date of Purchase")]
		[DataType(DataType.Date)]
		public DateTime PurchaseDate { get; set; }

		[Required]
		public decimal Cost { get; set; }

		[Required]
		public string Dealer { get; set; }

		[Required]
		[DisplayName("Fuel Type")]
		public string FuelType { get; set; }

		[Required]
		[DisplayName("Registration Number")]
		[RegularExpression("([A-Z]){2}([0-9]){5}")]
		public string RegistrationNo { get; set; }

		[Required]
		[DisplayName("Date of Registration")]
		[DataType(DataType.Date)]
		public DateTime RegistrationDate { get; set; }

		[Required]
		[DisplayName("Road Tax")]
		public decimal RoadTax { get; set; }

		[Required]
		[DisplayName("Chasis Number")]
		public int ChasisNo { get; set; }

		[Required]
		[DisplayName("Inspection Due")]
		[DataType(DataType.Date)]
		public DateTime InspectionDue { get; set; }

		[Required]
		[DisplayName("Vehicle Status")]
		public string VehicleStatus { get; set; }

		[Required]
		[DisplayName("Policy Type")]
		public string PolicyType { get; set; }

		[Required]
		public string Policy { get; set; }

		[Required]
		[DisplayName("Policy Number")]
		public int PolicyNumber { get; set; }

		[Required]
		[DisplayName("Vehicle Value")]
		public decimal VehicleValue { get; set; }

		[Required]
		[DisplayName("Insurance Fee")]
		public decimal Amount { get; set; }

		[Required]
		[DisplayName("Policy Date")]
		[DataType(DataType.Date)]
		public DateTime PolicyDate { get; set; }

		[Required]
		[DisplayName("Policy Expire Date")]
		[DataType(DataType.Date)]
		public DateTime PolicyExpireDate { get; set; }

		[Required]
		public int InsuranceAgencyID { get; set; }
		public virtual InsuranceAgency InsuranceAgency { get; set; }
	}
}