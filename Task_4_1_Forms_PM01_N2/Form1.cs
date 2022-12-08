using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_1_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double rec(double x, int n, int index = 0)
		{
			if (index == n)
			{
				return x + n;
			}
			else
			{
				return index + (x / rec(x, n, index + 1));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int n;
				double x;
				x = double.Parse(textBox1.Text);
				n = int.Parse(textBox2.Text);
				if(n <= 0)
				{
					throw new FormatException();
				}
				textBox3.Text = string.Format("Результат: {0:f3}", rec(x, n));
			}
			catch (FormatException)
			{
				textBox3.Text = string.Format("Введены неверные параметры.");
			}
			catch
			{
				textBox3.Text = string.Format("Что-то пошло не так...");
			}
		}
	}
}
