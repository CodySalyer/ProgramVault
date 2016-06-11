using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void button_Num(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			screen.Text = screen.Text + button.Text;
		}
		private void Button_Op(object sender, EventArgs e)
		{
			Button Opp = (Button)sender;
			switch (Opp.Text)
			{
				case "CLR":
					screen.Text = " ";
				break;

				case "+":
					screen.Text = "+";
					break;

				case "-":
					screen.Text = "-";
					break;
				case "*":
					screen.Text = "*";
					break;

				case "/":
					screen.Text = "/";
					break;
				case "=":
					screen.Text = "=";
					break;

			}
		}
	}
}
