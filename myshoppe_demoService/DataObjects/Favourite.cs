using Microsoft.Azure.Mobile.Server;
using System;

namespace myshoppe_demoService.DataObjects
{
    public class Favourite : EntityData
    {
		public int UserId { get; set; }
		public int FashionAndBeauty { get; set; }
		public int SportsAndOutdoor { get; set; }
		public int Pets { get; set; }
		public int Vehicles { get; set; }
		public int HomeImprovement { get; set; }
		public int BabiesChildren { get; set; }
		public int HobbiesInterests { get; set; }
		public int MobilePhonesAndAccessories { get; set; }
		public int HomeAppliances { get; set; }
		public int Gaming { get; set; }
		public int Books { get; set; }
		public int Music { get; set; }
    }
}
