
namespace Wedding_Management
{
    partial class Form_DashBoard_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DashBoard_Reports));
            this.button_Most_Demmanding_Package = new System.Windows.Forms.Button();
            this.button_Least_Demmanding_Package = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Most_Demmanding_Package
            // 
            this.button_Most_Demmanding_Package.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Most_Demmanding_Package.Location = new System.Drawing.Point(22, 64);
            this.button_Most_Demmanding_Package.Name = "button_Most_Demmanding_Package";
            this.button_Most_Demmanding_Package.Size = new System.Drawing.Size(250, 71);
            this.button_Most_Demmanding_Package.TabIndex = 0;
            this.button_Most_Demmanding_Package.Text = "Most Demmanding Package";
            this.button_Most_Demmanding_Package.UseVisualStyleBackColor = true;
            this.button_Most_Demmanding_Package.Click += new System.EventHandler(this.button_Most_Demmanding_Package_Click);
            // 
            // button_Least_Demmanding_Package
            // 
            this.button_Least_Demmanding_Package.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Least_Demmanding_Package.Location = new System.Drawing.Point(22, 160);
            this.button_Least_Demmanding_Package.Name = "button_Least_Demmanding_Package";
            this.button_Least_Demmanding_Package.Size = new System.Drawing.Size(250, 71);
            this.button_Least_Demmanding_Package.TabIndex = 1;
            this.button_Least_Demmanding_Package.Text = "Least Demmanding Package";
            this.button_Least_Demmanding_Package.UseVisualStyleBackColor = true;
            this.button_Least_Demmanding_Package.Click += new System.EventHandler(this.button_Least_Demmanding_Package_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_DashBoard_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Least_Demmanding_Package);
            this.Controls.Add(this.button_Most_Demmanding_Package);
            this.Name = "Form_DashBoard_Reports";
            this.Text = "Form_DashBoard_Reports";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Most_Demmanding_Package;
        private System.Windows.Forms.Button button_Least_Demmanding_Package;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}