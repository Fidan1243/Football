
namespace WindowsFormsApp12
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Number = new System.Windows.Forms.Label();
            this.Namee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(41, 41);
            this.Number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(33, 46);
            this.Number.TabIndex = 0;
            this.Number.Text = "1";
            // 
            // Namee
            // 
            this.Namee.AutoSize = true;
            this.Namee.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namee.Location = new System.Drawing.Point(22, 18);
            this.Namee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(70, 31);
            this.Namee.TabIndex = 1;
            this.Namee.Text = "name";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WindowsFormsApp12.Properties.Resources._3_30172_small_blank_black_t_shirt_red_football_shirt__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Namee);
            this.Controls.Add(this.Number);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(112, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Number;
        public System.Windows.Forms.Label Namee;
    }
}
