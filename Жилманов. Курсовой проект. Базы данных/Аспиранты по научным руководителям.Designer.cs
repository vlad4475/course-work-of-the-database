namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class Аспиранты_по_научным_руководителям
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
            this.c_NameAdvis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c_NameAdvis
            // 
            this.c_NameAdvis.FormattingEnabled = true;
            this.c_NameAdvis.Location = new System.Drawing.Point(136, 10);
            this.c_NameAdvis.Name = "c_NameAdvis";
            this.c_NameAdvis.Size = new System.Drawing.Size(121, 21);
            this.c_NameAdvis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО руководителя";
            // 
            // t_Select
            // 
            this.t_Select.Location = new System.Drawing.Point(276, 8);
            this.t_Select.Name = "t_Select";
            this.t_Select.Size = new System.Drawing.Size(86, 23);
            this.t_Select.TabIndex = 2;
            this.t_Select.Text = "Показать";
            this.t_Select.UseVisualStyleBackColor = true;
            this.t_Select.Click += new System.EventHandler(this.t_Select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 237);
            this.dataGridView1.TabIndex = 3;
            // 
            // Аспиранты_по_научным_руководителям
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_Select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_NameAdvis);
            this.Name = "Аспиранты_по_научным_руководителям";
            this.Text = "Аспиранты_по_научным_руководителям";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox c_NameAdvis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button t_Select;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}