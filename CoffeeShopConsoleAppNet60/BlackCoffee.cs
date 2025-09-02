using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
	public class BlackCoffee : Coffee
	{
		public double Discount { get; set; }
		public BlackCoffee(double discount) : base(discount)
		{
			Discount = discount;
		}
		public override double PriceOfCoffee()
		{
			return 20.0 - Discount;
		}

		public override string Strength()
		{
			return "Strong";
		}
	}
}
