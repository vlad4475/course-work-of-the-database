namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class Запросы
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
            this.b_gradByYears = new System.Windows.Forms.Button();
            this.b_gradByAdv = new System.Windows.Forms.Button();
            this.b_GradByYear = new System.Windows.Forms.Button();
            this.b_publisher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_gradByYears
            // 
            this.b_gradByYears.Location = new System.Drawing.Point(13, 13);
            this.b_gradByYears.Name = "b_gradByYears";
            this.b_gradByYears.Size = new System.Drawing.Size(259, 23);
            this.b_gradByYears.TabIndex = 0;
            this.b_gradByYears.Text = "Аспиранты по годам обучения";
            this.b_gradByYears.UseVisualStyleBackColor = true;
            this.b_gradByYears.Click += new System.EventHandler(this.b_gradByYears_Click);
            // 
            // b_gradByAdv
            // 
            this.b_gradByAdv.Location = new System.Drawing.Point(13, 43);
            this.b_gradByAdv.Name = "b_gradByAdv";
            this.b_gradByAdv.Size = new System.Drawing.Size(259, 23);
            this.b_gradByAdv.TabIndex = 1;
            this.b_gradByAdv.Text = "Аспиранты у руководителя";
            this.b_gradByAdv.UseVisualStyleBackColor = true;
            this.b_gradByAdv.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_GradByYear
            // 
            this.b_GradByYear.Location = new System.Drawing.Point(13, 73);
            this.b_GradByYear.Name = "b_GradByYear";
            this.b_GradByYear.Size = new System.Drawing.Size(259, 23);
            this.b_GradByYear.TabIndex = 2;
            this.b_GradByYear.Text = "Аспиранты по годом обучения";
            this.b_GradByYear.UseVisualStyleBackColor = true;
            this.b_GradByYear.Click += new System.EventHandler(this.b_GradByYear_Click);
            // 
            // b_publisher
            // 
            this.b_publisher.Location = new System.Drawing.Point(13, 103);
            this.b_publisher.Name = "b_publisher";
            this.b_publisher.Size = new System.Drawing.Size(259, 23);
            this.b_publisher.TabIndex = 3;
            this.b_publisher.Text = "Учёт публикаций студента";
            this.b_publisher.UseVisualStyleBackColor = true;
            this.b_publisher.Click += new System.EventHandler(this.b_publisher_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Учёт публикаций преподавателя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Список участников конференций";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Запросы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_publisher);
            this.Controls.Add(this.b_GradByYear);
            this.Controls.Add(this.b_gradByAdv);
            this.Controls.Add(this.b_gradByYears);
            this.Name = "Запросы";
            this.Text = "Запросы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_gradByYears;
        private System.Windows.Forms.Button b_gradByAdv;
        private System.Windows.Forms.Button b_GradByYear;
        private System.Windows.Forms.Button b_publisher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}