namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddPublication
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Id = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Date = new System.Windows.Forms.TextBox();
            this.t_teme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c_advis = new System.Windows.Forms.ComboBox();
            this.c_grad = new System.Windows.Forms.ComboBox();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // t_Id
            // 
            this.t_Id.Location = new System.Drawing.Point(141, 9);
            this.t_Id.Name = "t_Id";
            this.t_Id.Size = new System.Drawing.Size(100, 20);
            this.t_Id.TabIndex = 13;
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(141, 36);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 20);
            this.t_Name.TabIndex = 14;
            // 
            // t_Date
            // 
            this.t_Date.Location = new System.Drawing.Point(141, 74);
            this.t_Date.Name = "t_Date";
            this.t_Date.Size = new System.Drawing.Size(100, 20);
            this.t_Date.TabIndex = 15;
            // 
            // t_teme
            // 
            this.t_teme.Location = new System.Drawing.Point(141, 107);
            this.t_teme.Name = "t_teme";
            this.t_teme.Size = new System.Drawing.Size(100, 20);
            this.t_teme.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Руководитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Аспирант";
            // 
            // c_advis
            // 
            this.c_advis.FormattingEnabled = true;
            this.c_advis.Location = new System.Drawing.Point(141, 142);
            this.c_advis.Name = "c_advis";
            this.c_advis.Size = new System.Drawing.Size(121, 21);
            this.c_advis.TabIndex = 19;
            // 
            // c_grad
            // 
            this.c_grad.FormattingEnabled = true;
            this.c_grad.Location = new System.Drawing.Point(141, 177);
            this.c_grad.Name = "c_grad";
            this.c_grad.Size = new System.Drawing.Size(121, 21);
            this.c_grad.TabIndex = 20;
            // 
            // Publication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.c_grad);
            this.Controls.Add(this.c_advis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_teme);
            this.Controls.Add(this.t_Date);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.t_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_add);
            this.Name = "Publication";
            this.Text = "Publication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Id;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Date;
        private System.Windows.Forms.TextBox t_teme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox c_advis;
        private System.Windows.Forms.ComboBox c_grad;
    }
}