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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PR1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //textBox_Name1.Text = textBox_Name;
            //textBox_IndustryType1.Text = textBox_IndustryType;
            //textBox_CountEmployees1.Text = count.ToString();
        }
        public void UpdateResultTextBox(string result)
        {
            textBox_CountEmployees1.Text = result;
        }
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CountEmployees1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
