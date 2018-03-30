namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class Аспиранты_по_годам_обучения
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
            this.t_startYear = new System.Windows.Forms.TextBox();
            this.t_endYear = new System.Windows.Forms.TextBox();
            this.b_select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "По";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Показать аспирантов, чей год обучения:";
            // 
            // t_startYear
            // 
            this.t_startYear.Location = new System.Drawing.Point(39, 36);
            this.t_startYear.Name = "t_startYear";
            this.t_startYear.Size = new System.Drawing.Size(100, 20);
            this.t_startYear.TabIndex = 3;
            // 
            // t_endYear
            // 
            this.t_endYear.Location = new System.Drawing.Point(39, 70);
            this.t_endYear.Name = "t_endYear";
            this.t_endYear.Size = new System.Drawing.Size(100, 20);
            this.t_endYear.TabIndex = 4;
            // 
            // b_select
            // 
            this.b_select.Location = new System.Drawing.Point(13, 104);
            this.b_select.Name = "b_select";
            this.b_select.Size = new System.Drawing.Size(75, 23);
            this.b_select.TabIndex = 5;
            this.b_select.Text = "Показать";
            this.b_select.UseVisualStyleBackColor = true;
            this.b_select.Click += new System.EventHandler(this.b_select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // Аспиранты_по_годам_обучения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_select);
            this.Controls.Add(this.t_endYear);
            this.Controls.Add(this.t_startYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Аспиранты_по_годам_обучения";
            this.Text = "Аспиранты_по_годам_обучения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_startYear;
        private System.Windows.Forms.TextBox t_endYear;
        private System.Windows.Forms.Button b_select;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}