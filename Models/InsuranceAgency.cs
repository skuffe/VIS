﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIS.Models
{
	public class InsuranceAgency
	{
		public int InsuranceAgencyID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public int Zipcode { get; set; }
		public string City { get; set; }
		public int Phone { get; set; }
		public string Mail { get; set; }
	}
}