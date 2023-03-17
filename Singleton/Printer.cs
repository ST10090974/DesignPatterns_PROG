using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Printer
    {

        private  Printer() { }

		private static Printer objPrinter;

		public static Printer GetInstance()
		{
			if (objPrinter == null)
			{
				objPrinter= new Printer();
			}
			return objPrinter; 
		}


	}
}
