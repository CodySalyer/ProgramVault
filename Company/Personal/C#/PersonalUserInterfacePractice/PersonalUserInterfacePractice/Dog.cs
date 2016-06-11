using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalUserInterfacePractice
{
	class Dog
	{
		public Dog()
		{
			MessageBox.Show("I construct a dog");
		}

		public int Age { get; set; }

		public void Bark()
		{
			FileStream fs = File.OpenRead("whatever.txt");
			StreamReader reader = new StreamReader(fs);
			string line = reader.ReadLine();
		}

		private void AnotherMethod()
		{
			MessageBox.Show("Another Bark");
		}
	}
}
