namespace FizzBuzz
{
    partial class FizzBuzz
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
            this.lsbFizzBuzz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbFizzBuzz
            // 
            this.lsbFizzBuzz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbFizzBuzz.FormattingEnabled = true;
            this.lsbFizzBuzz.Location = new System.Drawing.Point(0, 0);
            this.lsbFizzBuzz.Margin = new System.Windows.Forms.Padding(2);
            this.lsbFizzBuzz.Name = "lsbFizzBuzz";
            this.lsbFizzBuzz.ScrollAlwaysVisible = true;
            this.lsbFizzBuzz.Size = new System.Drawing.Size(245, 370);
            this.lsbFizzBuzz.TabIndex = 1;
            // 
            // FizzBuzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 370);
            this.Controls.Add(this.lsbFizzBuzz);
            this.Name = "FizzBuzz";
            this.Text = "FizzBuzz";
            this.Load += new System.EventHandler(this.FizzBuzz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFizzBuzz;
    }
}

