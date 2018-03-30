namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddAdviser
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
            this.b_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_Id = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_phone = new System.Windows.Forms.TextBox();
            this.c_sex = new System.Windows.Forms.ComboBox();
            this.c_dep = new System.Windows.Forms.ComboBox();
            this.c_scie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(197, 227);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
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
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
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
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кафедра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Научная группа";
            // 
            // t_Id
            // 
            this.t_Id.Location = new System.Drawing.Point(109, 13);
            this.t_Id.Name = "t_Id";
            this.t_Id.Size = new System.Drawing.Size(100, 20);
            this.t_Id.TabIndex = 7;
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(109, 39);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 20);
            this.t_Name.TabIndex = 8;
            // 
            // t_phone
            // 
            this.t_phone.Location = new System.Drawing.Point(109, 62);
            this.t_phone.Name = "t_phone";
            this.t_phone.Size = new System.Drawing.Size(100, 20);
            this.t_phone.TabIndex = 9;
            // 
            // c_sex
            // 
            this.c_sex.FormattingEnabled = true;
            this.c_sex.Location = new System.Drawing.Point(109, 100);
            this.c_sex.Name = "c_sex";
            this.c_sex.Size = new System.Drawing.Size(121, 21);
            this.c_sex.TabIndex = 10;
            // 
            // c_dep
            // 
            this.c_dep.FormattingEnabled = true;
            this.c_dep.Location = new System.Drawing.Point(109, 127);
            this.c_dep.Name = "c_dep";
            this.c_dep.Size = new System.Drawing.Size(121, 21);
            this.c_dep.TabIndex = 11;
            // 
            // c_scie
            // 
            this.c_scie.FormattingEnabled = true;
            this.c_scie.Location = new System.Drawing.Point(109, 154);
            this.c_scie.Name = "c_scie";
            this.c_scie.Size = new System.Drawing.Size(121, 21);
            this.c_scie.TabIndex = 12;
            // 
            // AddAdviser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.c_scie);
            this.Controls.Add(this.c_dep);
            this.Controls.Add(this.c_sex);
            this.Controls.Add(this.t_phone);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.t_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_add);
            this.Name = "AddAdviser";
            this.Text = "AddAdviser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_Id;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_phone;
        private System.Windows.Forms.ComboBox c_sex;
        private System.Windows.Forms.ComboBox c_dep;
        private System.Windows.Forms.ComboBox c_scie;
    }
}