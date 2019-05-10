namespace ProjectLists
{
    partial class Nec
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
            this.Shd1 = new System.Windows.Forms.Label();
            this.Shd2 = new System.Windows.Forms.Label();
            this.Shd3 = new System.Windows.Forms.Label();
            this.Shd4 = new System.Windows.Forms.Label();
            this.Shd5 = new System.Windows.Forms.Label();
            this.Shd6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shd1
            // 
            this.Shd1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Shd1.Location = new System.Drawing.Point(12, 33);
            this.Shd1.Name = "Shd1";
            this.Shd1.Size = new System.Drawing.Size(232, 220);
            this.Shd1.TabIndex = 3;
            this.Shd1.Text = "Понедельник";
            this.Shd1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Shd2
            // 
            this.Shd2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Shd2.Location = new System.Drawing.Point(315, 33);
            this.Shd2.Name = "Shd2";
            this.Shd2.Size = new System.Drawing.Size(232, 220);
            this.Shd2.TabIndex = 4;
            this.Shd2.Text = "Вторник";
            this.Shd2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Shd3
            // 
            this.Shd3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Shd3.Location = new System.Drawing.Point(603, 33);
            this.Shd3.Name = "Shd3";
            this.Shd3.Size = new System.Drawing.Size(228, 220);
            this.Shd3.TabIndex = 5;
            this.Shd3.Text = "Среда";
            this.Shd3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Shd4
            // 
            this.Shd4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Shd4.Location = new System.Drawing.Point(913, 33);
            this.Shd4.Name = "Shd4";
            this.Shd4.Size = new System.Drawing.Size(227, 220);
            this.Shd4.TabIndex = 6;
            this.Shd4.Text = "Четверг";
            // 
            // Shd5
            // 
            this.Shd5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Shd5.Location = new System.Drawing.Point(7, 342);
            this.Shd5.Name = "Shd5";
            this.Shd5.Size = new System.Drawing.Size(237, 220);
            this.Shd5.TabIndex = 7;
            this.Shd5.Text = "Пятница";
            // 
            // Shd6
            // 
            this.Shd6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Shd6.Location = new System.Drawing.Point(315, 342);
            this.Shd6.Name = "Shd6";
            this.Shd6.Size = new System.Drawing.Size(230, 220);
            this.Shd6.TabIndex = 8;
            this.Shd6.Text = "Суббота";
            // 
            // Nec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 740);
            this.Controls.Add(this.Shd6);
            this.Controls.Add(this.Shd5);
            this.Controls.Add(this.Shd4);
            this.Controls.Add(this.Shd3);
            this.Controls.Add(this.Shd2);
            this.Controls.Add(this.Shd1);
            this.Name = "Nec";
            this.Text = "Nec";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Shd1;
        private System.Windows.Forms.Label Shd2;
        private System.Windows.Forms.Label Shd3;
        private System.Windows.Forms.Label Shd4;
        private System.Windows.Forms.Label Shd5;
        private System.Windows.Forms.Label Shd6;
    }
}