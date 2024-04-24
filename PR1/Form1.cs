using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1(string textBox_CountEmployees1)
        {
            InitializeComponent();
        }
        public int CountCalculation()
        {
            AddingEmployees addingEmployees = new AddingEmployees();
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(textBox_AddEmployees.Text))
            {
                errorProvider.SetError(textBox_AddEmployees, "Поле не должно быть пустым");
                return 0;
            }

            if (int.TryParse(textBox_AddEmployees.Text, out int addEmployees))
            {
                if (addEmployees < 0 || addEmployees == 0)
                {
                    errorProvider.SetError(textBox_AddEmployees, "Введите положительное число больше нуля");
                    return 0;
                }

                int count = addingEmployees.CalculateAdding();
                return count;
            }
            else
            {
                errorProvider.SetError(textBox_AddEmployees, "Введите целое число");
                return 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Math1_Click(object sender, EventArgs e)
        {
            CountCalculation();
            int count = CountCalculation();
            Form2 newF = new Form2();
            newF.UpdateResultTextBox($"{count}");
        }
        //int count = addingEmployees.CalculateAdding();
        //Form2 newF = new Form2(textBox_Name.Text, textBox_IndustryType.Text, textBox_AddEmployees.Text, count);
        //newF.UpdateCountTextBox(count); // Обновляем TextBox в Form2 с полученным значением
        //            newF.Show();
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
