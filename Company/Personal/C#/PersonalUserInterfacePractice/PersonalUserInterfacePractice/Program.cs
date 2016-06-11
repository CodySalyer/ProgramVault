using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalUserInterfacePractice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			Dog d = new Dog();
			d.Bark();

   //         Application.EnableVisualStyles();
   //         Application.SetCompatibleTextRenderingDefault(false);

			//Form1 form = new Form1();
			//form.ValueA = 3;
   //         Application.Run();

       }

		public static Dog GetOne()
		{
			return new Dog();
		}
    }
}
