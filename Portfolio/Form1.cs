using System.Xml.Serialization;

namespace Portfolio
{
    public partial class Form1 : Form
    {
        FileStream stream;
        XmlSerializer serializer;
        ListBox listBoxModel;

        public Form1()
        {
            InitializeComponent();
            listBoxModel = new ListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(listBoxEmployee, "Add");

            DialogResult res = form.ShowDialog();
            Update();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployee.SelectedIndex >= 0)
            {
                listBoxEmployee.Items.RemoveAt(listBoxEmployee.SelectedIndex);
                Update();
            }
        }

        private void buttonChangeEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployee.SelectedIndex >= 0)
            {
                Form2 form = new Form2(listBoxEmployee, "Change");

                DialogResult res = form.ShowDialog();
                Update();
            }
        }

        private void buttonFindEmployee_Click(object sender, EventArgs e)
        {
            ListBox temp = new ListBox();
            bool find = false;

            foreach (Employee employee in listBoxEmployee.Items)
            {
                if (employee.Surname == textBoxSurname.Text)
                {
                    temp.Items.Add(employee);
                    find = true;
                }
            }

            if (find) 
            {
                listBoxEmployee.Items.Clear();

                foreach (Employee employee in temp.Items)
                {
                    listBoxEmployee.Items.Add(employee);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Employee> list = new List<Employee>();
            stream = new FileStream("data.xml", FileMode.Create);
            serializer = new XmlSerializer(typeof(List<Employee>));

            foreach (Employee employee in listBoxEmployee.Items)
            {
                list.Add(employee);
            }

            serializer.Serialize(stream, list);
            stream.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listBoxEmployee.Items.Clear();
            try
            {
                List<Employee> list = new List<Employee>();
                stream = new FileStream("data.xml", FileMode.Open);
                serializer = new XmlSerializer(typeof(List<Employee>));
                list = (List<Employee>)serializer.Deserialize(stream);

                foreach (Employee employee in list)
                {
                    listBoxEmployee.Items.Add(employee);
                }
                stream.Close();
            }
            catch
            {

            }

            Update();
        }

        private void Update()
        {
            listBoxModel.Items.Clear();
            foreach (Employee employee in listBoxEmployee.Items)
            {
                listBoxModel.Items.Add(employee);
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBoxEmployee.Items.Clear();

            foreach (Employee employee in listBoxModel.Items)
            {
                listBoxEmployee.Items.Add(employee);
            }
        }
    }
}
