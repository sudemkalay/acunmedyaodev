using System;
namespace odev2.classes
{
	public class Bmw
	{
        public string Marka { get; set; } = "BMW";

        public void Drive()
		{
			Console.WriteLine("Bmw çok hızlı gidiyor!");
		}
	public void FloatOnWater()
		{
			Console.WriteLine("Bmw denizde yüzüyor!");
		}
	public void Fly()
		{
			Console.WriteLine("Bmw havada uçuyor!");
		}
	}
}

