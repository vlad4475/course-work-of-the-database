namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class Список_учасников_конференций
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_theme = new System.Windows.Forms.CheckBox();
            this.cb_year = new System.Windows.Forms.CheckBox();
            this.cb_adv = new System.Windows.Forms.CheckBox();
            this.t_theme = new System.Windows.Forms.TextBox();
            this.t_startYear = new System.Windows.Forms.TextBox();
            this.t_endYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c_adv = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тематика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Годы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Руководитель";
            // 
            // cb_theme
            // 
            this.cb_theme.AutoSize = true;
            this.cb_theme.Location = new System.Drawing.Point(13, 9);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(15, 14);
            this.cb_theme.TabIndex = 3;
            this.cb_theme.UseVisualStyleBackColor = true;
            // 
            // cb_year
            // 
            this.cb_year.AutoSize = true;
            this.cb_year.Location = new System.Drawing.Point(13, 38);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(15, 14);
            this.cb_year.TabIndex = 4;
            this.cb_year.UseVisualStyleBackColor = true;
            // 
            // cb_adv
            // 
            this.cb_adv.AutoSize = true;
            this.cb_adv.Location = new System.Drawing.Point(12, 66);
            this.cb_adv.Name = "cb_adv";
            this.cb_adv.Size = new System.Drawing.Size(15, 14);
            this.cb_adv.TabIndex = 5;
            this.cb_adv.UseVisualStyleBackColor = true;
            // 
            // t_theme
            // 
            this.t_theme.Location = new System.Drawing.Point(97, 9);
            this.t_theme.Name = "t_theme";
            this.t_theme.Size = new System.Drawing.Size(100, 20);
            this.t_theme.TabIndex = 6;
            // 
            // t_startYear
            // 
            this.t_startYear.Location = new System.Drawing.Point(118, 37);
            this.t_startYear.Name = "t_startYear";
            this.t_startYear.Size = new System.Drawing.Size(100, 20);
            this.t_startYear.TabIndex = 7;
            // 
            // t_endYear
            // 
            this.t_endYear.Location = new System.Drawing.Point(239, 36);
            this.t_endYear.Name = "t_endYear";
            this.t_endYear.Size = new System.Drawing.Size(100, 20);
            this.t_endYear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " C: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "По: ";
            // 
            // c_adv
            // 
            this.c_adv.FormattingEnabled = true;
            this.c_adv.Location = new System.Drawing.Point(118, 63);
            this.c_adv.Name = "c_adv";
            this.c_adv.Size = new System.Drawing.Size(121, 21);
            this.c_adv.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(614, 260);
            this.dataGridView1.TabIndex = 12;
            // 
            // b_select
            // 
            this.b_select.Location = new System.Drawing.Point(385, 7);
            this.b_select.Name = "b_select";
            this.b_select.Size = new System.Drawing.Size(242, 72);
            this.b_select.TabIndex = 13;
            this.b_select.Text = "Вывести";
            this.b_select.UseVisualStyleBackColor = true;
            this.b_select.Click += new System.EventHandler(this.b_select_Click);
            // 
            // Список_учасников_конференций
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 390);
            this.Controls.Add(this.b_select);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.c_adv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_endYear);
            this.Controls.Add(this.t_startYear);
            this.Controls.Add(this.t_theme);
            this.Controls.Add(this.cb_adv);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.cb_theme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Список_учасников_конференций";
            this.Text = "Список_учасников_конференций";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_theme;
        private System.Windows.Forms.CheckBox cb_year;
        private System.Windows.Forms.CheckBox cb_adv;
        private System.Windows.Forms.TextBox t_theme;
        private System.Windows.Forms.TextBox t_startYear;
        private System.Windows.Forms.TextBox t_endYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox c_adv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_select;
    }
}