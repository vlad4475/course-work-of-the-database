namespace Жилманов.Курсовой_проект.Базы_данных
{
    partial class AddPanel
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
            this.b_addScientificGroup = new System.Windows.Forms.Button();
            this.b_addDepartment = new System.Windows.Forms.Button();
            this.b_addAdviser = new System.Windows.Forms.Button();
            this.b_addGrad = new System.Windows.Forms.Button();
            this.b_addConf = new System.Windows.Forms.Button();
            this.b_addSpeech = new System.Windows.Forms.Button();
            this.b_addPubl = new System.Windows.Forms.Button();
            this.b_addStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_addScientificGroup
            // 
            this.b_addScientificGroup.Location = new System.Drawing.Point(12, 12);
            this.b_addScientificGroup.Name = "b_addScientificGroup";
            this.b_addScientificGroup.Size = new System.Drawing.Size(192, 23);
            this.b_addScientificGroup.TabIndex = 0;
            this.b_addScientificGroup.Text = "Добавить науч. группу";
            this.b_addScientificGroup.UseVisualStyleBackColor = true;
            this.b_addScientificGroup.Click += new System.EventHandler(this.b_addScientificGroup_Click);
            // 
            // b_addDepartment
            // 
            this.b_addDepartment.Location = new System.Drawing.Point(13, 42);
            this.b_addDepartment.Name = "b_addDepartment";
            this.b_addDepartment.Size = new System.Drawing.Size(191, 23);
            this.b_addDepartment.TabIndex = 1;
            this.b_addDepartment.Text = "Добавить кафедру";
            this.b_addDepartment.UseVisualStyleBackColor = true;
            this.b_addDepartment.Click += new System.EventHandler(this.b_addDepartment_Click);
            // 
            // b_addAdviser
            // 
            this.b_addAdviser.Location = new System.Drawing.Point(13, 72);
            this.b_addAdviser.Name = "b_addAdviser";
            this.b_addAdviser.Size = new System.Drawing.Size(191, 23);
            this.b_addAdviser.TabIndex = 2;
            this.b_addAdviser.Text = "Добавить научного руководителя";
            this.b_addAdviser.UseVisualStyleBackColor = true;
            this.b_addAdviser.Click += new System.EventHandler(this.b_addAdviser_Click);
            // 
            // b_addGrad
            // 
            this.b_addGrad.Location = new System.Drawing.Point(13, 102);
            this.b_addGrad.Name = "b_addGrad";
            this.b_addGrad.Size = new System.Drawing.Size(191, 23);
            this.b_addGrad.TabIndex = 3;
            this.b_addGrad.Text = "Добавить аспиранта";
            this.b_addGrad.UseVisualStyleBackColor = true;
            this.b_addGrad.Click += new System.EventHandler(this.b_addGrad_Click);
            // 
            // b_addConf
            // 
            this.b_addConf.Location = new System.Drawing.Point(13, 132);
            this.b_addConf.Name = "b_addConf";
            this.b_addConf.Size = new System.Drawing.Size(191, 23);
            this.b_addConf.TabIndex = 4;
            this.b_addConf.Text = "Добавить конференцию";
            this.b_addConf.UseVisualStyleBackColor = true;
            this.b_addConf.Click += new System.EventHandler(this.b_addConf_Click);
            // 
            // b_addSpeech
            // 
            this.b_addSpeech.Location = new System.Drawing.Point(13, 162);
            this.b_addSpeech.Name = "b_addSpeech";
            this.b_addSpeech.Size = new System.Drawing.Size(191, 23);
            this.b_addSpeech.TabIndex = 5;
            this.b_addSpeech.Text = "Добавить выступление";
            this.b_addSpeech.UseVisualStyleBackColor = true;
            this.b_addSpeech.Click += new System.EventHandler(this.b_addSpeech_Click);
            // 
            // b_addPubl
            // 
            this.b_addPubl.Location = new System.Drawing.Point(13, 192);
            this.b_addPubl.Name = "b_addPubl";
            this.b_addPubl.Size = new System.Drawing.Size(191, 23);
            this.b_addPubl.TabIndex = 6;
            this.b_addPubl.Text = "Добавить публикацию";
            this.b_addPubl.UseVisualStyleBackColor = true;
            this.b_addPubl.Click += new System.EventHandler(this.b_addPubl_Click);
            // 
            // b_addStud
            // 
            this.b_addStud.Location = new System.Drawing.Point(13, 222);
            this.b_addStud.Name = "b_addStud";
            this.b_addStud.Size = new System.Drawing.Size(191, 23);
            this.b_addStud.TabIndex = 7;
            this.b_addStud.Text = "Добавить студента";
            this.b_addStud.UseVisualStyleBackColor = true;
            this.b_addStud.Click += new System.EventHandler(this.b_addStud_Click);
            // 
            // AddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 255);
            this.Controls.Add(this.b_addStud);
            this.Controls.Add(this.b_addPubl);
            this.Controls.Add(this.b_addSpeech);
            this.Controls.Add(this.b_addConf);
            this.Controls.Add(this.b_addGrad);
            this.Controls.Add(this.b_addAdviser);
            this.Controls.Add(this.b_addDepartment);
            this.Controls.Add(this.b_addScientificGroup);
            this.Name = "AddPanel";
            this.Text = "AddPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_addScientificGroup;
        private System.Windows.Forms.Button b_addDepartment;
        private System.Windows.Forms.Button b_addAdviser;
        private System.Windows.Forms.Button b_addGrad;
        private System.Windows.Forms.Button b_addConf;
        private System.Windows.Forms.Button b_addSpeech;
        private System.Windows.Forms.Button b_addPubl;
        private System.Windows.Forms.Button b_addStud;
    }
}