namespace _8ball
{
    partial class AccessibleSetting
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
            this.Shaketoggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Shaketoggle
            // 
            this.Shaketoggle.AutoSize = true;
            this.Shaketoggle.Location = new System.Drawing.Point(14, 12);
            this.Shaketoggle.Name = "Shaketoggle";
            this.Shaketoggle.Size = new System.Drawing.Size(103, 17);
            this.Shaketoggle.TabIndex = 0;
            this.Shaketoggle.Text = "Disable Shaking";
            this.Shaketoggle.UseVisualStyleBackColor = true;
            this.Shaketoggle.CheckedChanged += new System.EventHandler(this.Shaketoggle_CheckedChanged);
            // 
            // AccessibleSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 39);
            this.Controls.Add(this.Shaketoggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessibleSetting";
            this.Text = "Accessible Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Shaketoggle;
    }
}