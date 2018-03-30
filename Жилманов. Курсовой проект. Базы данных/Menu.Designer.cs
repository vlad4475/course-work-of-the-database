namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class Menu
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
            this.b_Select = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Select
            // 
            this.b_Select.Location = new System.Drawing.Point(12, 12);
            this.b_Select.Name = "b_Select";
            this.b_Select.Size = new System.Drawing.Size(260, 52);
            this.b_Select.TabIndex = 0;
            this.b_Select.Text = "Просмотр";
            this.b_Select.UseVisualStyleBackColor = true;
            this.b_Select.Click += new System.EventHandler(this.b_Select_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(12, 71);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(260, 54);
            this.b_add.TabIndex = 1;
            this.b_add.Text = "Добавление";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запросы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_Select);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Select;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}