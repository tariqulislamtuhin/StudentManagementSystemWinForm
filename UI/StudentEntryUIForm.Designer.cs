namespace StudentEntryUI
{
    partial class StudentEntryUiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.hiddentIdLevel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.updatePhoneNoButton = new System.Windows.Forms.Button();
            this.studentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.hiddentIdLevel);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.updatePhoneNoButton);
            this.groupBox1.Controls.Add(this.studentListView);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.phoneNoTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.regNoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(204, 160);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(202, 21);
            this.departmentComboBox.TabIndex = 12;
            // 
            // hiddentIdLevel
            // 
            this.hiddentIdLevel.AutoSize = true;
            this.hiddentIdLevel.Location = new System.Drawing.Point(422, 22);
            this.hiddentIdLevel.Name = "hiddentIdLevel";
            this.hiddentIdLevel.Size = new System.Drawing.Size(35, 13);
            this.hiddentIdLevel.TabIndex = 11;
            this.hiddentIdLevel.Text = "label6";
            this.hiddentIdLevel.Visible = false;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(166, 203);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(247, 203);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updatePhoneNoButton
            // 
            this.updatePhoneNoButton.Location = new System.Drawing.Point(412, 92);
            this.updatePhoneNoButton.Name = "updatePhoneNoButton";
            this.updatePhoneNoButton.Size = new System.Drawing.Size(75, 23);
            this.updatePhoneNoButton.TabIndex = 9;
            this.updatePhoneNoButton.Text = "Update";
            this.updatePhoneNoButton.UseVisualStyleBackColor = true;
            this.updatePhoneNoButton.Click += new System.EventHandler(this.updatePhoneNoButton_Click);
            // 
            // studentListView
            // 
            this.studentListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.studentListView.FullRowSelect = true;
            this.studentListView.GridLines = true;
            this.studentListView.HideSelection = false;
            this.studentListView.Location = new System.Drawing.Point(6, 243);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(617, 182);
            this.studentListView.TabIndex = 8;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            this.studentListView.DoubleClick += new System.EventHandler(this.studentListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Registration No";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone Number";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Department";
            this.columnHeader5.Width = 129;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Location = new System.Drawing.Point(339, 201);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Department";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(204, 127);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(202, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNoTextBox.Location = new System.Drawing.Point(204, 94);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(202, 20);
            this.phoneNoTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone No";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regNoTextBox.Location = new System.Drawing.Point(204, 57);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(202, 20);
            this.regNoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Registration No";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(204, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(202, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // StudentEntryUiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 466);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentEntryUiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Management App";
            this.Load += new System.EventHandler(this.StudentEntryUIForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button updatePhoneNoButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label hiddentIdLevel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}

