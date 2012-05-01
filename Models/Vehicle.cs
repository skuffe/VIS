﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIS.Models
{
	public class Vehicle
	{
		public int VehicleID { get; set; }
		public string Model { get; set; }
		public int YearOfMake { get; set; }
		public string Color { get; set; }
		public DateTime PurchaseDate { get; set; }
		public double Cost { get; set; }
		public string Dealer { get; set; }
		public string FuelType { get; set; }

		public string RegistrationNo { get; set; }
		public DateTime RegistrationDate { get; set; }
		public double RoadTax { get; set; }
		public int ChasisNo { get; set; }
		public DateTime InspectionDue { get; set; }
		public string VehicleStatus { get; set; }

		public int AgencyID { get; set; }
		public string PolicyType { get; set; }
		public string Policy { get; set; }
		public int PolicyNumber { get; set; }
		public double VehicleValue { get; set; }
		public double Amount { get; set; }
		public DateTime PolicyDate { get; set; }
		public DateTime PolicyExpireDate { get; set; }

		public InsuranceAgency InsuranceAgency { get; set; }
	}
}