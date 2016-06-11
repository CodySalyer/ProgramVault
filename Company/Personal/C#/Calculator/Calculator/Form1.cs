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
		string[] opp = new string[9];
		double[] calcNumbers = new double[10];
		int n = 1;
		double result = 0;
		public Form1()
		{
			InitializeComponent();
		}
		
		private void button_Num(object sender, EventArgs e)
		{
			if(n ==0)
			{
				screen.Text = "";
				n++;
			}
			Button button = (Button)sender;
			screen.Text = screen.Text + button.Text;
			calcNumbers[n] = Convert.ToDouble(screen.Text); 
		}
		private void Button_Op(object sender, EventArgs e)
		{
			//Button opperator = (Button)sender;
			Button buttonText = (Button)sender;
			opp[n] = buttonText.Text;
			switch (opp[n])
			{
				case "CLR":
					screen.Text = "";
					//double[] calcNumbers = new double[10];
					n = 1;
				break;

				case "+":
					screen.Text = "";
					opp[n] = "+";
					n ++;
					break;

				case "-":
					screen.Text = "";
					opp[n] = "-";
					n++;
					break;

				case "*":
					screen.Text = "";
					opp[n] = "*";
					n++;
					break;

				case "/":
					screen.Text = "";
					opp[n] = "/";
					n++;
					break;

				case "=":
					screen.Text = "= ";
	
					for (int m = 1; m != n; m++)
					{
						//MessageBox.Show(Convert.ToString(n));
						//MessageBox.Show(opp[m]);
						switch (opp[m])
						{
							case "+":
								calcNumbers[m + 1] = calcNumbers[m] + calcNumbers[m + 1];
								//MessageBox.Show("+");
								break;

							case "-":
								calcNumbers[m + 1] = calcNumbers[m] - calcNumbers[m + 1];
								//MessageBox.Show("-");
								break;

							case "*":
								calcNumbers[m + 1] = calcNumbers[m] * calcNumbers[m + 1];
								//MessageBox.Show("*");
								break;

							case "/":
								calcNumbers[m + 1] = calcNumbers[m] / calcNumbers[m + 1];
								//MessageBox.Show("/");
								break;
						}
						result = calcNumbers[m + 1];
					}
					screen.Text = screen.Text + Convert.ToString(result);
					n = 0;
					break;
			}
			if(n>=10)
			{
				MessageBox.Show("too many values opperation cancelled");
				n = 1;
			}
		}
	}
}
