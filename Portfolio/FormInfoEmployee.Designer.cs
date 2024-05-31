namespace Portfolio
{
    partial class FormInfoEmployee
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
            labelName = new Label();
            labelSurname = new Label();
            labelAge = new Label();
            labelRank = new Label();
            labelSalary = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxAge = new TextBox();
            textBoxRank = new TextBox();
            textBoxSalary = new TextBox();
            buttonOk = new Button();
            labelId = new Label();
            textBoxID = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(12, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 28);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(12, 90);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(93, 28);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Surname:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(12, 130);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(51, 28);
            labelAge.TabIndex = 2;
            labelAge.Text = "Age:";
            // 
            // labelRank
            // 
            labelRank.AutoSize = true;
            labelRank.Font = new Font("Segoe UI", 12F);
            labelRank.Location = new Point(12, 170);
            labelRank.Name = "labelRank";
            labelRank.Size = new Size(59, 28);
            labelRank.TabIndex = 3;
            labelRank.Text = "Rank:";
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Font = new Font("Segoe UI", 12F);
            labelSalary.Location = new Point(12, 210);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(69, 28);
            labelSalary.TabIndex = 4;
            labelSalary.Text = "Salary:";
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Location = new Point(127, 50);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(171, 28);
            textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Enabled = false;
            textBoxSurname.Location = new Point(127, 90);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(171, 28);
            textBoxSurname.TabIndex = 6;
            // 
            // textBoxAge
            // 
            textBoxAge.Enabled = false;
            textBoxAge.Location = new Point(127, 130);
            textBoxAge.Multiline = true;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(171, 28);
            textBoxAge.TabIndex = 7;
            // 
            // textBoxRank
            // 
            textBoxRank.Enabled = false;
            textBoxRank.Location = new Point(127, 170);
            textBoxRank.Multiline = true;
            textBoxRank.Name = "textBoxRank";
            textBoxRank.Size = new Size(171, 28);
            textBoxRank.TabIndex = 8;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Enabled = false;
            textBoxSalary.Location = new Point(127, 210);
            textBoxSalary.Multiline = true;
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(171, 28);
            textBoxSalary.TabIndex = 9;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(93, 270);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(129, 41);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F);
            labelId.Location = new Point(12, 10);
            labelId.Name = "labelId";
            labelId.Size = new Size(33, 28);
            labelId.TabIndex = 11;
            labelId.Text = "Id:";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(127, 10);
            textBoxID.Multiline = true;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(171, 28);
            textBoxID.TabIndex = 12;
            // 
            // FormInfoEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(317, 341);
            Controls.Add(textBoxID);
            Controls.Add(labelId);
            Controls.Add(buttonOk);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxRank);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelSalary);
            Controls.Add(labelRank);
            Controls.Add(labelAge);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInfoEmployee";
            Text = "FormInfoEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelAge;
        private Label labelRank;
        private Label labelSalary;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxAge;
        private TextBox textBoxRank;
        private TextBox textBoxSalary;
        private Button buttonOk;
        private Label labelId;
        private TextBox textBoxID;
    }
}