using System;
namespace acunmedyaodev.classes
{
	public class Araba
	{
		public string marka;
        public string vites;


        public void Print()
        {
			Console.WriteLine("\n araba'nın markası = " + marka);
            Console.WriteLine("\n vites = " + vites);
            Console.WriteLine("----------------------");
        }


    }
}

