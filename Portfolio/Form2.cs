using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public partial class Form2 : Form
    {
        private ListBox listBox;
        private readonly string mode;
        public Form2(ListBox listBox, string mode)
        {
            InitializeComponent();
            this.listBox = listBox;
            this.mode = mode;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" 
                && textBoxAge.Text != "" && textBoxRank.Text != "" && textBoxSalary.Text != "")
            {
                int age = 0;
                double salary = 0;
                bool isOk = true;

                try
                {
                    age = Convert.ToInt32(textBoxAge.Text);
                }
                catch
                {
                    textBoxAge.Text = "There must be numbers here";
                    isOk = false;
                }

                try
                {
                    salary = Convert.ToDouble(textBoxSalary.Text);
                }
                catch
                {
                    textBoxSalary.Text = "\"There must be numbers here";
                    isOk = false;
                }

                if (mode == "Add")
                {
                    if (isOk)
                    {
                        Employee employee = new Employee(textBoxName.Text, textBoxSurname.Text, textBoxRank.Text, age, salary);
                        listBox.Items.Add(employee);
                        Close();
                    }
                }
                else if (mode == "Change")
                {
                    if (isOk)
                    {
                        if (listBox.SelectedIndex >= 0)
                        {
                            Employee employee = (Employee)listBox.Items[listBox.SelectedIndex];
                            employee.Name = textBoxName.Text;
                            employee.Surname = textBoxSurname.Text;
                            employee.Rank = textBoxRank.Text;
                            employee.Age = age;
                            employee.Salary = salary;
                            listBox.Items[listBox.SelectedIndex] = employee;
                            Close();
                        }
                    }
                }
            }
        }
    }
}
