using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator
{
	public partial class MainPage : ContentPage
	{



		public MainPage()
		{
			InitializeComponent();

		}
		void OnClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string pressed = button.Text;
			resultText.Text += pressed;
			System.Diagnostics.Debug.WriteLine("fuck this");
		}

		public void OnClear(object sender, EventArgs e)
		{

			this.resultText.Text = "";
		}
		public void OnCalculate(object sender, EventArgs e)
		{
			bool z;

			DataTable dt = new DataTable();
			z = true;
			resultText.Text = resultText.Text.Replace(",", ".");
			try
			{
				
				var a = dt.Compute(resultText.Text, null);
			}
			catch (Exception ex)
			{

				resultText.Text = "ERROR";
				z = false;
			}
			finally
			{
                if (dt.Compute(resultText.Text, null).ToString() == "+nekonečno")
				{
					resultText.Text = "ERROR";
					z = false;
				}
				if (z)
				{
					resultText.Text = dt.Compute(resultText.Text, null).ToString();
				}
			}

		}
		public void DeleteOne(object sender, EventArgs e)
        {
            if (resultText.Text != "")
            {
				resultText.Text = resultText.Text.Remove(resultText.Text.Length - 1);
			}
            

			
        }

	}
}


