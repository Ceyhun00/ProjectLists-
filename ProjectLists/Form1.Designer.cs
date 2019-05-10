namespace ProjectLists
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rasp = new System.Windows.Forms.Button();
            this.HomeWork = new System.Windows.Forms.Button();
            this.Links = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Button();
            this.Control = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rasp
            // 
            this.Rasp.Location = new System.Drawing.Point(69, 30);
            this.Rasp.Name = "Rasp";
            this.Rasp.Size = new System.Drawing.Size(129, 44);
            this.Rasp.TabIndex = 1;
            this.Rasp.Text = "Расписание";
            this.Rasp.UseVisualStyleBackColor = true;
            this.Rasp.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeWork
            // 
            this.HomeWork.Location = new System.Drawing.Point(261, 30);
            this.HomeWork.Name = "HomeWork";
            this.HomeWork.Size = new System.Drawing.Size(104, 44);
            this.HomeWork.TabIndex = 2;
            this.HomeWork.Text = "Д/З";
            this.HomeWork.UseVisualStyleBackColor = true;
            this.HomeWork.Click += new System.EventHandler(this.button2_Click);
            // 
            // Links
            // 
            this.Links.Location = new System.Drawing.Point(585, 30);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(104, 44);
            this.Links.TabIndex = 4;
            this.Links.Text = "Полезные Ссылки";
            this.Links.UseVisualStyleBackColor = true;
            this.Links.Click += new System.EventHandler(this.Links_Click);
            // 
            // Books
            // 
            this.Books.Location = new System.Drawing.Point(443, 30);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(104, 44);
            this.Books.TabIndex = 5;
            this.Books.Text = "Учебники";
            this.Books.UseVisualStyleBackColor = true;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // Control
            // 
            this.Control.Location = new System.Drawing.Point(69, 128);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(129, 44);
            this.Control.TabIndex = 6;
            this.Control.Text = "К/Р";
            this.Control.UseVisualStyleBackColor = true;
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 587);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.HomeWork);
            this.Controls.Add(this.Rasp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Rasp;
        private System.Windows.Forms.Button HomeWork;
        private System.Windows.Forms.Button Links;
        private System.Windows.Forms.Button Books;
        private System.Windows.Forms.Button Control;
    }
}

