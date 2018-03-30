namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddSpeech
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
            this.t_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_teme = new System.Windows.Forms.TextBox();
            this.t_date = new System.Windows.Forms.TextBox();
            this.c_grad = new System.Windows.Forms.ComboBox();
            this.c_conf = new System.Windows.Forms.ComboBox();
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
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(147, 13);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(100, 20);
            this.t_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тема";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Аспирант";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Конференция";
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(147, 42);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(100, 20);
            this.t_name.TabIndex = 8;
            // 
            // t_teme
            // 
            this.t_teme.Location = new System.Drawing.Point(147, 69);
            this.t_teme.Name = "t_teme";
            this.t_teme.Size = new System.Drawing.Size(100, 20);
            this.t_teme.TabIndex = 9;
            // 
            // t_date
            // 
            this.t_date.Location = new System.Drawing.Point(147, 101);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(100, 20);
            this.t_date.TabIndex = 10;
            // 
            // c_grad
            // 
            this.c_grad.FormattingEnabled = true;
            this.c_grad.Location = new System.Drawing.Point(147, 127);
            this.c_grad.Name = "c_grad";
            this.c_grad.Size = new System.Drawing.Size(121, 21);
            this.c_grad.TabIndex = 11;
            // 
            // c_conf
            // 
            this.c_conf.FormattingEnabled = true;
            this.c_conf.Location = new System.Drawing.Point(147, 162);
            this.c_conf.Name = "c_conf";
            this.c_conf.Size = new System.Drawing.Size(121, 21);
            this.c_conf.TabIndex = 12;
            // 
            // AddSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.c_conf);
            this.Controls.Add(this.c_grad);
            this.Controls.Add(this.t_date);
            this.Controls.Add(this.t_teme);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.b_Add);
            this.Name = "AddSpeech";
            this.Text = "AddSpeech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_teme;
        private System.Windows.Forms.TextBox t_date;
        private System.Windows.Forms.ComboBox c_grad;
        private System.Windows.Forms.ComboBox c_conf;
    }
}