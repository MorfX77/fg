using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_11
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        bool isErrored = false;
        public Form1()
        {
            InitializeComponent();

        }
        private void TextBox_AddEmployees_TextChanged(object sender, EventArgs e)
        {
            if (isErrored)
            {
                errorProvider.SetError(textBox_AddEmployees, "");
                isErrored = false;
            }
        }
        public async void CountCalculation()
        {
            CalculateAdding addingEmployees = new CalculateAdding();
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(textBox_AddEmployees.Text))
            {
                textBox_ResultName.Clear();
                textBox_Result.Clear();
                textBox_ResultIndustryType.Clear();
                errorProvider.SetError(textBox_AddEmployees, "Поле не должно быть пустым");
                await Task.Delay(3000); // Задержка в 3 секунды
                errorProvider.SetError(textBox_AddEmployees, "");

            }
            if (int.TryParse(textBox_AddEmployees.Text, out int addEmployees))
            {

                if (addEmployees < 0 || addEmployees == 0)
                {
                    textBox_ResultName.Clear();
                    textBox_Result.Clear();
                    textBox_ResultIndustryType.Clear();
                    errorProvider.SetError(textBox_AddEmployees, "Введите положительное число больше нуля");
                    await Task.Delay(3000); // Задержка в 3 секунды
                    errorProvider.SetError(textBox_AddEmployees, "");

                }
                else
                {
                    textBox_ResultName.Text = textBox_Name.Text;
                    textBox_ResultIndustryType.Text = textBox_IndustryType.Text;
                    addingEmployees.CalculateEmployees(addEmployees);
                    int count = addingEmployees.CalculateCount();
                    textBox_Result.Text = $"{count} сотрудников";
                }
            }
            else
            {
                textBox_ResultName.Clear();
                textBox_Result.Clear();
                textBox_ResultIndustryType.Clear();
                errorProvider.SetError(textBox_AddEmployees, "Введите целое число");
                await Task.Delay(3000); // Задержка в 3 секунды
                errorProvider.SetError(textBox_AddEmployees, "");
            }
            
        }
        private void btn_Math1_Click(object sender, EventArgs e)
        {
            CountCalculation();
        }

        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_AddEmployees.Clear();
            textBox_ResultIndustryType.Clear();
            textBox_IndustryType.Clear();
            textBox_Name.Clear();
            textBox_ResultName.Clear();
            textBox_Result.Clear();
        }

        private void расчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountCalculation();
        }
    }
}
