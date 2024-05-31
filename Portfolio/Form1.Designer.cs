namespace Portfolio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxEmployee = new ListBox();
            labelEmployee = new Label();
            buttonAddEmployee = new Button();
            buttonDeleteEmployee = new Button();
            buttonChangeEmployee = new Button();
            buttonFindEmployee = new Button();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonShowAll = new Button();
            SuspendLayout();
            // 
            // listBoxEmployee
            // 
            listBoxEmployee.BackColor = SystemColors.HighlightText;
            listBoxEmployee.FormattingEnabled = true;
            listBoxEmployee.Location = new Point(12, 58);
            listBoxEmployee.Name = "listBoxEmployee";
            listBoxEmployee.Size = new Size(293, 264);
            listBoxEmployee.TabIndex = 0;
            listBoxEmployee.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI", 10F);
            labelEmployee.Location = new Point(12, 22);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(82, 23);
            labelEmployee.TabIndex = 1;
            labelEmployee.Text = "Employes";
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(311, 58);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(146, 29);
            buttonAddEmployee.TabIndex = 2;
            buttonAddEmployee.Text = "Add Employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(311, 103);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(146, 29);
            buttonDeleteEmployee.TabIndex = 3;
            buttonDeleteEmployee.Text = "Delete Employee";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            // 
            // buttonChangeEmployee
            // 
            buttonChangeEmployee.Location = new Point(311, 147);
            buttonChangeEmployee.Name = "buttonChangeEmployee";
            buttonChangeEmployee.Size = new Size(146, 29);
            buttonChangeEmployee.TabIndex = 4;
            buttonChangeEmployee.Text = "Change Employee";
            buttonChangeEmployee.UseVisualStyleBackColor = true;
            buttonChangeEmployee.Click += buttonChangeEmployee_Click;
            // 
            // buttonFindEmployee
            // 
            buttonFindEmployee.Location = new Point(311, 325);
            buttonFindEmployee.Name = "buttonFindEmployee";
            buttonFindEmployee.Size = new Size(146, 30);
            buttonFindEmployee.TabIndex = 5;
            buttonFindEmployee.Text = "Search Employee";
            buttonFindEmployee.UseVisualStyleBackColor = true;
            buttonFindEmployee.Click += buttonFindEmployee_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(111, 325);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(193, 30);
            textBoxSurname.TabIndex = 6;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(12, 325);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(93, 28);
            labelSurname.TabIndex = 7;
            labelSurname.Text = "Surname:";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(311, 191);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(146, 29);
            buttonLoad.TabIndex = 8;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(311, 235);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(146, 29);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(311, 281);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(146, 29);
            buttonShowAll.TabIndex = 10;
            buttonShowAll.Text = "Show All";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(474, 367);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(labelSurname);
            Controls.Add(textBoxSurname);
            Controls.Add(buttonFindEmployee);
            Controls.Add(buttonChangeEmployee);
            Controls.Add(buttonDeleteEmployee);
            Controls.Add(buttonAddEmployee);
            Controls.Add(labelEmployee);
            Controls.Add(listBoxEmployee);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desktop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEmployee;
        private Label labelEmployee;
        private Button buttonAddEmployee;
        private Button buttonDeleteEmployee;
        private Button buttonChangeEmployee;
        private Button buttonFindEmployee;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonShowAll;
    }
}
