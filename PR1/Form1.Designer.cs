namespace PR1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Close1 = new System.Windows.Forms.Button();
            this.btn_Math1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Data1 = new System.Windows.Forms.GroupBox();
            this.textBox_Calculate = new System.Windows.Forms.TextBox();
            this.textBox_AddEmployees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmployees = new System.Windows.Forms.Label();
            this.textBox_IndustryType = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.IndustryType = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьРасчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Data1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 518);
            this.tabControl1.TabIndex = 2;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.textBox1);
            this.Page1.Controls.Add(this.btn_Close1);
            this.Page1.Controls.Add(this.btn_Math1);
            this.Page1.Controls.Add(this.groupBox1);
            this.Page1.Controls.Add(this.groupBox_Data1);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(340, 492);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Расчеты";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Close1
            // 
            this.btn_Close1.Location = new System.Drawing.Point(205, 406);
            this.btn_Close1.Name = "btn_Close1";
            this.btn_Close1.Size = new System.Drawing.Size(111, 60);
            this.btn_Close1.TabIndex = 2;
            this.btn_Close1.Text = "Выход";
            this.btn_Close1.UseVisualStyleBackColor = true;
            this.btn_Close1.Click += new System.EventHandler(this.btn_Close1_Click);
            // 
            // btn_Math1
            // 
            this.btn_Math1.Location = new System.Drawing.Point(15, 406);
            this.btn_Math1.Name = "btn_Math1";
            this.btn_Math1.Size = new System.Drawing.Size(111, 60);
            this.btn_Math1.TabIndex = 2;
            this.btn_Math1.Text = "Добавить";
            this.btn_Math1.UseVisualStyleBackColor = true;
            this.btn_Math1.Click += new System.EventHandler(this.btn_Math1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте, данная программа прибавляет сотрудников";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_Data1
            // 
            this.groupBox_Data1.Controls.Add(this.textBox_Calculate);
            this.groupBox_Data1.Controls.Add(this.textBox_AddEmployees);
            this.groupBox_Data1.Controls.Add(this.label2);
            this.groupBox_Data1.Controls.Add(this.AddEmployees);
            this.groupBox_Data1.Controls.Add(this.textBox_IndustryType);
            this.groupBox_Data1.Controls.Add(this.textBox_Name);
            this.groupBox_Data1.Controls.Add(this.IndustryType);
            this.groupBox_Data1.Controls.Add(this.Name);
            this.groupBox_Data1.Location = new System.Drawing.Point(6, 150);
            this.groupBox_Data1.Name = "groupBox_Data1";
            this.groupBox_Data1.Size = new System.Drawing.Size(328, 237);
            this.groupBox_Data1.TabIndex = 1;
            this.groupBox_Data1.TabStop = false;
            this.groupBox_Data1.Text = "Исходные данные:";
            // 
            // textBox_Calculate
            // 
            this.textBox_Calculate.Location = new System.Drawing.Point(69, 198);
            this.textBox_Calculate.Name = "textBox_Calculate";
            this.textBox_Calculate.Size = new System.Drawing.Size(0, 20);
            this.textBox_Calculate.TabIndex = 2;
            // 
            // textBox_AddEmployees
            // 
            this.textBox_AddEmployees.Location = new System.Drawing.Point(69, 148);
            this.textBox_AddEmployees.Name = "textBox_AddEmployees";
            this.textBox_AddEmployees.Size = new System.Drawing.Size(180, 20);
            this.textBox_AddEmployees.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Начальное кол-во сотрудников = 100";
            // 
            // AddEmployees
            // 
            this.AddEmployees.AutoSize = true;
            this.AddEmployees.Location = new System.Drawing.Point(6, 128);
            this.AddEmployees.Name = "AddEmployees";
            this.AddEmployees.Size = new System.Drawing.Size(290, 13);
            this.AddEmployees.TabIndex = 0;
            this.AddEmployees.Text = "Введите кол-во сотрудников которых нужно прибавить:";
            // 
            // textBox_IndustryType
            // 
            this.textBox_IndustryType.Location = new System.Drawing.Point(69, 91);
            this.textBox_IndustryType.Name = "textBox_IndustryType";
            this.textBox_IndustryType.Size = new System.Drawing.Size(180, 20);
            this.textBox_IndustryType.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(69, 36);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(180, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // IndustryType
            // 
            this.IndustryType.AutoSize = true;
            this.IndustryType.Location = new System.Drawing.Point(6, 71);
            this.IndustryType.Name = "IndustryType";
            this.IndustryType.Size = new System.Drawing.Size(188, 13);
            this.IndustryType.TabIndex = 0;
            this.IndustryType.Text = "Введите отрасль промышленности:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(255, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Введите название промышленной организации: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчётToolStripMenuItem,
            this.toolStripMenuItem1,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // расчётToolStripMenuItem
            // 
            this.расчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьРасчётToolStripMenuItem});
            this.расчётToolStripMenuItem.Name = "расчётToolStripMenuItem";
            this.расчётToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.расчётToolStripMenuItem.Text = "Расчёт";
            // 
            // выполнитьРасчётToolStripMenuItem
            // 
            this.выполнитьРасчётToolStripMenuItem.Name = "выполнитьРасчётToolStripMenuItem";
            this.выполнитьРасчётToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.выполнитьРасчётToolStripMenuItem.Text = "Выполнить расчёт";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моёToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // моёToolStripMenuItem
            // 
            this.моёToolStripMenuItem.Name = "моёToolStripMenuItem";
            this.моёToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.моёToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Data1.ResumeLayout(false);
            this.groupBox_Data1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.Button btn_Close1;
        private System.Windows.Forms.Button btn_Math1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Data1;
        private System.Windows.Forms.TextBox textBox_AddEmployees;
        private System.Windows.Forms.Label AddEmployees;
        private System.Windows.Forms.TextBox textBox_IndustryType;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label IndustryType;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моёToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem выполнитьРасчётToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_Calculate;
    }
}

