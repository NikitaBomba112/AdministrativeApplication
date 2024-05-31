namespace Portfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelName = new Label();
            textBoxName = new TextBox();
            labelSurname = new Label();
            labelAge = new Label();
            textBoxSurname = new TextBox();
            textBoxAge = new TextBox();
            labelRank = new Label();
            textBoxRank = new TextBox();
            labelSalary = new Label();
            textBoxSalary = new TextBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(12, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 28);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 11F);
            textBoxName.Location = new Point(111, 10);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(205, 28);
            textBoxName.TabIndex = 1;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(12, 60);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(93, 28);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(12, 110);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(51, 28);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 11F);
            textBoxSurname.Location = new Point(111, 60);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(205, 28);
            textBoxSurname.TabIndex = 4;
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 11F);
            textBoxAge.Location = new Point(111, 110);
            textBoxAge.Multiline = true;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(205, 28);
            textBoxAge.TabIndex = 5;
            // 
            // labelRank
            // 
            labelRank.AutoSize = true;
            labelRank.Font = new Font("Segoe UI", 12F);
            labelRank.Location = new Point(12, 160);
            labelRank.Name = "labelRank";
            labelRank.Size = new Size(59, 28);
            labelRank.TabIndex = 6;
            labelRank.Text = "Rank:";
            // 
            // textBoxRank
            // 
            textBoxRank.Font = new Font("Segoe UI", 11F);
            textBoxRank.Location = new Point(111, 160);
            textBoxRank.Multiline = true;
            textBoxRank.Name = "textBoxRank";
            textBoxRank.Size = new Size(205, 28);
            textBoxRank.TabIndex = 7;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Font = new Font("Segoe UI", 12F);
            labelSalary.Location = new Point(12, 210);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(69, 28);
            labelSalary.TabIndex = 8;
            labelSalary.Text = "Salary:";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Font = new Font("Segoe UI", 11F);
            textBoxSalary.Location = new Point(111, 210);
            textBoxSalary.Multiline = true;
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(205, 28);
            textBoxSalary.TabIndex = 9;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(38, 260);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 30);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Ok";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(183, 260);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 30);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(355, 311);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSalary);
            Controls.Add(labelSalary);
            Controls.Add(textBoxRank);
            Controls.Add(labelRank);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxSurname);
            Controls.Add(labelAge);
            Controls.Add(labelSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelSurname;
        private Label labelAge;
        private TextBox textBoxSurname;
        private TextBox textBoxAge;
        private Label labelRank;
        private TextBox textBoxRank;
        private Label labelSalary;
        private TextBox textBoxSalary;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}