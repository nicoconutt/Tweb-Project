using eUseControl.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Models
{
	public class DataRequest
	{
		public string UserName { get; set; }
		public URole Level { get; set; }

	}
}