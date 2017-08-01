using Microsoft.Azure.Mobile.Server;
using System;

namespace myshoppe_demoService.DataObjects
{
    public class Region : EntityData
    {
		public int UserId { get; set; }
		public int WesternCape { get; set; }
		public int EasternCape { get; set; }
		public int FreeState { get; set; }
		public int Gauteng { get; set; }
		public int KwaZuluNatal { get; set; }
		public int Limpopo { get; set; }
		public int Mpumalanga { get; set; }
		public int NorthernCape { get; set; }
		public int NorthWest { get; set; }
    }
}
