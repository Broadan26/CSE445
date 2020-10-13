namespace BrandonWebBrowser
{
    partial class BrandonBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.navigate_btn = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.da_browser = new System.Windows.Forms.WebBrowser();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.encrypt_label = new System.Windows.Forms.Label();
            this.encrypt_field = new System.Windows.Forms.TextBox();
            this.result_field = new System.Windows.Forms.TextBox();
            this.encrypt_outcome = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.stock_field = new System.Windows.Forms.TextBox();
            this.check_stocks_btn = new System.Windows.Forms.Button();
            this.stock_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward_btn.Location = new System.Drawing.Point(93, 9);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(75, 23);
            this.forward_btn.TabIndex = 1;
            this.forward_btn.Text = "Forward";
            this.forward_btn.UseVisualStyleBackColor = true;
            this.forward_btn.Click += new System.EventHandler(this.Forward_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(174, 9);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(255, 9);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(75, 23);
            this.home_btn.TabIndex = 3;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // navigate_btn
            // 
            this.navigate_btn.BackColor = System.Drawing.Color.Green;
            this.navigate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.navigate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigate_btn.Location = new System.Drawing.Point(916, 9);
            this.navigate_btn.Name = "navigate_btn";
            this.navigate_btn.Size = new System.Drawing.Size(75, 23);
            this.navigate_btn.TabIndex = 4;
            this.navigate_btn.Text = "Navigate";
            this.navigate_btn.UseVisualStyleBackColor = false;
            this.navigate_btn.Click += new System.EventHandler(this.Navigate_btn_Click);
            // 
            // search_bar
            // 
            this.search_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar.Location = new System.Drawing.Point(336, 9);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(574, 20);
            this.search_bar.TabIndex = 5;
            // 
            // da_browser
            // 
            this.da_browser.Location = new System.Drawing.Point(12, 38);
            this.da_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.da_browser.Name = "da_browser";
            this.da_browser.Size = new System.Drawing.Size(979, 664);
            this.da_browser.TabIndex = 6;
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.BackColor = System.Drawing.Color.Green;
            this.encrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_btn.Location = new System.Drawing.Point(69, 774);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(109, 48);
            this.encrypt_btn.TabIndex = 7;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = false;
            this.encrypt_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypt_btn.Location = new System.Drawing.Point(197, 774);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(109, 48);
            this.decrypt_btn.TabIndex = 8;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = false;
            this.decrypt_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // encrypt_label
            // 
            this.encrypt_label.AutoSize = true;
            this.encrypt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.encrypt_label.Location = new System.Drawing.Point(78, 705);
            this.encrypt_label.Name = "encrypt_label";
            this.encrypt_label.Size = new System.Drawing.Size(211, 20);
            this.encrypt_label.TabIndex = 9;
            this.encrypt_label.Text = "Encrypt and Decrypt Tool";
            // 
            // encrypt_field
            // 
            this.encrypt_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_field.Location = new System.Drawing.Point(13, 745);
            this.encrypt_field.Name = "encrypt_field";
            this.encrypt_field.Size = new System.Drawing.Size(358, 23);
            this.encrypt_field.TabIndex = 10;
            // 
            // result_field
            // 
            this.result_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_field.Location = new System.Drawing.Point(13, 830);
            this.result_field.Name = "result_field";
            this.result_field.Size = new System.Drawing.Size(358, 23);
            this.result_field.TabIndex = 11;
            // 
            // encrypt_outcome
            // 
            this.encrypt_outcome.AutoSize = true;
            this.encrypt_outcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_outcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.encrypt_outcome.Location = new System.Drawing.Point(160, 856);
            this.encrypt_outcome.Name = "encrypt_outcome";
            this.encrypt_outcome.Size = new System.Drawing.Size(48, 15);
            this.encrypt_outcome.TabIndex = 12;
            this.encrypt_outcome.Text = "Result";
            this.encrypt_outcome.Visible = false;
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stock_label.Location = new System.Drawing.Point(649, 705);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(165, 20);
            this.stock_label.TabIndex = 13;
            this.stock_label.Text = "Stock Checker Tool";
            // 
            // stock_field
            // 
            this.stock_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_field.Location = new System.Drawing.Point(643, 745);
            this.stock_field.Name = "stock_field";
            this.stock_field.Size = new System.Drawing.Size(182, 23);
            this.stock_field.TabIndex = 14;
            this.stock_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_stocks_btn
            // 
            this.check_stocks_btn.BackColor = System.Drawing.Color.Blue;
            this.check_stocks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_stocks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_stocks_btn.ForeColor = System.Drawing.Color.White;
            this.check_stocks_btn.Location = new System.Drawing.Point(665, 775);
            this.check_stocks_btn.Name = "check_stocks_btn";
            this.check_stocks_btn.Size = new System.Drawing.Size(145, 47);
            this.check_stocks_btn.TabIndex = 15;
            this.check_stocks_btn.Text = "Check Stock Price";
            this.check_stocks_btn.UseVisualStyleBackColor = false;
            this.check_stocks_btn.Click += new System.EventHandler(this.Check_stocks_btn_Click);
            // 
            // stock_result
            // 
            this.stock_result.AutoSize = true;
            this.stock_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_result.ForeColor = System.Drawing.Color.Blue;
            this.stock_result.Location = new System.Drawing.Point(684, 830);
            this.stock_result.Name = "stock_result";
            this.stock_result.Size = new System.Drawing.Size(54, 17);
            this.stock_result.TabIndex = 16;
            this.stock_result.Text = "Result";
            this.stock_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stock_result.Visible = false;
            // 
            // BrandonBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1003, 897);
            this.Controls.Add(this.stock_result);
            this.Controls.Add(this.check_stocks_btn);
            this.Controls.Add(this.stock_field);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.encrypt_outcome);
            this.Controls.Add(this.result_field);
            this.Controls.Add(this.encrypt_field);
            this.Controls.Add(this.encrypt_label);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.da_browser);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.navigate_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BrandonBrowser";
            this.Text = "Brandon\'s Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button navigate_btn;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.WebBrowser da_browser;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.TextBox encrypt_field;
        private System.Windows.Forms.TextBox result_field;
        private System.Windows.Forms.Label encrypt_outcome;
        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.TextBox stock_field;
        private System.Windows.Forms.Button check_stocks_btn;
        private System.Windows.Forms.Label stock_result;
    }
}

