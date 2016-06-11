using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalUserInterfacePractice
{
    public partial class Form1 : Form
    {
		public int ValueA { get; set; }

        public Form1()
        {
	            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            buttonBox.AppendText("Button Pressed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonBox.Clear();
        }
    }
}
