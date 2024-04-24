namespace PR1
{
    partial class Form2
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
            this.groupBox_Result = new System.Windows.Forms.GroupBox();
            this.textBox_CountEmployees1 = new System.Windows.Forms.TextBox();
            this.textBox_IndustryType1 = new System.Windows.Forms.TextBox();
            this.CountEmployees = new System.Windows.Forms.Label();
            this.textBox_Name1 = new System.Windows.Forms.TextBox();
            this.IndustryType = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.btn_Close1 = new System.Windows.Forms.Button();
            this.groupBox_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Result
            // 
            this.groupBox_Result.Controls.Add(this.textBox_CountEmployees1);
            this.groupBox_Result.Controls.Add(this.textBox_IndustryType1);
            this.groupBox_Result.Controls.Add(this.CountEmployees);
            this.groupBox_Result.Controls.Add(this.textBox_Name1);
            this.groupBox_Result.Controls.Add(this.IndustryType);
            this.groupBox_Result.Controls.Add(this.Name);
            this.groupBox_Result.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Result.Name = "groupBox_Result";
            this.groupBox_Result.Size = new System.Drawing.Size(348, 184);
            this.groupBox_Result.TabIndex = 3;
            this.groupBox_Result.TabStop = false;
            this.groupBox_Result.Text = "Результат:";
            // 
            // textBox_CountEmployees1
            // 
            this.textBox_CountEmployees1.Location = new System.Drawing.Point(69, 140);
            this.textBox_CountEmployees1.Name = "textBox_CountEmployees1";
            this.textBox_CountEmployees1.ReadOnly = true;
            this.textBox_CountEmployees1.Size = new System.Drawing.Size(180, 20);
            this.textBox_CountEmployees1.TabIndex = 1;
            this.textBox_CountEmployees1.TextChanged += new System.EventHandler(this.textBox_CountEmployees1_TextChanged);
            // 
            // textBox_IndustryType1
            // 
            this.textBox_IndustryType1.Location = new System.Drawing.Point(69, 91);
            this.textBox_IndustryType1.Name = "textBox_IndustryType1";
            this.textBox_IndustryType1.ReadOnly = true;
            this.textBox_IndustryType1.Size = new System.Drawing.Size(180, 20);
            this.textBox_IndustryType1.TabIndex = 1;
            // 
            // CountEmployees
            // 
            this.CountEmployees.AutoSize = true;
            this.CountEmployees.Location = new System.Drawing.Point(6, 120);
            this.CountEmployees.Name = "CountEmployees";
            this.CountEmployees.Size = new System.Drawing.Size(111, 13);
            this.CountEmployees.TabIndex = 0;
            this.CountEmployees.Text = "Кол-во сотрудников:";
            // 
            // textBox_Name1
            // 
            this.textBox_Name1.Location = new System.Drawing.Point(69, 36);
            this.textBox_Name1.Name = "textBox_Name1";
            this.textBox_Name1.ReadOnly = true;
            this.textBox_Name1.Size = new System.Drawing.Size(180, 20);
            this.textBox_Name1.TabIndex = 1;
            this.textBox_Name1.TextChanged += new System.EventHandler(this.textBox_Name1_TextChanged);
            // 
            // IndustryType
            // 
            this.IndustryType.AutoSize = true;
            this.IndustryType.Location = new System.Drawing.Point(6, 71);
            this.IndustryType.Name = "IndustryType";
            this.IndustryType.Size = new System.Drawing.Size(145, 13);
            this.IndustryType.TabIndex = 0;
            this.IndustryType.Text = "Отрасль промышленности:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(212, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Название промышленной организации: ";
            // 
            // btn_Close1
            // 
            this.btn_Close1.Location = new System.Drawing.Point(248, 202);
            this.btn_Close1.Name = "btn_Close1";
            this.btn_Close1.Size = new System.Drawing.Size(111, 60);
            this.btn_Close1.TabIndex = 4;
            this.btn_Close1.Text = "Выход";
            this.btn_Close1.UseVisualStyleBackColor = true;
            this.btn_Close1.Click += new System.EventHandler(this.btn_Close1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 276);
            this.Controls.Add(this.btn_Close1);
            this.Controls.Add(this.groupBox_Result);
            this.Text = "Form2";
            this.groupBox_Result.ResumeLayout(false);
            this.groupBox_Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Result;
        private System.Windows.Forms.TextBox textBox_CountEmployees1;
        private System.Windows.Forms.TextBox textBox_IndustryType1;
        private System.Windows.Forms.Label CountEmployees;
        private System.Windows.Forms.TextBox textBox_Name1;
        private System.Windows.Forms.Label IndustryType;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button btn_Close1;
    }
}