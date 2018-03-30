namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddStud
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
            this.c_sex = new System.Windows.Forms.ComboBox();
            this.t_Phone = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_dep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // c_sex
            // 
            this.c_sex.FormattingEnabled = true;
            this.c_sex.Location = new System.Drawing.Point(145, 85);
            this.c_sex.Name = "c_sex";
            this.c_sex.Size = new System.Drawing.Size(121, 21);
            this.c_sex.TabIndex = 22;
            // 
            // t_Phone
            // 
            this.t_Phone.Location = new System.Drawing.Point(145, 59);
            this.t_Phone.Name = "t_Phone";
            this.t_Phone.Size = new System.Drawing.Size(100, 20);
            this.t_Phone.TabIndex = 20;
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(145, 33);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 20);
            this.t_Name.TabIndex = 19;
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(145, 6);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(100, 20);
            this.t_id.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фио";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            // 
            // c_dep
            // 
            this.c_dep.FormattingEnabled = true;
            this.c_dep.Location = new System.Drawing.Point(148, 121);
            this.c_dep.Name = "c_dep";
            this.c_dep.Size = new System.Drawing.Size(121, 21);
            this.c_dep.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Кафедра";
            // 
            // AddStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.c_dep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c_sex);
            this.Controls.Add(this.t_Phone);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_add);
            this.Name = "AddStud";
            this.Text = "AddStud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.ComboBox c_sex;
        private System.Windows.Forms.TextBox t_Phone;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_dep;
        private System.Windows.Forms.Label label4;
    }
}