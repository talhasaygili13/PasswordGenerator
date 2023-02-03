namespace PasswordGenerator
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
            this.passwordSix = new System.Windows.Forms.Button();
            this.passwordEight = new System.Windows.Forms.Button();
            this.passTwelve = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordSix
            // 
            this.passwordSix.Location = new System.Drawing.Point(161, 301);
            this.passwordSix.Name = "passwordSix";
            this.passwordSix.Size = new System.Drawing.Size(79, 57);
            this.passwordSix.TabIndex = 0;
            this.passwordSix.Text = "6 ";
            this.passwordSix.UseVisualStyleBackColor = true;
            this.passwordSix.Click += new System.EventHandler(this.passwordSix_Click);
            // 
            // passwordEight
            // 
            this.passwordEight.Location = new System.Drawing.Point(289, 301);
            this.passwordEight.Name = "passwordEight";
            this.passwordEight.Size = new System.Drawing.Size(79, 57);
            this.passwordEight.TabIndex = 1;
            this.passwordEight.Text = "8";
            this.passwordEight.UseVisualStyleBackColor = true;
            this.passwordEight.Click += new System.EventHandler(this.passwordEight_Click);
            // 
            // passTwelve
            // 
            this.passTwelve.Location = new System.Drawing.Point(419, 301);
            this.passTwelve.Name = "passTwelve";
            this.passTwelve.Size = new System.Drawing.Size(79, 57);
            this.passTwelve.TabIndex = 2;
            this.passTwelve.Text = "12";
            this.passTwelve.UseVisualStyleBackColor = true;
            this.passTwelve.Click += new System.EventHandler(this.passTwelve_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(12, 256);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(368, 24);
            this.Info.TabIndex = 3;
            this.Info.Text = "Please select a number on the buttons";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(122, 102);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(408, 34);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PasswordGenerator.Properties.Resources.backgrounf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.passTwelve);
            this.Controls.Add(this.passwordEight);
            this.Controls.Add(this.passwordSix);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Genartor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passwordSix;
        private System.Windows.Forms.Button passwordEight;
        private System.Windows.Forms.Button passTwelve;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TextBox password;
    }
}

