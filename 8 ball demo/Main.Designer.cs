namespace _8ball
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Answerb = new System.Windows.Forms.Button();
            this.Questionbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoCredbutton = new System.Windows.Forms.Button();
            this.Access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Answerb
            // 
            this.Answerb.Location = new System.Drawing.Point(105, 49);
            this.Answerb.Name = "Answerb";
            this.Answerb.Size = new System.Drawing.Size(80, 28);
            this.Answerb.TabIndex = 0;
            this.Answerb.Text = "Answer!";
            this.Answerb.UseVisualStyleBackColor = true;
            this.Answerb.Click += new System.EventHandler(this.Answerb_Click);
            // 
            // Questionbox
            // 
            this.Questionbox.AcceptsReturn = true;
            this.Questionbox.Location = new System.Drawing.Point(12, 25);
            this.Questionbox.Name = "Questionbox";
            this.Questionbox.Size = new System.Drawing.Size(268, 20);
            this.Questionbox.TabIndex = 1;
            this.Questionbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Questionbox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Just ask, and the Magic 8 Ball shall answer...";
            // 
            // InfoCredbutton
            // 
            this.InfoCredbutton.Location = new System.Drawing.Point(200, 49);
            this.InfoCredbutton.Name = "InfoCredbutton";
            this.InfoCredbutton.Size = new System.Drawing.Size(80, 28);
            this.InfoCredbutton.TabIndex = 3;
            this.InfoCredbutton.Text = "About/Credits";
            this.InfoCredbutton.UseVisualStyleBackColor = true;
            this.InfoCredbutton.Click += new System.EventHandler(this.InfoCredbutton_Click);
            // 
            // Access
            // 
            this.Access.Location = new System.Drawing.Point(12, 49);
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(80, 28);
            this.Access.TabIndex = 4;
            this.Access.Text = "Accessibility";
            this.Access.UseVisualStyleBackColor = true;
            this.Access.Click += new System.EventHandler(this.Access_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 89);
            this.Controls.Add(this.Access);
            this.Controls.Add(this.InfoCredbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Questionbox);
            this.Controls.Add(this.Answerb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Magic 8 Ball Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Answerb;
        private System.Windows.Forms.TextBox Questionbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InfoCredbutton;
        private System.Windows.Forms.Button Access;
    }
}

