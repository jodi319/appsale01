using Microsoft.Azure.Mobile.Server;
using System;

namespace myshoppe_demoService.DataObjects
{
    public class User : EntityData
    {
		public string Name { get; set; }
		public string Email { get; set; }
		public string CellNumber { get; set; }
		public string TelNumber { get; set; }
		public string Country { get; set; }
		public string Province { get; set; }
    }
}
