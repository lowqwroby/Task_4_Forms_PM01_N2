using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_2_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		static int Res(string str, int index, int i = 0)
		{
			int result = 0;
			
			if (index < 0)
			{
				return result;
			}
			else
			{
				
				if (str[index] == '1')
				{
					result += Convert.ToInt32(Math.Pow(2, i));
					return result + Res(str, index - 1, i + 1);
				}
				else
				{
					return result + Res(str, index - 1, i + 1);
				}
				if (str[0] == '0')
			{
				result *= -1;
			}
			}
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string str = textBox1.Text;
			string str1 = "";
			int a = 0;
			if (str[0] == '-')
			{
				a = -1;
				for (int i = 1; i < str.Length; i++)
				{
					if (str[i] != '1' && str[i] != '0')
					{
						textBox2.Text = string.Format("Число не в двоичной форме!");
						return;
					}
				}
				for (int i = 1; i < str.Length; i++)
				{
					str1 += str[i];
				}
			}
			else
			{
				a = 1;
				for (int i = 0; i < str.Length; i++)
				{
					if (str[i] != '1' && str[i] != '0')
					{
						textBox2.Text = string.Format("Число не в двоичной форме!");
						return;
					}
				}
				for (int i = 0; i < str.Length; i++)
				{
					str1 += str[i];
				}
			}
			if (str == "")
			{
				textBox2.Text = string.Format("Введены неверные данные!");
			}
			else
			{
				textBox2.Text = string.Format("{0}", (a * Res(str1, str1.Length - 1)));
			}
		}
	}
}
