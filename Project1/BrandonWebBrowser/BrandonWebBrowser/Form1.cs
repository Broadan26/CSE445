using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonWebBrowser
{
    public partial class BrandonBrowser : Form
    {
        public BrandonBrowser()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e) //Web Browser Back
        {
            da_browser.GoBack();
        }

        private void Forward_btn_Click(object sender, EventArgs e) //Web Browser Forward
        {
            da_browser.GoForward();
        }

        private void Refresh_btn_Click(object sender, EventArgs e) //Web Browser Refresh
        {
            da_browser.Refresh();
        }

        private void Home_btn_Click(object sender, EventArgs e) //Web Browser Home
        {
            da_browser.Navigate("www.google.com");
        }

        private void Navigate_btn_Click(object sender, EventArgs e) //Web Browser Navigate
        {
            da_browser.Navigate(search_bar.Text);
        }

        private void Button1_Click(object sender, EventArgs e) //Encrypt Button
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(encrypt_field.Text)) //Check for no text
                {
                    EncryptDecrypt.ServiceClient encrypt = new EncryptDecrypt.ServiceClient();
                    string result = encrypt.Encrypt(encrypt_field.Text);
                    result_field.Text = result;

                    encrypt_outcome.Text = "Success!";
                    encrypt_outcome.ForeColor = Color.DarkGreen;
                    encrypt_outcome.Visible = true;
                }
                else //If no text
                {
                    result_field.Text = "Please enter a valid string to encrypt";

                    encrypt_outcome.Text = "Nothing to Encrypt!";
                    encrypt_outcome.ForeColor = Color.Red;
                    encrypt_outcome.Visible = true;
                }
            }
            catch (Exception ex) //For service being down
            {
                encrypt_outcome.Text = "Service not reached!";
                encrypt_outcome.ForeColor = Color.Red;
                encrypt_outcome.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e) //Decrypt Button
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(encrypt_field.Text)) //Check for no text
                {
                    EncryptDecrypt.ServiceClient decrypt = new EncryptDecrypt.ServiceClient();
                    string result = decrypt.Decrypt(encrypt_field.Text);
                    result_field.Text = result;

                    encrypt_outcome.Text = "Success!";
                    encrypt_outcome.ForeColor = Color.DarkGreen;
                    encrypt_outcome.Visible = true;
                }
                else //If no text
                {
                    result_field.Text = "Please enter a valid string to decrypt";

                    encrypt_outcome.Text = "Nothing to Decrypt!";
                    encrypt_outcome.ForeColor = Color.Red;
                    encrypt_outcome.Visible = true;
                }
            }
            catch (FaultException ex) //For a bad decrypt
            {
                encrypt_outcome.Text = "Invalid item!";
                result_field.Text = "";
                encrypt_outcome.ForeColor = Color.Red;
                encrypt_outcome.Visible = true;
            }
            catch (Exception ex) //For service being down
            {
                encrypt_outcome.Text = "Service not reached!";
                encrypt_outcome.ForeColor = Color.Red;
                encrypt_outcome.Visible = true;
            }
        }

        private void Check_stocks_btn_Click(object sender, EventArgs e) //Get Stock Value
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(stock_field.Text)) //Check for no text
                {
                    StockService.ServiceClient stocks = new StockService.ServiceClient();
                    string result = stocks.getStockquote(stock_field.Text);
                    stock_result.Text = stock_field.Text.ToUpper() + ":   " + result;
                    stock_result.ForeColor = Color.Blue;
                    stock_result.Visible = true;
                }
                else //If no text
                {
                    stock_result.Text = "Please enter a valid stock";
                    stock_result.ForeColor = Color.Red;
                    stock_result.Visible = true;
                }
            }
            catch(Exception ex) //For service being down
            {
                stock_result.Text = "Service not reached!";
                stock_result.ForeColor = Color.Red;
                stock_result.Visible = true;
            }
        }
    }
}
