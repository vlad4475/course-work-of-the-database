namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddConference
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
            this.b_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Id = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Date = new System.Windows.Forms.TextBox();
            this.t_City = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(197, 227);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 23);
            this.b_Add.TabIndex = 0;
            this.b_Add.Text = "Добавить";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Город проведения";
            // 
            // t_Id
            // 
            this.t_Id.Location = new System.Drawing.Point(142, 13);
            this.t_Id.Name = "t_Id";
            this.t_Id.Size = new System.Drawing.Size(100, 20);
            this.t_Id.TabIndex = 5;
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(142, 40);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 20);
            this.t_Name.TabIndex = 6;
            // 
            // t_Date
            // 
            this.t_Date.Location = new System.Drawing.Point(142, 78);
            this.t_Date.Name = "t_Date";
            this.t_Date.Size = new System.Drawing.Size(100, 20);
            this.t_Date.TabIndex = 7;
            // 
            // t_City
            // 
            this.t_City.Location = new System.Drawing.Point(142, 111);
            this.t_City.Name = "t_City";
            this.t_City.Size = new System.Drawing.Size(100, 20);
            this.t_City.TabIndex = 8;
            // 
            // AddConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.t_City);
            this.Controls.Add(this.t_Date);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.t_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Add);
            this.Name = "AddConference";
            this.Text = "AddConference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_Id;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Date;
        private System.Windows.Forms.TextBox t_City;
    }
}