using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
	public class Latte : Coffee, IMilk
	{
		public double Discount { get; set; }
		public Latte(double discount) : base(discount)
		{
			Discount = discount;
		}
		public int MlMilk()
		{
			return 200;
		}

		public override double PriceOfCoffee()
		{
			return 40.0 - Discount;
		}

		public override string Strength()
		{
			return "Weak";
		}
	}
}
