using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
	public class Cortado : Coffee, IMilk
	{
		public double Discount { get; set; }
		public Cortado(double discount) : base(discount)
		{
			Discount = discount;
		}
		public int MlMilk()
		{
			return 40;
		}

		public override double PriceOfCoffee()
		{
			return 25.0 - Discount;
		}

		public override string Strength()
		{
			return "Medium";
		}
	}
}
