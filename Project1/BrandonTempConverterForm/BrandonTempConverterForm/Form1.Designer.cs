namespace BrandonTempConverterForm
{
    partial class Form1
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
            this.c_to_f_field = new System.Windows.Forms.TextBox();
            this.f_to_c_field = new System.Windows.Forms.TextBox();
            this.c_to_f_btn = new System.Windows.Forms.Button();
            this.f_to_c_btn = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.c_to_f_result = new System.Windows.Forms.Label();
            this.f_to_c_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_to_f_field
            // 
            this.c_to_f_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_to_f_field.Location = new System.Drawing.Point(35, 71);
            this.c_to_f_field.Name = "c_to_f_field";
            this.c_to_f_field.Size = new System.Drawing.Size(100, 21);
            this.c_to_f_field.TabIndex = 0;
            this.c_to_f_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // f_to_c_field
            // 
            this.f_to_c_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_to_c_field.Location = new System.Drawing.Point(35, 136);
            this.f_to_c_field.Name = "f_to_c_field";
            this.f_to_c_field.Size = new System.Drawing.Size(100, 21);
            this.f_to_c_field.TabIndex = 1;
            this.f_to_c_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_to_f_btn
            // 
            this.c_to_f_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.c_to_f_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_to_f_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_to_f_btn.Location = new System.Drawing.Point(156, 68);
            this.c_to_f_btn.Name = "c_to_f_btn";
            this.c_to_f_btn.Size = new System.Drawing.Size(100, 29);
            this.c_to_f_btn.TabIndex = 2;
            this.c_to_f_btn.Text = "C to F";
            this.c_to_f_btn.UseVisualStyleBackColor = false;
            this.c_to_f_btn.Click += new System.EventHandler(this.C_to_f_btn_Click);
            // 
            // f_to_c_btn
            // 
            this.f_to_c_btn.BackColor = System.Drawing.Color.Blue;
            this.f_to_c_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f_to_c_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_to_c_btn.Location = new System.Drawing.Point(156, 133);
            this.f_to_c_btn.Name = "f_to_c_btn";
            this.f_to_c_btn.Size = new System.Drawing.Size(100, 29);
            this.f_to_c_btn.TabIndex = 3;
            this.f_to_c_btn.Text = "F to C";
            this.f_to_c_btn.UseVisualStyleBackColor = false;
            this.f_to_c_btn.Click += new System.EventHandler(this.F_to_c_btn_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.DarkViolet;
            this.header.Location = new System.Drawing.Point(141, 19);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(257, 26);
            this.header.TabIndex = 4;
            this.header.Text = "Temperature Converter";
            // 
            // c_to_f_result
            // 
            this.c_to_f_result.AutoSize = true;
            this.c_to_f_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_to_f_result.ForeColor = System.Drawing.Color.Green;
            this.c_to_f_result.Location = new System.Drawing.Point(274, 75);
            this.c_to_f_result.Name = "c_to_f_result";
            this.c_to_f_result.Size = new System.Drawing.Size(102, 17);
            this.c_to_f_result.TabIndex = 5;
            this.c_to_f_result.Text = "C to F Result";
            this.c_to_f_result.Visible = false;
            // 
            // f_to_c_result
            // 
            this.f_to_c_result.AutoSize = true;
            this.f_to_c_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_to_c_result.ForeColor = System.Drawing.Color.Blue;
            this.f_to_c_result.Location = new System.Drawing.Point(274, 140);
            this.f_to_c_result.Name = "f_to_c_result";
            this.f_to_c_result.Size = new System.Drawing.Size(102, 17);
            this.f_to_c_result.TabIndex = 6;
            this.f_to_c_result.Text = "F to C Result";
            this.f_to_c_result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(530, 224);
            this.Controls.Add(this.f_to_c_result);
            this.Controls.Add(this.c_to_f_result);
            this.Controls.Add(this.header);
            this.Controls.Add(this.f_to_c_btn);
            this.Controls.Add(this.c_to_f_btn);
            this.Controls.Add(this.f_to_c_field);
            this.Controls.Add(this.c_to_f_field);
            this.Name = "Form1";
            this.Text = "Brandon\'s Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c_to_f_field;
        private System.Windows.Forms.TextBox f_to_c_field;
        private System.Windows.Forms.Button c_to_f_btn;
        private System.Windows.Forms.Button f_to_c_btn;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label c_to_f_result;
        private System.Windows.Forms.Label f_to_c_result;
    }
}

