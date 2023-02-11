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
	public partial class Calculator : Form
	{
		bool operation_pressed = false;
		double value = 0;
		string operation = null;
		public Calculator()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			if((txtSolution.Text=="0") || (operation_pressed))
			{
				txtSolution.Clear();
				operation_pressed = false;
			}
			Button b = (Button)sender;
			txtSolution.Text = txtSolution.Text + b.Text;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtSolution.Text = "0";
		}

		private void btnCut_Click(object sender, EventArgs e)
		{
			txtSolution.Text = "0";
		}

		private void operator_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			operation = b.Text;
			value = double.Parse(txtSolution.Text);
			operation_pressed = true;
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			SwitchCase();
			
			operation_pressed = true;
			
		}
		private void SwitchCase()
        {
			switch (operation)
			{
				case "+":
					txtSolution.Text = (value + double.Parse(txtSolution.Text)).ToString();
					break;
				case "-":
					txtSolution.Text = (value - double.Parse(txtSolution.Text)).ToString();
					break;
				case "*":
					txtSolution.Text = (value * double.Parse(txtSolution.Text)).ToString();
					break;
				case "/":
					txtSolution.Text = (value / double.Parse(txtSolution.Text)).ToString();
					break;
			
				default:
					break;
			}
		}
	}
}
