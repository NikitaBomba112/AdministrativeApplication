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
    public partial class FormInfoEmployee : Form
    {
        public FormInfoEmployee(ListBox list)
        {
            InitializeComponent();

            textBoxID.Text = Convert.ToString(((Employee)list.Items[list.SelectedIndex]).ID);
            textBoxName.Text = ((Employee)list.Items[list.SelectedIndex]).Name;
            textBoxSurname.Text = ((Employee)list.Items[list.SelectedIndex]).Surname;
            textBoxAge.Text = Convert.ToString(((Employee)list.Items[list.SelectedIndex]).Age);
            textBoxRank.Text = ((Employee)list.Items[list.SelectedIndex]).Rank;
            textBoxSalary.Text = Convert.ToString(((Employee)list.Items[list.SelectedIndex]).Salary);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
