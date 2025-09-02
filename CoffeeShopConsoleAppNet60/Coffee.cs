using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
	public abstract class Coffee
	{
		public double Discount { get; set; }
		public Coffee(double discount)
		{
			if (discount > 5)
			{
				throw new Exception("Discount is too large");
			}
		}
		public abstract double PriceOfCoffee();
		public abstract string Strength();

	}
}
