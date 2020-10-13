using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonTempConverterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void C_to_f_btn_Click(object sender, EventArgs e) //Celsius to Fahrenheit
        {
            try
            {
                using (TempConverter.TemperatureConvertClient temp = new TempConverter.TemperatureConvertClient()) //Create/Dispose Object
                {
                    string tempString = c_to_f_field.Text; //Get input
                    int result = Int32.Parse(tempString);

                    result = temp.c2f(result); //Perform conversion

                    c_to_f_result.Text = result.ToString() + "° C"; //Display results
                    c_to_f_result.ForeColor = Color.Green;
                    c_to_f_result.Visible = true;
                }
            }
            catch(FormatException ex) //Catch incorrect input
            {
                c_to_f_result.Text = "Please enter a valid value";
                c_to_f_result.ForeColor = Color.Red;
                c_to_f_result.Visible = true;
            }
            catch(Exception ex) //Catch service not running
            {
                c_to_f_result.Text = "Update or run the service ref";
                c_to_f_result.ForeColor = Color.Red;
                c_to_f_result.Visible = true;
            }
        }

        private void F_to_c_btn_Click(object sender, EventArgs e) //Fahrenheit to Celsius
        {
            try
            {
                using (TempConverter.TemperatureConvertClient temp = new TempConverter.TemperatureConvertClient()) //Create/Dispose Object
                {
                    string tempString = f_to_c_field.Text; //Get input
                    int result = Int32.Parse(tempString);

                    result = temp.f2c(result); //Perform conversion

                    f_to_c_result.Text = result.ToString() + "° F"; //Display results
                    f_to_c_result.ForeColor = Color.Blue;
                    f_to_c_result.Visible = true;
                }
            }
            catch(FormatException ex)
            {
                f_to_c_result.Text = "Please enter a valid value";
                f_to_c_result.ForeColor = Color.Red;
                f_to_c_result.Visible = true;
            }
            catch(Exception ex)
            {
                f_to_c_result.Text = "Update or run the service ref";
                f_to_c_result.ForeColor = Color.Red;
                f_to_c_result.Visible = true;
            }
        }
    }
}
