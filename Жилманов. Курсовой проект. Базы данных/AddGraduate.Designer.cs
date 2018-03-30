namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddGraduate
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Phone = new System.Windows.Forms.TextBox();
            this.t_year = new System.Windows.Forms.TextBox();
            this.c_sex = new System.Windows.Forms.ComboBox();
            this.c_advis = new System.Windows.Forms.ComboBox();
            this.c_scei = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фио";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Год поступления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Научный руководитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Научная группа";
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(149, 13);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(100, 20);
            this.t_id.TabIndex = 8;
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(149, 40);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 20);
            this.t_Name.TabIndex = 9;
            // 
            // t_Phone
            // 
            this.t_Phone.Location = new System.Drawing.Point(149, 66);
            this.t_Phone.Name = "t_Phone";
            this.t_Phone.Size = new System.Drawing.Size(100, 20);
            this.t_Phone.TabIndex = 10;
            // 
            // t_year
            // 
            this.t_year.Location = new System.Drawing.Point(149, 92);
            this.t_year.Name = "t_year";
            this.t_year.Size = new System.Drawing.Size(100, 20);
            this.t_year.TabIndex = 11;
            // 
            // c_sex
            // 
            this.c_sex.FormattingEnabled = true;
            this.c_sex.Location = new System.Drawing.Point(149, 125);
            this.c_sex.Name = "c_sex";
            this.c_sex.Size = new System.Drawing.Size(121, 21);
            this.c_sex.TabIndex = 12;
            // 
            // c_advis
            // 
            this.c_advis.FormattingEnabled = true;
            this.c_advis.Location = new System.Drawing.Point(149, 150);
            this.c_advis.Name = "c_advis";
            this.c_advis.Size = new System.Drawing.Size(121, 21);
            this.c_advis.TabIndex = 13;
            // 
            // c_scei
            // 
            this.c_scei.FormattingEnabled = true;
            this.c_scei.Location = new System.Drawing.Point(149, 174);
            this.c_scei.Name = "c_scei";
            this.c_scei.Size = new System.Drawing.Size(121, 21);
            this.c_scei.TabIndex = 14;
            // 
            // AddGraduate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.c_scei);
            this.Controls.Add(this.c_advis);
            this.Controls.Add(this.c_sex);
            this.Controls.Add(this.t_year);
            this.Controls.Add(this.t_Phone);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Add);
            this.Name = "AddGraduate";
            this.Text = "AddGraduate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Phone;
        private System.Windows.Forms.TextBox t_year;
        private System.Windows.Forms.ComboBox c_sex;
        private System.Windows.Forms.ComboBox c_advis;
        private System.Windows.Forms.ComboBox c_scei;
    }
}