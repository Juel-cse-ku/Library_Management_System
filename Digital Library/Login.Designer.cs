namespace Digital_Library
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.User_name_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.User_name_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 80);
            this.panel1.TabIndex = 0;
            // 
            // User_name_label
            // 
            this.User_name_label.AutoSize = true;
            this.User_name_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_name_label.Location = new System.Drawing.Point(34, 124);
            this.User_name_label.Name = "User_name_label";
            this.User_name_label.Size = new System.Drawing.Size(97, 20);
            this.User_name_label.TabIndex = 1;
            this.User_name_label.Text = "User name";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(34, 158);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(86, 20);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // User_name_textBox
            // 
            this.User_name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_name_textBox.Location = new System.Drawing.Point(154, 126);
            this.User_name_textBox.Name = "User_name_textBox";
            this.User_name_textBox.Size = new System.Drawing.Size(185, 26);
            this.User_name_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(154, 158);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(185, 26);
            this.Password_textBox.TabIndex = 4;
            // 
            // Register_button
            // 
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.Location = new System.Drawing.Point(38, 201);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(141, 32);
            this.Register_button.TabIndex = 5;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(198, 201);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(141, 32);
            this.Login_button.TabIndex = 6;
            this.Login_button.Text = "Log in";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 286);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.User_name_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.User_name_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_form";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label User_name_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox User_name_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Login_button;
    }
}

